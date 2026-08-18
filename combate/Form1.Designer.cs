namespace combate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAtaque1 = new System.Windows.Forms.Button();
            this.btnDefesa1 = new System.Windows.Forms.Button();
            this.btnDefesa2 = new System.Windows.Forms.Button();
            this.btnAtaque2 = new System.Windows.Forms.Button();
            this.tbxVida1 = new System.Windows.Forms.TextBox();
            this.tbxVida2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1029, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vida";
            // 
            // btnAtaque1
            // 
            this.btnAtaque1.Location = new System.Drawing.Point(376, 528);
            this.btnAtaque1.Name = "btnAtaque1";
            this.btnAtaque1.Size = new System.Drawing.Size(73, 35);
            this.btnAtaque1.TabIndex = 2;
            this.btnAtaque1.Text = "Ataque";
            this.btnAtaque1.UseVisualStyleBackColor = true;
            this.btnAtaque1.Click += new System.EventHandler(this.btnAtaque1_Click);
            // 
            // btnDefesa1
            // 
            this.btnDefesa1.Location = new System.Drawing.Point(376, 569);
            this.btnDefesa1.Name = "btnDefesa1";
            this.btnDefesa1.Size = new System.Drawing.Size(73, 35);
            this.btnDefesa1.TabIndex = 3;
            this.btnDefesa1.Text = "Defesa";
            this.btnDefesa1.UseVisualStyleBackColor = true;
            this.btnDefesa1.Click += new System.EventHandler(this.btnDefesa1_Click);
            // 
            // btnDefesa2
            // 
            this.btnDefesa2.Enabled = false;
            this.btnDefesa2.Location = new System.Drawing.Point(904, 569);
            this.btnDefesa2.Name = "btnDefesa2";
            this.btnDefesa2.Size = new System.Drawing.Size(73, 35);
            this.btnDefesa2.TabIndex = 4;
            this.btnDefesa2.Text = "Defesa";
            this.btnDefesa2.UseVisualStyleBackColor = true;
            this.btnDefesa2.Click += new System.EventHandler(this.btnDefesa2_Click);
            // 
            // btnAtaque2
            // 
            this.btnAtaque2.Enabled = false;
            this.btnAtaque2.Location = new System.Drawing.Point(904, 528);
            this.btnAtaque2.Name = "btnAtaque2";
            this.btnAtaque2.Size = new System.Drawing.Size(73, 35);
            this.btnAtaque2.TabIndex = 5;
            this.btnAtaque2.Text = "Ataque";
            this.btnAtaque2.UseVisualStyleBackColor = true;
            this.btnAtaque2.Click += new System.EventHandler(this.btnAtaque2_Click);
            // 
            // tbxVida1
            // 
            this.tbxVida1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tbxVida1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxVida1.Location = new System.Drawing.Point(236, 126);
            this.tbxVida1.Name = "tbxVida1";
            this.tbxVida1.ReadOnly = true;
            this.tbxVida1.Size = new System.Drawing.Size(52, 28);
            this.tbxVida1.TabIndex = 6;
            this.tbxVida1.Text = "100";
            // 
            // tbxVida2
            // 
            this.tbxVida2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tbxVida2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxVida2.Location = new System.Drawing.Point(1082, 120);
            this.tbxVida2.Name = "tbxVida2";
            this.tbxVida2.ReadOnly = true;
            this.tbxVida2.Size = new System.Drawing.Size(63, 28);
            this.tbxVida2.TabIndex = 7;
            this.tbxVida2.Text = "100";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::combate.Properties.Resources.ox8knxvn5gsb11;
            this.pictureBox2.Location = new System.Drawing.Point(983, 234);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(396, 483);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1477, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 467);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::combate.Properties.Resources.dfko79t_2dbf1b70_748d_48d1_8477_d00d756f192d1;
            this.pictureBox3.Location = new System.Drawing.Point(26, 234);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(344, 525);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(141, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "scorpion ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1117, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "kitana";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImage = global::combate.Properties.Resources.EVqrVJiUMAEMzMn;
            this.ClientSize = new System.Drawing.Size(1531, 762);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbxVida2);
            this.Controls.Add(this.tbxVida1);
            this.Controls.Add(this.btnAtaque2);
            this.Controls.Add(this.btnDefesa2);
            this.Controls.Add(this.btnDefesa1);
            this.Controls.Add(this.btnAtaque1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAtaque1;
        private System.Windows.Forms.Button btnDefesa1;
        private System.Windows.Forms.Button btnDefesa2;
        private System.Windows.Forms.Button btnAtaque2;
        private System.Windows.Forms.TextBox tbxVida1;
        private System.Windows.Forms.TextBox tbxVida2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

