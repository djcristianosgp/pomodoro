using pomodoro.Controller;
using System.Diagnostics;

namespace pomodoro
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public DateTime dtInicio;
        public DateTime dtFim;
        public DateTime dtPercorrido;
        public DateTime dtFaltando;

        public Stopwatch timer = new Stopwatch();

        public int iMinFoc = Uteis.iTempoTrabalho;
        public int iMinPausa = Uteis.iTempoPausa;
        public int iPbMax = 0;

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfi_Click(object sender, EventArgs e)
        {
            FrmConfig config = new FrmConfig();
            config.ShowDialog();
            if (config.DialogResult == DialogResult.OK)
            {
                Uteis.LerConfig();
                iMinFoc = Uteis.iTempoTrabalho;
                iMinPausa = Uteis.iTempoPausa;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            pbStatus.Dock = DockStyle.Fill;
            pnProgresso.Visible = false;
            pnBotoes.Visible = false;
            lblTempoPercorrido.Visible = false;
            lblTempoRestante.Visible = false;
            lblModoExecucao.Visible = false;
            piImage.Visible = false;

            CentralizaBotaoStart();
        }

        private void CentralizaBotaoStart()
        {
            int iLargurabotao = 218;
            int iLargura = (this.Width - iLargurabotao) / 2;
            int iAlturabotao = 70;
            int iAltura = (this.Height - iAlturabotao) / 2;

            int iLarguraimagem = 260;
            int iLarguraImage = (this.Width - iLarguraimagem) / 2;
            int iAlturaimagem = 150;
            int iAlturaImage = (this.Height - iAlturaimagem) / 2;


            //posicão botão
            btnStartPrincipal.Location = new Point(iLargura, iAltura);
            btnStartPrincipal.Size = new Size(iLargurabotao, iAlturabotao);

            //posicão imagem
            piImage.Location = new Point(iLarguraImage, iAlturaImage);
            piImage.Size = new Size(iLarguraimagem, iAlturaimagem);

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CentralizaBotaoStart();
        }

        private void FU_Start()
        {
            pnBotoes.Visible = true;
            pnProgresso.Visible = true;
            pbStatus.Value = 0;
            tipomodoro.Start();
            dtInicio = DateTime.Now;
            dtFim = DateTime.Now.AddMinutes(iMinFoc);
            var temporestante = dtFim - dtInicio;
            pbStatus.Maximum = (int)temporestante.TotalSeconds;
            btnStartPrincipal.Visible = false;
            lblTempoPercorrido.Visible = true;
            lblTempoRestante.Visible = true;
            lblModoExecucao.Visible = true;
            lblModoExecucao.Text = "Modo: Foco!!";
            lblModoExecucao.ForeColor = Color.OrangeRed;
            piImage.Visible = true;
            piImage.BackgroundImage = imlIcones.Images[0];
            btnStart.Visible = false;
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = Uteis.bMaximizarModoFoco == true ? FormWindowState.Maximized : this.WindowState;
            if(Uteis.bNotificarModoFoco)
                Fu_EnviaNoificação(lblModoExecucao.Text, "Hora de voltar ao trabalho!!!");
        }

        private void FU_Return()
        {
            tipomodoro.Start();
            btnStart.Visible = false;
            btnPause.Visible = true;
            lblModoExecucao.Text = "Modo: Foco!!";
            lblModoExecucao.ForeColor = Color.OrangeRed;
            piImage.BackgroundImage = imlIcones.Images[0];
        }

        private void FU_Momento_Pausa()
        {
            tipausa.Start();
            pnBotoes.Visible = false;
            pnProgresso.Visible = true;
            pbStatus.Value = 0;
            dtInicio = DateTime.Now;
            dtFim = DateTime.Now.AddMinutes(iMinPausa);
            var temporestante = dtFim - dtInicio;
            pbStatus.Maximum = (int)temporestante.TotalSeconds;
            btnStartPrincipal.Visible = false;
            lblTempoPercorrido.Visible = true;
            lblTempoRestante.Visible = true;
            lblModoExecucao.Visible = true;
            lblModoExecucao.Text = "Modo: Descanso!!";
            lblModoExecucao.ForeColor = Color.Chartreuse;
            piImage.BackgroundImage = imlIcones.Images[1];
            btnStart.Visible = false;
            this.WindowState = Uteis.bMaximizarModoDescanso == true ? FormWindowState.Maximized : this.WindowState;
            if (Uteis.bNotificarModoDescanso)
                Fu_EnviaNoificação(lblModoExecucao.Text, "Pausa para o cafezinho!!!");
        }

        private void FU_Pause()
        {
            tipomodoro.Stop();
            btnStart.Visible = true;
            btnPause.Visible = false;
            lblModoExecucao.Text = "Pausado";
            lblModoExecucao.ForeColor = Color.Yellow;
            piImage.BackgroundImage = imlIcones.Images[2];
        }

        private void FU_Stop()
        {
            pnBotoes.Visible = false;
            pnProgresso.Visible = false;
            pbStatus.Value = 0;
            tipomodoro.Stop();
            btnStartPrincipal.Visible = true;
            lblTempoPercorrido.Visible = false;
            lblTempoRestante.Visible = false;
            lblTempoPercorrido.Visible = false;
            lblTempoRestante.Visible = false;
            lblModoExecucao.Visible = false;
            piImage.Visible = false;
            lblModoExecucao.Text = "...";
            lblModoExecucao.ForeColor = Color.White;
        }

        public void Fu_EnviaNoificação(string Titulo, string Texto)
        {
            notification.BalloonTipTitle = Titulo;
            notification.BalloonTipText = Texto;
            notification.ShowBalloonTip(5000);
            notification.Visible = true;
        }

        private void btnStartPrincipal_Click(object sender, EventArgs e)
        {
            FU_Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            FU_Return();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            FU_Pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            FU_Stop();
        }

        private void tipomodoro_Tick(object sender, EventArgs e)
        {
            CalculaTempo();
            if (pbStatus.Value < pbStatus.Maximum)
                pbStatus.Value = pbStatus.Value + 1;
            else
            {
                FU_Momento_Pausa();
                tipomodoro.Stop();
            }
        }

        public void CalculaTempo()
        {
            try
            {
                var temporestante = dtFim - DateTime.Now;
                var tempopercorrido = DateTime.Now - dtInicio;
                if (temporestante.Ticks > 0)
                {
                    lblTempoRestante.Text = "Tempo Restante: " + new DateTime(temporestante.Ticks).ToString("HH:mm:ss");
                    lblTempoPercorrido.Text = "Tempo Percorrido: " + new DateTime(tempopercorrido.Ticks).ToString("HH:mm:ss");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tipausa_Tick(object sender, EventArgs e)
        {
            CalculaTempo();
            if (pbStatus.Value < pbStatus.Maximum)
                pbStatus.Value = pbStatus.Value + 1;
            else
            {
                FU_Start();
                tipausa.Stop();
            }
        }
    }
}