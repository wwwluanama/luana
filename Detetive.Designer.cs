namespace Detetive
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.cbx1 = new System.Windows.Forms.ComboBox();
            this.cbx2 = new System.Windows.Forms.ComboBox();
            this.cbx4 = new System.Windows.Forms.ComboBox();
            this.cbx3 = new System.Windows.Forms.ComboBox();
            this.cbx5 = new System.Windows.Forms.ComboBox();
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detetive";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefonou para a vítima?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Esteve no local do crime?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mora perto da vítima?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(140, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ja trabalhou com a vítima?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(140, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Devia para a vítima?";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("News701 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 590);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(93, 19);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado:";
            // 
            // cbx1
            // 
            this.cbx1.FormattingEnabled = true;
            this.cbx1.Items.AddRange(new object[] {
            "sim",
            "não"});
            this.cbx1.Location = new System.Drawing.Point(143, 81);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(200, 21);
            this.cbx1.TabIndex = 7;
            // 
            // cbx2
            // 
            this.cbx2.FormattingEnabled = true;
            this.cbx2.Items.AddRange(new object[] {
            "sim",
            "não"});
            this.cbx2.Location = new System.Drawing.Point(143, 150);
            this.cbx2.Name = "cbx2";
            this.cbx2.Size = new System.Drawing.Size(200, 21);
            this.cbx2.TabIndex = 8;
            // 
            // cbx4
            // 
            this.cbx4.FormattingEnabled = true;
            this.cbx4.Items.AddRange(new object[] {
            "sim",
            "não"});
            this.cbx4.Location = new System.Drawing.Point(143, 294);
            this.cbx4.Name = "cbx4";
            this.cbx4.Size = new System.Drawing.Size(200, 21);
            this.cbx4.TabIndex = 9;
            // 
            // cbx3
            // 
            this.cbx3.FormattingEnabled = true;
            this.cbx3.Items.AddRange(new object[] {
            "sim",
            "não"});
            this.cbx3.Location = new System.Drawing.Point(143, 223);
            this.cbx3.Name = "cbx3";
            this.cbx3.Size = new System.Drawing.Size(200, 21);
            this.cbx3.TabIndex = 10;
            // 
            // cbx5
            // 
            this.cbx5.FormattingEnabled = true;
            this.cbx5.Items.AddRange(new object[] {
            "sim",
            "não"});
            this.cbx5.Location = new System.Drawing.Point(143, 374);
            this.cbx5.Name = "cbx5";
            this.cbx5.Size = new System.Drawing.Size(200, 21);
            this.cbx5.TabIndex = 11;
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalisar.Location = new System.Drawing.Point(319, 481);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(101, 33);
            this.btnAnalisar.TabIndex = 13;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            this.btnAnalisar.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 653);
            this.Controls.Add(this.btnAnalisar);
            this.Controls.Add(this.cbx5);
            this.Controls.Add(this.cbx3);
            this.Controls.Add(this.cbx4);
            this.Controls.Add(this.cbx2);
            this.Controls.Add(this.cbx1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "detetive";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ComboBox cbx1;
        private System.Windows.Forms.ComboBox cbx2;
        private System.Windows.Forms.ComboBox cbx4;
        private System.Windows.Forms.ComboBox cbx3;
        private System.Windows.Forms.ComboBox cbx5;
        private System.Windows.Forms.Button btnAnalisar;
    }
}

