using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxTeste1_CheckedChanged(object sender, EventArgs e)
        {
            Teste1 janela = new Teste1();
            janela.Show();
        }


        private void tbxTeste2_CheckedChanged_1(object sender, EventArgs e)
        {
            Teste2 janela = new Teste2();
            janela.Show();
        }
    }
}
