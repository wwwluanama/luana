namespace ProjetoBiblioteca
{
    partial class F_BibliotecarioMenu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msAlunos = new System.Windows.Forms.ToolStripMenuItem();
            this.msLivros = new System.Windows.Forms.ToolStripMenuItem();
            this.msLivrosPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.msAgendamento = new System.Windows.Forms.ToolStripMenuItem();
            this.msLivrosCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.msLivrosExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.msEmprestimos = new System.Windows.Forms.ToolStripMenuItem();
            this.msEmprestimosCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.msEmprestimosPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.msEmprestimosEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.msDevoluções = new System.Windows.Forms.ToolStripMenuItem();
            this.msDevoluçõesCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.msDevoluçõesPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.msDevoluçõesEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.msAlunosCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.msAlunosPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.msAlunosEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.msBibliotecario = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvAgendamentos = new System.Windows.Forms.DataGridView();
            this.dgvEmprestimos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmprestimos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLivros = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAluno = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msAlunos,
            this.msLivros,
            this.msAgendamento,
            this.msEmprestimos,
            this.msDevoluções});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1023, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msAlunos
            // 
            this.msAlunos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msAlunosCadastrar,
            this.msAlunosPesquisar,
            this.msAlunosEditar});
            this.msAlunos.Name = "msAlunos";
            this.msAlunos.Size = new System.Drawing.Size(56, 20);
            this.msAlunos.Text = "Alunos";
            // 
            // msLivros
            // 
            this.msLivros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msLivrosPesquisar,
            this.msLivrosCadastrar,
            this.msLivrosExcluir});
            this.msLivros.Name = "msLivros";
            this.msLivros.Size = new System.Drawing.Size(50, 20);
            this.msLivros.Text = "Livros";
            // 
            // msLivrosPesquisar
            // 
            this.msLivrosPesquisar.Name = "msLivrosPesquisar";
            this.msLivrosPesquisar.Size = new System.Drawing.Size(180, 22);
            this.msLivrosPesquisar.Text = "Pesquisar";
            // 
            // msAgendamento
            // 
            this.msAgendamento.Name = "msAgendamento";
            this.msAgendamento.Size = new System.Drawing.Size(95, 20);
            this.msAgendamento.Text = "Agendamento";
            // 
            // msLivrosCadastrar
            // 
            this.msLivrosCadastrar.Name = "msLivrosCadastrar";
            this.msLivrosCadastrar.Size = new System.Drawing.Size(180, 22);
            this.msLivrosCadastrar.Text = "Cadastrar";
            // 
            // msLivrosExcluir
            // 
            this.msLivrosExcluir.Name = "msLivrosExcluir";
            this.msLivrosExcluir.Size = new System.Drawing.Size(180, 22);
            this.msLivrosExcluir.Text = "Excluir/Deletar";
            // 
            // msEmprestimos
            // 
            this.msEmprestimos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msEmprestimosCadastrar,
            this.msEmprestimosPesquisar,
            this.msEmprestimosEditar});
            this.msEmprestimos.Name = "msEmprestimos";
            this.msEmprestimos.Size = new System.Drawing.Size(88, 20);
            this.msEmprestimos.Text = "Empréstimos";
            // 
            // msEmprestimosCadastrar
            // 
            this.msEmprestimosCadastrar.Name = "msEmprestimosCadastrar";
            this.msEmprestimosCadastrar.Size = new System.Drawing.Size(180, 22);
            this.msEmprestimosCadastrar.Text = "Cadastrar";
            // 
            // msEmprestimosPesquisar
            // 
            this.msEmprestimosPesquisar.Name = "msEmprestimosPesquisar";
            this.msEmprestimosPesquisar.Size = new System.Drawing.Size(180, 22);
            this.msEmprestimosPesquisar.Text = "Pesquisar";
            // 
            // msEmprestimosEditar
            // 
            this.msEmprestimosEditar.Name = "msEmprestimosEditar";
            this.msEmprestimosEditar.Size = new System.Drawing.Size(180, 22);
            this.msEmprestimosEditar.Text = "Editar";
            // 
            // msDevoluções
            // 
            this.msDevoluções.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msDevoluçõesCadastrar,
            this.msDevoluçõesPesquisar,
            this.msDevoluçõesEditar});
            this.msDevoluções.Name = "msDevoluções";
            this.msDevoluções.Size = new System.Drawing.Size(80, 20);
            this.msDevoluções.Text = "Devoluções";
            // 
            // msDevoluçõesCadastrar
            // 
            this.msDevoluçõesCadastrar.Name = "msDevoluçõesCadastrar";
            this.msDevoluçõesCadastrar.Size = new System.Drawing.Size(180, 22);
            this.msDevoluçõesCadastrar.Text = "Cadastrar";
            // 
            // msDevoluçõesPesquisar
            // 
            this.msDevoluçõesPesquisar.Name = "msDevoluçõesPesquisar";
            this.msDevoluçõesPesquisar.Size = new System.Drawing.Size(180, 22);
            this.msDevoluçõesPesquisar.Text = "Pesquisar";
            // 
            // msDevoluçõesEditar
            // 
            this.msDevoluçõesEditar.Name = "msDevoluçõesEditar";
            this.msDevoluçõesEditar.Size = new System.Drawing.Size(180, 22);
            this.msDevoluçõesEditar.Text = "Editar";
            // 
            // msAlunosCadastrar
            // 
            this.msAlunosCadastrar.Name = "msAlunosCadastrar";
            this.msAlunosCadastrar.Size = new System.Drawing.Size(180, 22);
            this.msAlunosCadastrar.Text = "Cadastrar";
            // 
            // msAlunosPesquisar
            // 
            this.msAlunosPesquisar.Name = "msAlunosPesquisar";
            this.msAlunosPesquisar.Size = new System.Drawing.Size(180, 22);
            this.msAlunosPesquisar.Text = "Pesquisar";
            // 
            // msAlunosEditar
            // 
            this.msAlunosEditar.Name = "msAlunosEditar";
            this.msAlunosEditar.Size = new System.Drawing.Size(180, 22);
            this.msAlunosEditar.Text = "Editar/Deletar";
            // 
            // msBibliotecario
            // 
            this.msBibliotecario.Name = "msBibliotecario";
            this.msBibliotecario.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvAgendamentos
            // 
            this.dgvAgendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendamentos.Location = new System.Drawing.Point(21, 113);
            this.dgvAgendamentos.Name = "dgvAgendamentos";
            this.dgvAgendamentos.Size = new System.Drawing.Size(310, 168);
            this.dgvAgendamentos.TabIndex = 2;
            // 
            // dgvEmprestimos
            // 
            this.dgvEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestimos.Location = new System.Drawing.Point(21, 322);
            this.dgvEmprestimos.Name = "dgvEmprestimos";
            this.dgvEmprestimos.Size = new System.Drawing.Size(310, 182);
            this.dgvEmprestimos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Agendamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Empréstimos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEmprestimos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblLivros);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblAluno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(656, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 434);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estatística";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alunos";
            // 
            // lblEmprestimos
            // 
            this.lblEmprestimos.AutoSize = true;
            this.lblEmprestimos.Location = new System.Drawing.Point(105, 207);
            this.lblEmprestimos.Name = "lblEmprestimos";
            this.lblEmprestimos.Size = new System.Drawing.Size(13, 13);
            this.lblEmprestimos.TabIndex = 8;
            this.lblEmprestimos.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Empréstimos";
            // 
            // lblLivros
            // 
            this.lblLivros.AutoSize = true;
            this.lblLivros.Location = new System.Drawing.Point(105, 133);
            this.lblLivros.Name = "lblLivros";
            this.lblLivros.Size = new System.Drawing.Size(13, 13);
            this.lblLivros.TabIndex = 10;
            this.lblLivros.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Livros";
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(105, 63);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(13, 13);
            this.lblAluno.TabIndex = 12;
            this.lblAluno.Text = "0";
            // 
            // F_BibliotecarioMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1023, 584);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmprestimos);
            this.Controls.Add(this.dgvAgendamentos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_BibliotecarioMenu";
            this.Text = "F_BibliotecarioMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msAlunos;
        private System.Windows.Forms.ToolStripMenuItem msLivros;
        private System.Windows.Forms.ToolStripMenuItem msLivrosPesquisar;
        private System.Windows.Forms.ToolStripMenuItem msLivrosCadastrar;
        private System.Windows.Forms.ToolStripMenuItem msLivrosExcluir;
        private System.Windows.Forms.ToolStripMenuItem msAgendamento;
        private System.Windows.Forms.ToolStripMenuItem msAlunosCadastrar;
        private System.Windows.Forms.ToolStripMenuItem msAlunosPesquisar;
        private System.Windows.Forms.ToolStripMenuItem msEmprestimos;
        private System.Windows.Forms.ToolStripMenuItem msEmprestimosCadastrar;
        private System.Windows.Forms.ToolStripMenuItem msEmprestimosPesquisar;
        private System.Windows.Forms.ToolStripMenuItem msEmprestimosEditar;
        private System.Windows.Forms.ToolStripMenuItem msDevoluções;
        private System.Windows.Forms.ToolStripMenuItem msDevoluçõesCadastrar;
        private System.Windows.Forms.ToolStripMenuItem msDevoluçõesPesquisar;
        private System.Windows.Forms.ToolStripMenuItem msDevoluçõesEditar;
        private System.Windows.Forms.ToolStripMenuItem msAlunosEditar;
        private System.Windows.Forms.ContextMenuStrip msBibliotecario;
        private System.Windows.Forms.DataGridView dgvAgendamentos;
        private System.Windows.Forms.DataGridView dgvEmprestimos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEmprestimos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLivros;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Label label3;
    }
}