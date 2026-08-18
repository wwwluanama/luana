namespace ProjetoBiblioteca
{
    partial class F_Inicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bntprosseguir = new System.Windows.Forms.Button();
            this.llSESI = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Location = new System.Drawing.Point(120, 66);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(175, 20);
            this.tbxUsuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de usuário";
            // 
            // tbxSenha
            // 
            this.tbxSenha.Location = new System.Drawing.Point(132, 152);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.Size = new System.Drawing.Size(175, 20);
            this.tbxSenha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha";
            // 
            // cbxTipo
            // 
            this.cbxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Aluno",
            "Bibliotecário"});
            this.cbxTipo.Location = new System.Drawing.Point(179, 268);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(175, 20);
            this.cbxTipo.TabIndex = 7;
            this.cbxTipo.Text = "Aluno";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-13, 499);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1035, 106);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // bntprosseguir
            // 
            this.bntprosseguir.BackColor = System.Drawing.Color.White;
            this.bntprosseguir.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntprosseguir.Location = new System.Drawing.Point(382, 526);
            this.bntprosseguir.Name = "bntprosseguir";
            this.bntprosseguir.Size = new System.Drawing.Size(189, 55);
            this.bntprosseguir.TabIndex = 10;
            this.bntprosseguir.Text = "prosseguir";
            this.bntprosseguir.UseVisualStyleBackColor = false;
            this.bntprosseguir.Click += new System.EventHandler(this.bntprosseguir_Click_1);
            // 
            // llSESI
            // 
            this.llSESI.AutoSize = true;
            this.llSESI.BackColor = System.Drawing.Color.LightSkyBlue;
            this.llSESI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llSESI.LinkColor = System.Drawing.Color.Black;
            this.llSESI.Location = new System.Drawing.Point(12, 476);
            this.llSESI.Name = "llSESI";
            this.llSESI.Size = new System.Drawing.Size(181, 20);
            this.llSESI.TabIndex = 8;
            this.llSESI.TabStop = true;
            this.llSESI.Text = "Biblioteca - Escola SESI";
            this.llSESI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSESI_LinkClicked);
            // 
            // F_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoBiblioteca.Properties.Resources.banner_0;
            this.ClientSize = new System.Drawing.Size(942, 593);
            this.Controls.Add(this.bntprosseguir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.llSESI);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.label1);
            this.Name = "F_Inicio";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bntprosseguir;
        private System.Windows.Forms.LinkLabel llSESI;
    }
}

