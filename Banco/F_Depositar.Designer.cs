namespace Banco
{
    partial class F_Depositar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxAgencia = new System.Windows.Forms.TextBox();
            this.tbxConta = new System.Windows.Forms.TextBox();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(432, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Depósito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Agência";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor";
            // 
            // tbxAgencia
            // 
            this.tbxAgencia.Location = new System.Drawing.Point(388, 112);
            this.tbxAgencia.Name = "tbxAgencia";
            this.tbxAgencia.Size = new System.Drawing.Size(201, 20);
            this.tbxAgencia.TabIndex = 4;
            // 
            // tbxConta
            // 
            this.tbxConta.Location = new System.Drawing.Point(388, 197);
            this.tbxConta.Name = "tbxConta";
            this.tbxConta.Size = new System.Drawing.Size(201, 20);
            this.tbxConta.TabIndex = 5;
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(388, 274);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(201, 20);
            this.tbxValor.TabIndex = 6;
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(401, 340);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(168, 52);
            this.btnDepositar.TabIndex = 7;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // F_Depositar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Banco.Properties.Resources.depositphotos_616335228_stock_photo_person_hands_working_laptop_computer;
            this.ClientSize = new System.Drawing.Size(1084, 537);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.tbxConta);
            this.Controls.Add(this.tbxAgencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_Depositar";
            this.Text = "F_Depositar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxAgencia;
        private System.Windows.Forms.TextBox tbxConta;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.Button btnDepositar;
    }
}