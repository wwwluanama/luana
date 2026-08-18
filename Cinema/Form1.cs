using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn3comprar_Click(object sender, EventArgs e)
        {
            string filme = cbx1filme.Text;
            int quantidade = Convert.ToInt32(tbx2quant.Text);

            double valorTotal = 0;

            if (rbInteira.Checked)
            {
                valorTotal = quantidade * 38;
            }

            else
            {
                valorTotal = quantidade * 15;

            }

            if (chxcombo1.Checked)
            {
                valorTotal = valorTotal + 29;
            }

            if (chxcombo2.Checked)
            {
                valorTotal = valorTotal + 25;
            }

            MessageBox.Show($" Filme: {filme} \n Total a pagar: {valorTotal}",
                "Cinema");
        }
    }
}
