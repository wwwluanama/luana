using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace votoWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxCandidato1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntvotacao_Click(object sender, EventArgs e)
        {
            //ARMAZENAR OS NOMES DOS CANDITADOS
            string candidato1 = tbxCandidato1.Text;
            string candidato2 = tbxCandidato2.Text;


            //INICIALIZAR 2 CONTADORES
            int cont1 = 0;
            int cont2 = 0;


            //INICIALIZAR A VARIÁVEL AUXILIAR (1)
            int i = 0;
            Random n = new Random();

            // ENQUANTO 1 < 100
            while (i < 100)
            {
                //GERAR NUMERO ALEATORIO ( 1 OU 2 )
                int num = n.Next(1, 3);
                

                //VERIFICAR PARA QUEM É O VOTO
                if (num == 1)
                {
                    //ACRESCENTAR NO CONTADOR ADEQUADO
                    cont1 = cont1 + 1;

                }
                else
                {
                    cont2 = cont2 + 1;
                }

                //INCREMENTAR A VARIÁVEL 1
                i = i + 1;

            }
            //VERIFICAR QUEM GANHOU OU EMPATOU
            //Candidato 1 
            if (cont1 > cont2)
            {
                MessageBox.Show($"Candidato 1 eleito.");

            }

            //Candidato 2
            if (cont2 > cont1)
            {
                MessageBox.Show($"Candidato 2 eleito.");

            }
            //se empatou
            if (cont1 == cont2)
            {
                MessageBox.Show($"ambos ficaram empatados.");
            }


    }
}
}
