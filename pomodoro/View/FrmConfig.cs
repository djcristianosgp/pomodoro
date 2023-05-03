using pomodoro.Model;
using pomodoro.Controller;

namespace pomodoro
{
    public partial class FrmConfig : Form
    {
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            Inicializa();
        }

        public void Inicializa()
        {
            Uteis.LerConfig();
            nmMinFoco.Value = Uteis.iTempoTrabalho;
            nmMinPausa.Value = Uteis.iTempoPausa;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        public void Salvar()
        {
            {
                var Dados = new ConfiguracoesViewModel();
                Dados.iTempoTrabalho = (int)nmMinFoco.Value;
                Dados.iTempoPausa = (int)nmMinPausa.Value;
                if (Uteis.SalvaConfig(Dados))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("Erro ao Salvar as Configurações");

            }
        }
    }
}
