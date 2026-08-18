namespace votoWhile
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCandidato1 = new System.Windows.Forms.TextBox();
            this.tbxCandidato2 = new System.Windows.Forms.TextBox();
            this.bntvotacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Candidato 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Candidato 2";
            // 
            // tbxCandidato1
            // 
            this.tbxCandidato1.Location = new System.Drawing.Point(493, 90);
            this.tbxCandidato1.Name = "tbxCandidato1";
            this.tbxCandidato1.Size = new System.Drawing.Size(129, 20);
            this.tbxCandidato1.TabIndex = 2;
            this.tbxCandidato1.TextChanged += new System.EventHandler(this.tbxCandidato1_TextChanged);
            // 
            // tbxCandidato2
            // 
            this.tbxCandidato2.Location = new System.Drawing.Point(493, 151);
            this.tbxCandidato2.Name = "tbxCandidato2";
            this.tbxCandidato2.Size = new System.Drawing.Size(129, 20);
            this.tbxCandidato2.TabIndex = 3;
            // 
            // bntvotacao
            // 
            this.bntvotacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bntvotacao.ForeColor = System.Drawing.Color.Black;
            this.bntvotacao.Location = new System.Drawing.Point(397, 289);
            this.bntvotacao.Name = "bntvotacao";
            this.bntvotacao.Size = new System.Drawing.Size(210, 57);
            this.bntvotacao.TabIndex = 4;
            this.bntvotacao.Text = "Votar";
            this.bntvotacao.UseVisualStyleBackColor = false;
            this.bntvotacao.Click += new System.EventHandler(this.bntvotacao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::votoWhile.Properties.Resources.abstracto_branco_e_cinza_claro_onda_moderna_textura_de_luxo_suave_1093951_11380;
            this.ClientSize = new System.Drawing.Size(1015, 665);
            this.Controls.Add(this.bntvotacao);
            this.Controls.Add(this.tbxCandidato2);
            this.Controls.Add(this.tbxCandidato1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCandidato1;
        private System.Windows.Forms.TextBox tbxCandidato2;
        private System.Windows.Forms.Button bntvotacao;
    }
}

