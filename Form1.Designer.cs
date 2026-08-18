namespace Login
{
    partial class Login
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
            this.btnBotão = new System.Windows.Forms.Button();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.chxExporsenha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // btnBotão
            // 
            this.btnBotão.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBotão.Location = new System.Drawing.Point(191, 248);
            this.btnBotão.Name = "btnBotão";
            this.btnBotão.Size = new System.Drawing.Size(137, 47);
            this.btnBotão.TabIndex = 1;
            this.btnBotão.Text = "Entrar";
            this.btnBotão.UseVisualStyleBackColor = true;
            this.btnBotão.Click += new System.EventHandler(this.btnBotão_Click);
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Location = new System.Drawing.Point(334, 63);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(130, 20);
            this.tbxUsuario.TabIndex = 2;
            this.tbxUsuario.TextChanged += new System.EventHandler(this.tbxUsuario_TextChanged);
            // 
            // tbxSenha
            // 
            this.tbxSenha.Location = new System.Drawing.Point(334, 127);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.PasswordChar = '*';
            this.tbxSenha.Size = new System.Drawing.Size(130, 20);
            this.tbxSenha.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(452, 248);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(155, 47);
            this.btnlimpar.TabIndex = 5;
            this.btnlimpar.Text = "limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // chxExporsenha
            // 
            this.chxExporsenha.Appearance = System.Windows.Forms.Appearance.Button;
            this.chxExporsenha.AutoSize = true;
            this.chxExporsenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chxExporsenha.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chxExporsenha.Checked = true;
            this.chxExporsenha.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chxExporsenha.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.chxExporsenha.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxExporsenha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chxExporsenha.Location = new System.Drawing.Point(470, 125);
            this.chxExporsenha.Name = "chxExporsenha";
            this.chxExporsenha.Size = new System.Drawing.Size(84, 24);
            this.chxExporsenha.TabIndex = 6;
            this.chxExporsenha.Text = "Expor senha";
            this.chxExporsenha.UseVisualStyleBackColor = true;
            this.chxExporsenha.CheckedChanged += new System.EventHandler(this.chxExporsenha_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chxExporsenha);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.btnBotão);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "l";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBotão;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.CheckBox chxExporsenha;
    }
}

