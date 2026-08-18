using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnBotão_Click(object sender, EventArgs e)
        {
            string usario = tbxUsuario.Text;
            string senha = tbxSenha.Text;



            if (usario == "vivi" && senha == "viviformatura")
            {
                F_inicio janela = new F_inicio();
                janela.Show();
                
                MessageBox.Show("Usuário e senha corretos!", "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


            }


            else
            {
                MessageBox.Show("senha incorreta.", "Login",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            tbxUsuario.Text = "";
            tbxSenha.Text = "";

        }

        private void chxExporsenha_CheckedChanged(object sender, EventArgs e)
        {

            if (chxExporsenha.Checked)
            {
                tbxSenha.PasswordChar = default;
            }
            else
            {
                tbxSenha.PasswordChar = '*';
            }
        }

        private void tbxUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
