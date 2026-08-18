using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadaDeVelocidade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            int limite = 80;
            int velocidade = Convert.ToInt32(tbxvelocidade.Text);

            //se ultrapassou o limite
            if (velocidade > limite)
            {

                lblStatus.Text = "Status: ULTRAPASSOU O LIMITE.";
                lblStatus.ForeColor = Color.Red;
                //se velocidade <= limite * 1.2
                if (velocidade <= limite * 1.2)
                {
                    lblStatus.Text = lblStatus.Text + "Multa: R$136,16 e 4 ponto";
                }
                else
                {
                    if (velocidade <= limite * 1.5)
                    {
                        lblStatus.Text = lblStatus.Text + "Multa: R$195,23 e 5 ponto";
                    }
                    else
                    {
                        lblStatus.Text = lblStatus.Text + "Multa: R$880,41 e 7 pontos";
                    }
                }

            }
            else

            {

             
                lblStatus.Text = "Status: DENTRO DO LIMITE DE VELOCIDADE ";
                lblStatus.ForeColor = Color.Green;
            }
        }
    }
}
