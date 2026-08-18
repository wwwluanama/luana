using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class f_Login : Form
    {
        public f_Login()
        {
            InitializeComponent();
        }

        private void f_Login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bntEntrar_Click(object sender, EventArgs e)
        {
            string usario = tbxUsuario.Text;
            string senha = tbxSenha.Text;

            if (usario == "viviformatura" && senha == "1234")
            {
                F_MenuInicial janelaMenu = new F_MenuInicial();
              
                this.Visible = false;
                if (janelaMenu.ShowDialog() != DialogResult.OK)
                {
                    Close();
                }
            }

            else
            {
                MessageBox.Show("Usuário ou senha estão incorretos \n" +
                    "a partir de 3 tentativas sua conta ficara suspensa");
            }

        }

        private void tbxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
