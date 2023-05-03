namespace pomodoro
{
    partial class FrmConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfig));
            panel1 = new Panel();
            btnSalvar = new Button();
            btnCancelar = new Button();
            nmMinFoco = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nmMinPausa = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmMinFoco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmMinPausa).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(btnCancelar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 81);
            panel1.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.Dock = DockStyle.Right;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 80, 80);
            btnSalvar.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(71, 0);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(172, 81);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Dock = DockStyle.Right;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 80, 80);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(243, 0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(172, 81);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // nmMinFoco
            // 
            nmMinFoco.BackColor = Color.FromArgb(70, 70, 70);
            nmMinFoco.BorderStyle = BorderStyle.None;
            nmMinFoco.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nmMinFoco.ForeColor = Color.White;
            nmMinFoco.Location = new Point(161, 21);
            nmMinFoco.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            nmMinFoco.Minimum = new decimal(new int[] { 15, 0, 0, 0 });
            nmMinFoco.Name = "nmMinFoco";
            nmMinFoco.Size = new Size(120, 23);
            nmMinFoco.TabIndex = 1;
            nmMinFoco.TextAlign = HorizontalAlignment.Center;
            nmMinFoco.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(135, 21);
            label1.TabIndex = 2;
            label1.Text = "Tempo de Foco:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(287, 20);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 3;
            label2.Text = "(Minutos)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(287, 56);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 6;
            label3.Text = "(Minutos)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 56);
            label4.Name = "label4";
            label4.Size = new Size(144, 21);
            label4.TabIndex = 5;
            label4.Text = "Tempo de Pausa:";
            // 
            // nmMinPausa
            // 
            nmMinPausa.BackColor = Color.FromArgb(70, 70, 70);
            nmMinPausa.BorderStyle = BorderStyle.None;
            nmMinPausa.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nmMinPausa.ForeColor = Color.White;
            nmMinPausa.Location = new Point(161, 57);
            nmMinPausa.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            nmMinPausa.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nmMinPausa.Name = "nmMinPausa";
            nmMinPausa.Size = new Size(120, 23);
            nmMinPausa.TabIndex = 4;
            nmMinPausa.TextAlign = HorizontalAlignment.Center;
            nmMinPausa.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // FrmConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(415, 205);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(nmMinPausa);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nmMinFoco);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmConfig";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configurações";
            Load += FrmConfig_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmMinFoco).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmMinPausa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnSalvar;
        private Button btnCancelar;
        private NumericUpDown nmMinFoco;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown nmMinPausa;
    }
}