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
    public partial class F_MenuInicial : Form
    {
        double saldo = 100.00;
       
       
        public F_MenuInicial()
        {
            InitializeComponent();
            
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            F_Depositar janelaDepositar = new F_Depositar(saldo);
            
            if (janelaDepositar.ShowDialog() == DialogResult.OK)
            {

                this.saldo = janelaDepositar.saldo;
                lblSaldo.Text = saldo.ToString("C");
            }

        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            F_Saque janelaSaque = new F_Saque(saldo);
           if (janelaSaque.ShowDialog() == DialogResult.OK)
            {
                this.saldo = janelaSaque.saldo;
                if (chxExibir.Checked)
                {
                    lblSaldo.Text = saldo.ToString("C");
                }

                else
                {
                    lblSaldo.Text = "R$ *****";
                }
            }

           
        }



        private void F_MenuInicial_Load(object sender, EventArgs e)
        {
            lblSaldo.Text = saldo.ToString("C");
        }

        private void chxExibir_CheckedChanged(object sender, EventArgs e)
        {
            if (chxExibir.Checked)
            {
                lblSaldo.Text = saldo.ToString("C");
            }
            else
            {
                lblSaldo.Text = "R$******";
            }
        }
    }
}
