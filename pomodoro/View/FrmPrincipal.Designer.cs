namespace pomodoro
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            btnConfi = new Button();
            toolTip1 = new ToolTip(components);
            btnFechar = new Button();
            btnMinimizar = new Button();
            pnProgresso = new Panel();
            pbStatus = new ProgressBar();
            btnStartPrincipal = new Button();
            pnBotoes = new Panel();
            btnStart = new Button();
            btnPause = new Button();
            btnStop = new Button();
            tipomodoro = new System.Windows.Forms.Timer(components);
            lblTempoPercorrido = new Label();
            lblTempoRestante = new Label();
            panel1 = new Panel();
            tipausa = new System.Windows.Forms.Timer(components);
            lblModoExecucao = new Label();
            imlIcones = new ImageList(components);
            piImage = new PictureBox();
            pnProgresso.SuspendLayout();
            pnBotoes.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)piImage).BeginInit();
            SuspendLayout();
            // 
            // btnConfi
            // 
            btnConfi.FlatAppearance.BorderSize = 0;
            btnConfi.FlatStyle = FlatStyle.Flat;
            btnConfi.Image = (Image)resources.GetObject("btnConfi.Image");
            btnConfi.Location = new Point(3, 0);
            btnConfi.Name = "btnConfi";
            btnConfi.Size = new Size(45, 45);
            btnConfi.TabIndex = 0;
            toolTip1.SetToolTip(btnConfi, "Abrir Configurações");
            btnConfi.UseVisualStyleBackColor = true;
            btnConfi.Click += btnConfi_Click;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Image = (Image)resources.GetObject("btnFechar.Image");
            btnFechar.Location = new Point(482, 3);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(45, 45);
            btnFechar.TabIndex = 2;
            toolTip1.SetToolTip(btnFechar, "Abrir Configurações");
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(437, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(45, 45);
            btnMinimizar.TabIndex = 3;
            toolTip1.SetToolTip(btnMinimizar, "Abrir Configurações");
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // pnProgresso
            // 
            pnProgresso.Controls.Add(pbStatus);
            pnProgresso.Dock = DockStyle.Bottom;
            pnProgresso.Location = new Point(0, 398);
            pnProgresso.Name = "pnProgresso";
            pnProgresso.Size = new Size(529, 44);
            pnProgresso.TabIndex = 1;
            // 
            // pbStatus
            // 
            pbStatus.Location = new Point(74, 17);
            pbStatus.Name = "pbStatus";
            pbStatus.Size = new Size(100, 23);
            pbStatus.TabIndex = 0;
            // 
            // btnStartPrincipal
            // 
            btnStartPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnStartPrincipal.FlatAppearance.BorderSize = 0;
            btnStartPrincipal.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 80, 80);
            btnStartPrincipal.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            btnStartPrincipal.FlatStyle = FlatStyle.Flat;
            btnStartPrincipal.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnStartPrincipal.Image = (Image)resources.GetObject("btnStartPrincipal.Image");
            btnStartPrincipal.Location = new Point(148, 180);
            btnStartPrincipal.Name = "btnStartPrincipal";
            btnStartPrincipal.Size = new Size(218, 70);
            btnStartPrincipal.TabIndex = 4;
            btnStartPrincipal.Text = "Start";
            btnStartPrincipal.TextImageRelation = TextImageRelation.ImageAboveText;
            btnStartPrincipal.UseVisualStyleBackColor = true;
            btnStartPrincipal.Click += btnStartPrincipal_Click;
            // 
            // pnBotoes
            // 
            pnBotoes.Controls.Add(btnStart);
            pnBotoes.Controls.Add(btnPause);
            pnBotoes.Controls.Add(btnStop);
            pnBotoes.Dock = DockStyle.Bottom;
            pnBotoes.Location = new Point(0, 348);
            pnBotoes.Name = "pnBotoes";
            pnBotoes.Size = new Size(529, 50);
            pnBotoes.TabIndex = 5;
            // 
            // btnStart
            // 
            btnStart.Dock = DockStyle.Right;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 80, 80);
            btnStart.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Image = (Image)resources.GetObject("btnStart.Image");
            btnStart.Location = new Point(379, 0);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(50, 50);
            btnStart.TabIndex = 7;
            btnStart.TextImageRelation = TextImageRelation.ImageAboveText;
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnPause
            // 
            btnPause.Dock = DockStyle.Right;
            btnPause.FlatAppearance.BorderSize = 0;
            btnPause.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 80, 80);
            btnPause.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            btnPause.FlatStyle = FlatStyle.Flat;
            btnPause.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnPause.Image = (Image)resources.GetObject("btnPause.Image");
            btnPause.Location = new Point(429, 0);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(50, 50);
            btnPause.TabIndex = 6;
            btnPause.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // btnStop
            // 
            btnStop.Dock = DockStyle.Right;
            btnStop.FlatAppearance.BorderSize = 0;
            btnStop.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 80, 80);
            btnStop.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnStop.Image = (Image)resources.GetObject("btnStop.Image");
            btnStop.Location = new Point(479, 0);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(50, 50);
            btnStop.TabIndex = 5;
            btnStop.TextImageRelation = TextImageRelation.ImageAboveText;
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // tipomodoro
            // 
            tipomodoro.Interval = 1000;
            tipomodoro.Tick += tipomodoro_Tick;
            // 
            // lblTempoPercorrido
            // 
            lblTempoPercorrido.Dock = DockStyle.Top;
            lblTempoPercorrido.Font = new Font("Century Gothic", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTempoPercorrido.Location = new Point(0, 51);
            lblTempoPercorrido.Name = "lblTempoPercorrido";
            lblTempoPercorrido.Size = new Size(529, 43);
            lblTempoPercorrido.TabIndex = 6;
            lblTempoPercorrido.Text = "...";
            lblTempoPercorrido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTempoRestante
            // 
            lblTempoRestante.Dock = DockStyle.Top;
            lblTempoRestante.Font = new Font("Century Gothic", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTempoRestante.Location = new Point(0, 94);
            lblTempoRestante.Name = "lblTempoRestante";
            lblTempoRestante.Size = new Size(529, 43);
            lblTempoRestante.TabIndex = 7;
            lblTempoRestante.Text = "...";
            lblTempoRestante.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnConfi);
            panel1.Controls.Add(btnMinimizar);
            panel1.Controls.Add(btnFechar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(529, 51);
            panel1.TabIndex = 8;
            // 
            // tipausa
            // 
            tipausa.Interval = 1000;
            tipausa.Tick += tipausa_Tick;
            // 
            // lblModoExecucao
            // 
            lblModoExecucao.Dock = DockStyle.Bottom;
            lblModoExecucao.Font = new Font("Century Gothic", 40F, FontStyle.Regular, GraphicsUnit.Point);
            lblModoExecucao.Location = new Point(0, 280);
            lblModoExecucao.Margin = new Padding(0);
            lblModoExecucao.Name = "lblModoExecucao";
            lblModoExecucao.Size = new Size(529, 68);
            lblModoExecucao.TabIndex = 9;
            lblModoExecucao.Text = "...";
            lblModoExecucao.TextAlign = ContentAlignment.TopCenter;
            // 
            // imlIcones
            // 
            imlIcones.ColorDepth = ColorDepth.Depth32Bit;
            imlIcones.ImageStream = (ImageListStreamer)resources.GetObject("imlIcones.ImageStream");
            imlIcones.TransparentColor = Color.Transparent;
            imlIcones.Images.SetKeyName(0, "pngwing.com.png");
            imlIcones.Images.SetKeyName(1, "RelaxTrabalho.png");
            imlIcones.Images.SetKeyName(2, "tomandocafe.png");
            // 
            // piImage
            // 
            piImage.BackgroundImage = (Image)resources.GetObject("piImage.BackgroundImage");
            piImage.BackgroundImageLayout = ImageLayout.Center;
            piImage.Location = new Point(-33, 140);
            piImage.Name = "piImage";
            piImage.Size = new Size(260, 150);
            piImage.TabIndex = 10;
            piImage.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(529, 442);
            Controls.Add(piImage);
            Controls.Add(lblModoExecucao);
            Controls.Add(lblTempoRestante);
            Controls.Add(lblTempoPercorrido);
            Controls.Add(pnBotoes);
            Controls.Add(btnStartPrincipal);
            Controls.Add(pnProgresso);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pomodoro";
            Load += Form1_Load;
            Resize += Form1_Resize;
            pnProgresso.ResumeLayout(false);
            pnBotoes.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)piImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnConfi;
        private ToolTip toolTip1;
        private Panel pnProgresso;
        private Button btnFechar;
        private Button btnMinimizar;
        private Button btnStartPrincipal;
        private Panel pnBotoes;
        private Button btnStart;
        private Button btnPause;
        private Button btnStop;
        private ProgressBar pbStatus;
        private System.Windows.Forms.Timer tipomodoro;
        private Label lblTempoPercorrido;
        private Label lblTempoRestante;
        private Panel panel1;
        private System.Windows.Forms.Timer tipausa;
        private Label lblModoExecucao;
        private ImageList imlIcones;
        private PictureBox piImage;
    }
}