namespace Atividade
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
            this.tbxTeste2 = new System.Windows.Forms.CheckBox();
            this.tbxTeste1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbxTeste2
            // 
            this.tbxTeste2.AutoSize = true;
            this.tbxTeste2.Location = new System.Drawing.Point(328, 170);
            this.tbxTeste2.Name = "tbxTeste2";
            this.tbxTeste2.Size = new System.Drawing.Size(53, 17);
            this.tbxTeste2.TabIndex = 1;
            this.tbxTeste2.Text = "Teste";
            this.tbxTeste2.UseVisualStyleBackColor = true;
            this.tbxTeste2.CheckedChanged += new System.EventHandler(this.tbxTeste2_CheckedChanged_1);
            // 
            // tbxTeste1
            // 
            this.tbxTeste1.AutoSize = true;
            this.tbxTeste1.Location = new System.Drawing.Point(328, 109);
            this.tbxTeste1.Name = "tbxTeste1";
            this.tbxTeste1.Size = new System.Drawing.Size(53, 17);
            this.tbxTeste1.TabIndex = 0;
            this.tbxTeste1.Text = "Teste";
            this.tbxTeste1.UseVisualStyleBackColor = true;
            this.tbxTeste1.CheckedChanged += new System.EventHandler(this.tbxTeste1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxTeste2);
            this.Controls.Add(this.tbxTeste1);
            this.Name = "Form1";
            this.Text = "ATIVIDADE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox tbxTeste2;
        private System.Windows.Forms.CheckBox tbxTeste1;
    }
}

