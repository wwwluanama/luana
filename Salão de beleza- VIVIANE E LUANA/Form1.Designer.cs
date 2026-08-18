namespace Salão_de_beleza__VIVIANE_E_LUANA
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
            this.bntAgendamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntAgendamento
            // 
            this.bntAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAgendamento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bntAgendamento.Location = new System.Drawing.Point(560, 460);
            this.bntAgendamento.Name = "bntAgendamento";
            this.bntAgendamento.Size = new System.Drawing.Size(281, 54);
            this.bntAgendamento.TabIndex = 0;
            this.bntAgendamento.Text = "AGENDAMENTO";
            this.bntAgendamento.UseVisualStyleBackColor = true;
            this.bntAgendamento.Click += new System.EventHandler(this.bntAgendamrnto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Salão_de_beleza__VIVIANE_E_LUANA.Properties.Resources.Escala_Cinza_com_Vermelho_Salão_de_Cabeleireiro_Beleza_Capa_Facebook__1_;
            this.ClientSize = new System.Drawing.Size(1369, 526);
            this.Controls.Add(this.bntAgendamento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntAgendamento;
    }
}

