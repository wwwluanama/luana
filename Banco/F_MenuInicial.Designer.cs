namespace Banco
{
    partial class F_MenuInicial
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
            this.chxExibir = new System.Windows.Forms.CheckBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSaque = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(522, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saldo";
            // 
            // chxExibir
            // 
            this.chxExibir.AutoSize = true;
            this.chxExibir.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chxExibir.Checked = true;
            this.chxExibir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chxExibir.Cursor = System.Windows.Forms.Cursors.Default;
            this.chxExibir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chxExibir.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxExibir.Location = new System.Drawing.Point(505, 123);
            this.chxExibir.Name = "chxExibir";
            this.chxExibir.Size = new System.Drawing.Size(80, 27);
            this.chxExibir.TabIndex = 2;
            this.chxExibir.Text = "Exibir";
            this.chxExibir.UseVisualStyleBackColor = true;
            this.chxExibir.CheckedChanged += new System.EventHandler(this.chxExibir_CheckedChanged);
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(405, 215);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(130, 28);
            this.btnDepositar.TabIndex = 3;
            this.btnDepositar.Text = "Depósito";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSaque
            // 
            this.btnSaque.Location = new System.Drawing.Point(590, 215);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(130, 28);
            this.btnSaque.TabIndex = 4;
            this.btnSaque.Text = "Saque";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(514, 100);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(71, 20);
            this.lblSaldo.TabIndex = 5;
            this.lblSaldo.Text = "label3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Banco.Properties.Resources.Eye_PNG_Image;
            this.pictureBox1.Location = new System.Drawing.Point(468, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // F_MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = global::Banco.Properties.Resources.wayup26;
            this.ClientSize = new System.Drawing.Size(1150, 447);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnSaque);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.chxExibir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_MenuInicial";
            this.Text = "F_MenuInicial";
            this.Load += new System.EventHandler(this.F_MenuInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chxExibir;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}