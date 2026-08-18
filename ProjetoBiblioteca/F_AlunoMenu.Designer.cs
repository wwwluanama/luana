namespace ProjetoBiblioteca
{
    partial class F_AlunoMenu
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.msPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.msAgendamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.msEmprestimos = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPesquisar = new System.Windows.Forms.TextBox();
            this.bntPesquisar = new System.Windows.Forms.Button();
            this.dgvListaLivros = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msPerfil,
            this.msAgendamentos,
            this.msEmprestimos});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(1197, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // msPerfil
            // 
            this.msPerfil.Font = new System.Drawing.Font("Clarendon BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msPerfil.Name = "msPerfil";
            this.msPerfil.Size = new System.Drawing.Size(51, 20);
            this.msPerfil.Text = "Perfil";
            // 
            // msAgendamentos
            // 
            this.msAgendamentos.Font = new System.Drawing.Font("Clarendon BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msAgendamentos.Name = "msAgendamentos";
            this.msAgendamentos.Size = new System.Drawing.Size(107, 20);
            this.msAgendamentos.Text = "Agendamentos";
            // 
            // msEmprestimos
            // 
            this.msEmprestimos.Font = new System.Drawing.Font("Clarendon BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msEmprestimos.Name = "msEmprestimos";
            this.msEmprestimos.Size = new System.Drawing.Size(98, 20);
            this.msEmprestimos.Text = "Empréstimos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar";
            // 
            // tbxPesquisar
            // 
            this.tbxPesquisar.Location = new System.Drawing.Point(80, 41);
            this.tbxPesquisar.Multiline = true;
            this.tbxPesquisar.Name = "tbxPesquisar";
            this.tbxPesquisar.Size = new System.Drawing.Size(254, 23);
            this.tbxPesquisar.TabIndex = 2;
            // 
            // bntPesquisar
            // 
            this.bntPesquisar.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPesquisar.Location = new System.Drawing.Point(141, 70);
            this.bntPesquisar.Name = "bntPesquisar";
            this.bntPesquisar.Size = new System.Drawing.Size(111, 32);
            this.bntPesquisar.TabIndex = 3;
            this.bntPesquisar.Text = "pesquisar";
            this.bntPesquisar.UseVisualStyleBackColor = true;
            // 
            // dgvListaLivros
            // 
            this.dgvListaLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaLivros.Location = new System.Drawing.Point(726, 41);
            this.dgvListaLivros.Name = "dgvListaLivros";
            this.dgvListaLivros.Size = new System.Drawing.Size(398, 235);
            this.dgvListaLivros.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ProjetoBiblioteca.Properties.Resources._8328200;
            this.pictureBox2.Location = new System.Drawing.Point(0, 489);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // F_AlunoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::ProjetoBiblioteca.Properties.Resources.tipos_de_alunos_thumb_recuperado;
            this.ClientSize = new System.Drawing.Size(1197, 628);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvListaLivros);
            this.Controls.Add(this.bntPesquisar);
            this.Controls.Add(this.tbxPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msMenu);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.msMenu;
            this.Name = "F_AlunoMenu";
            this.Text = "Aluno Menu";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem msPerfil;
        private System.Windows.Forms.ToolStripMenuItem msAgendamentos;
        private System.Windows.Forms.ToolStripMenuItem msEmprestimos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPesquisar;
        private System.Windows.Forms.Button bntPesquisar;
        private System.Windows.Forms.DataGridView dgvListaLivros;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}