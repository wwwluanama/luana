namespace QuantidadeDeJogos__ATIVIDADE
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
            this.tbxqtd = new System.Windows.Forms.TextBox();
            this.btnverficar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jogos";
            // 
            // tbxqtd
            // 
            this.tbxqtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxqtd.Location = new System.Drawing.Point(377, 155);
            this.tbxqtd.Name = "tbxqtd";
            this.tbxqtd.Size = new System.Drawing.Size(176, 29);
            this.tbxqtd.TabIndex = 1;
            // 
            // btnverficar
            // 
            this.btnverficar.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverficar.Location = new System.Drawing.Point(392, 226);
            this.btnverficar.Name = "btnverficar";
            this.btnverficar.Size = new System.Drawing.Size(149, 41);
            this.btnverficar.TabIndex = 2;
            this.btnverficar.Text = "verificar";
            this.btnverficar.UseVisualStyleBackColor = true;
            this.btnverficar.Click += new System.EventHandler(this.btnverficar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(971, 501);
            this.Controls.Add(this.btnverficar);
            this.Controls.Add(this.tbxqtd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxqtd;
        private System.Windows.Forms.Button btnverficar;
    }
}

