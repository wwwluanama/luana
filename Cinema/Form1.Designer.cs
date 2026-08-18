namespace Cinema
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
            this.label4 = new System.Windows.Forms.Label();
            this.chxcombo1 = new System.Windows.Forms.CheckBox();
            this.cbx1filme = new System.Windows.Forms.ComboBox();
            this.chxcombo2 = new System.Windows.Forms.CheckBox();
            this.rbMeia = new System.Windows.Forms.RadioButton();
            this.rbInteira = new System.Windows.Forms.RadioButton();
            this.btn3comprar = new System.Windows.Forms.Button();
            this.tbx2quant = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(87, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filme selecionado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(87, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Firebrick;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1103, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Combos";
            // 
            // chxcombo1
            // 
            this.chxcombo1.AutoSize = true;
            this.chxcombo1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxcombo1.Location = new System.Drawing.Point(1067, 285);
            this.chxcombo1.Name = "chxcombo1";
            this.chxcombo1.Size = new System.Drawing.Size(101, 24);
            this.chxcombo1.TabIndex = 4;
            this.chxcombo1.Text = "Combo 1";
            this.chxcombo1.UseVisualStyleBackColor = true;
            // 
            // cbx1filme
            // 
            this.cbx1filme.FormattingEnabled = true;
            this.cbx1filme.Items.AddRange(new object[] {
            "Nosferatu",
            "Homem-aranha"});
            this.cbx1filme.Location = new System.Drawing.Point(257, 105);
            this.cbx1filme.Name = "cbx1filme";
            this.cbx1filme.Size = new System.Drawing.Size(121, 21);
            this.cbx1filme.TabIndex = 5;
            // 
            // chxcombo2
            // 
            this.chxcombo2.AutoSize = true;
            this.chxcombo2.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxcombo2.Location = new System.Drawing.Point(1067, 324);
            this.chxcombo2.Name = "chxcombo2";
            this.chxcombo2.Size = new System.Drawing.Size(108, 27);
            this.chxcombo2.TabIndex = 6;
            this.chxcombo2.Text = "Combo 2";
            this.chxcombo2.UseVisualStyleBackColor = true;
            // 
            // rbMeia
            // 
            this.rbMeia.AutoSize = true;
            this.rbMeia.Location = new System.Drawing.Point(29, 77);
            this.rbMeia.Name = "rbMeia";
            this.rbMeia.Size = new System.Drawing.Size(69, 28);
            this.rbMeia.TabIndex = 7;
            this.rbMeia.TabStop = true;
            this.rbMeia.Text = "Meia";
            this.rbMeia.UseVisualStyleBackColor = true;
            // 
            // rbInteira
            // 
            this.rbInteira.AutoSize = true;
            this.rbInteira.Checked = true;
            this.rbInteira.Location = new System.Drawing.Point(29, 36);
            this.rbInteira.Name = "rbInteira";
            this.rbInteira.Size = new System.Drawing.Size(78, 28);
            this.rbInteira.TabIndex = 8;
            this.rbInteira.TabStop = true;
            this.rbInteira.Text = "Inteira";
            this.rbInteira.UseVisualStyleBackColor = true;
            // 
            // btn3comprar
            // 
            this.btn3comprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3comprar.Location = new System.Drawing.Point(166, 493);
            this.btn3comprar.Name = "btn3comprar";
            this.btn3comprar.Size = new System.Drawing.Size(114, 28);
            this.btn3comprar.TabIndex = 9;
            this.btn3comprar.Text = "Comprar";
            this.btn3comprar.UseVisualStyleBackColor = true;
            this.btn3comprar.Click += new System.EventHandler(this.btn3comprar_Click);
            // 
            // tbx2quant
            // 
            this.tbx2quant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx2quant.Location = new System.Drawing.Point(200, 424);
            this.tbx2quant.Name = "tbx2quant";
            this.tbx2quant.Size = new System.Drawing.Size(147, 26);
            this.tbx2quant.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Controls.Add(this.rbInteira);
            this.groupBox1.Controls.Add(this.rbMeia);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(150, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 124);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Sitka Subheading", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1142, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 42);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nosferatu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cinema.Properties.Resources.thumb_1920_1393384;
            this.ClientSize = new System.Drawing.Size(1312, 728);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbx2quant);
            this.Controls.Add(this.btn3comprar);
            this.Controls.Add(this.chxcombo2);
            this.Controls.Add(this.cbx1filme);
            this.Controls.Add(this.chxcombo1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chxcombo1;
        private System.Windows.Forms.ComboBox cbx1filme;
        private System.Windows.Forms.CheckBox chxcombo2;
        private System.Windows.Forms.RadioButton rbMeia;
        private System.Windows.Forms.RadioButton rbInteira;
        private System.Windows.Forms.Button btn3comprar;
        private System.Windows.Forms.TextBox tbx2quant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}

