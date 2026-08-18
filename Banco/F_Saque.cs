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
    public partial class F_Saque : Form
    { 
        public double saldo { get; set; }
        public F_Saque(double saldo)
        {
            InitializeComponent();
            this.saldo = saldo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(tbxValor.Text);
            if ( saldo>= valor)
            {
                saldo = saldo - valor;
                MessageBox.Show($"Saque: {valor}\nSaldo: {saldo}");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void F_Saque_Load(object sender, EventArgs e)
        {
            lblSaldo.Text = saldo.ToString("C");
        }
    }
}
