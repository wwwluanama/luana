using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class F_Depositar : Form
    {
         public double saldo { get; set; }
        //construtor
        public F_Depositar(double saldo)
        {
            InitializeComponent();
            this.saldo = saldo;
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(tbxValor.Text);
            if (valor > 0)
            {
                this.saldo = this.saldo + valor;
                MessageBox.Show($"Depósito: {valor}\nSaldo: {saldo}");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Digite um valor maior que 0.");
            }
        }
    }
}
