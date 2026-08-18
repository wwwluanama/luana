using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Detetive
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

        private void btnAnalisar_Click(object sender, EventArgs e)

        {
            string r1 = cbx1.Text;
            string r2 = cbx2.Text;
            string r3 = cbx3.Text;
            string r4 = cbx4.Text;
            string r5 = cbx5.Text;

            int cont = 0;

            if (cbx1.Text == "sim") cont++;
            if (cbx2.Text == "sim") cont++;
            if (cbx3.Text == "sim") cont++;
            if (cbx4.Text == "sim") cont++;
            if (cbx5.Text == "sim") cont++;


            if ( cont <= 1 )
            {
                lblResultado.Text = "Inocente";
            }

            else if (cont<=2 )
            {
                lblResultado.Text = "Suspeito";
            }

            else if (cont <= 4)
            {
                lblResultado.Text = "Cúmplice";
            }

            else
            {
                lblResultado.Text = "Assasino.";
            }




        }
    }
}
