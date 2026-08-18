using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBiblioteca
{
    public partial class F_Inicio : Form
    {
        public F_Inicio()
        {
            InitializeComponent();
        }

        private void llSESI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://escolasesi.ap.sesi.org.br/biblioteca/",
                    UseShellExecute = true,
                });

        }

        private void bntprosseguir_Click_1(object sender, EventArgs e)
        {
            string usario = tbxUsuario.Text;
            string senha = tbxSenha.Text;
            string tipo = cbxTipo.Text;

            if (tipo == "Aluno")
            {
                if (usario == "Aluno sesi" && senha == "Sesi@2026")
                {
                    F_AlunoMenu janelaAlunoMenu = new F_AlunoMenu();
                    this.Visible = false;
                    if (janelaAlunoMenu.ShowDialog() != DialogResult.OK)
                    {
                        Close();
                    }

                }
                else
                {
                    MessageBox.Show("Usuário ou senha estão incorretos.",
                        "Login Aluno",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }

            }
           else if (tipo == "Bibliotecário")
            {
                if (usario == "Bibliotecário" && senha == "1234")
                {
                    F_BibliotecarioMenu janelaBibliotecarioMenu = new F_BibliotecarioMenu();
                    this.Visible = false;
                    if (janelaBibliotecarioMenu.ShowDialog() != DialogResult.OK)
                    {
                        Close();
                    }

                }
                else
                {
                    MessageBox.Show("Usuário ou senha estão incorretos.",
                        "Login Bibliotecário",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Escolha um tipo de usuário.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }

        }
    }
}
