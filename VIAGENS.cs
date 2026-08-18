using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using viagens.Properties;

namespace viagens
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

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            string clima = cbxClima1.Text;
            double dinheiro = Convert.ToDouble(tbxDinheiro1.Text);



            if (clima == "Quente" && dinheiro < 750)
            {
                lblLocal.Text = "Rio de Janeiro";

                pbxSugestao.Image = Resources.praia_barreiras_min;
            }

            if (clima == "Quente" && dinheiro < 750)
            {
                lblLocal.Text = "";

                pbxSugestao.Image = Resources.praia_barreiras_min;
            }



            if (clima == "Frio" && dinheiro < 750)
            {
                lblLocal.Text = "Santa Catarina";

                pbxSugestao.Image = Resources.f;
            }




            if (clima == "Frio" && dinheiro >= 750)
            {
                lblLocal.Text = "Gramado";

                pbxSugestao.Image = Resources.f;
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
