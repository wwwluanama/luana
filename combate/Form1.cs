using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combate
{
    public partial class Form1 : Form
    {
        int defesa1 = 0;
        int defesa2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAtaque1_Click(object sender, EventArgs e)
        {
            //diminuir os pontos do jogador 2
            // dano = atque1 - defesa2
            int dano = 15 - defesa2;

            //vida2 = vida2 - dano
            int vida2 = Convert.ToInt32(tbxVida1.Text);
            tbxVida2.Text = (vida2 - dano).ToString();

            //bloquear os botões do jogador 1
            btnAtaque1.Enabled = false;
            btnDefesa1.Enabled = false;

            //desbloquear os botões do jogador 2
            btnAtaque2.Enabled = true;
            btnDefesa2.Enabled = true;

            //defesa do jogador 2 volta ao padrão
            defesa2 = 0;

        }


        private void btnAtaque2_Click(object sender, EventArgs e)
        {
            //diminuir os pontos do jogador 2
            // dano = atque1 - defesa2
            int dano = 17 - defesa1;

            //vida2 = vida2 - dano
            int vida1 = Convert.ToInt32(tbxVida1.Text);
            tbxVida1.Text = (vida1 - dano).ToString();

            //bloquear os botões do jogador 1
            btnAtaque1.Enabled = true;
            btnDefesa1.Enabled = true;

            //desbloquear os botões do jogador 2
            btnAtaque2.Enabled = false;
            btnDefesa2.Enabled = false;

            //defesa do jogador 2 volta ao padrão
            defesa1 = 0;
        }



        private void btnDefesa1_Click(object sender, EventArgs e)
        {
            //mudar defesa do jdor 1
            defesa1 = 5;

            //bloquear os botões do jodador 1
            btnAtaque1.Enabled = false;
            btnAtaque1.Enabled = false;

            //bloquear os botões do jodador 2
            btnAtaque2.Enabled = true;
            btnAtaque2.Enabled = true;

            //defesa do jogador 2

            defesa2 = 0;


        }

        private void btnDefesa2_Click(object sender, EventArgs e)
        {
            //mudar defesa do jdor 1
            defesa2 = 5;

            //bloquear os botões do jodador 1
            btnAtaque1.Enabled = true;
            btnAtaque1.Enabled = true;

            //bloquear os botões do jodador 2
            btnAtaque2.Enabled = false;
            btnAtaque2.Enabled = false;

            //defesa do jogador 2

            defesa2 = 0;
        }
    }
}
