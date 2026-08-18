using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuantidadeDeJogos__ATIVIDADE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnverficar_Click(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt32(tbxqtd.Text);

            int qtd = 0;
            int i = 0;

            Random n = new Random();

            
            while ( i < quantidade)
            {

                int resultado = n.Next(1,3);
                if (resultado == 1)
                {
                    qtd = qtd + 5;
                    MessageBox.Show($"Vitória.");
                }
                i = i + 1;
            }
            MessageBox.Show($"quantidade: {qtd}");
        }
    }
}
