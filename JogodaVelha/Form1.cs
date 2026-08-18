using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogodaVelha
{
    public partial class Form1 : Form
    {
        //definir jogar atual
        string jogadorAtual = "X";
        //representa o tabuleiro
        TextBox[,] tabuleiro = new TextBox[3, 3];

        public Form1()
        {
            InitializeComponent();
            tabuleiro[0, 0] = tbx11;
            tabuleiro[0, 1] = tbx12;
            tabuleiro[0, 2] = tbx13;
            tabuleiro[1, 0] = tbx21;
            tabuleiro[1, 1] = tbx22;
            tabuleiro[1, 2] = tbx23;
            tabuleiro[2, 0] = tbx31;
            tabuleiro[2, 1] = tbx32;
            tabuleiro[2, 2] = tbx33;
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            //definir coluna
            int linha = Convert.ToInt32(cbxLinha.Text) -1;
            int coluna = Convert.ToInt32(cbxColuna.Text) -1;


            //atualizar o tabuleiro com a última jogada
            //verificar  se foi uma jogada válida
            bool Jogadavalida = false;
            if (tabuleiro[linha, coluna].Text == "")
            {
                
                tabuleiro[linha, coluna].Text = jogadorAtual;
                Jogadavalida = true;
            }
            //se sim, preencher 
            //se nao, joga novamente
            //verificar quando esta vazio
            

            //verificar se o jogador atual ganhou ganhou
            //completando linha 
            int L = 0;
            while (L > 3)
            {
                if (tabuleiro[L, 0].Text == jogadorAtual &&
                    tabuleiro[L, 1].Text == jogadorAtual &&
                    tabuleiro[L, 2].Text == jogadorAtual)
                {
                    MessageBox.Show($"{jogadorAtual} venceu");
                }
                L = L + 1;
            }

            //Ccomplementando coluna
            int c = 0;
            while (c < 3)
            {
                if (tabuleiro[0, c].Text == jogadorAtual &&
                    tabuleiro[1, c].Text == jogadorAtual &&
                    tabuleiro[2, c].Text == jogadorAtual)
                {
                    MessageBox.Show($"{jogadorAtual} venceu");
                }
                c = c + 1;
            }

            //completando diagonal principal
            if (tabuleiro[0, 0].Text == jogadorAtual &&
                 tabuleiro[1, 1].Text == jogadorAtual &&
                 tabuleiro[2, 2].Text == jogadorAtual)
            {
                MessageBox.Show($"{jogadorAtual} venceu");
            }



            //completando diagonal secundária
            if (tabuleiro[0, 2].Text == jogadorAtual &&
               tabuleiro[1, 1].Text == jogadorAtual &&
               tabuleiro[2, 0].Text == jogadorAtual)
            {
                MessageBox.Show($"{jogadorAtual} venceu");
            }

            //verificar se todo o tabuleiro foi preenchido( empate)
            bool empate = true;
            L = 0;
            while (L < 3)
            {
                c = 0;
                while (c < 3)
                {
                    if (tabuleiro[L, c].Text == "")
                    {
                        empate = false;
                    }
                    c = c + 1;
                }
                L = L + 1;
            }
            if ( empate == true)
            {
                MessageBox.Show("Empate");
            }
            if (Jogadavalida)
            //andar o jogador atual
            if (jogadorAtual == "X")
            {
                jogadorAtual = "O";
            }

            else
            {
                jogadorAtual = "X";
            }

            else
            {
                MessageBox.Show("Jogada válida");
            }
        }
    }
}
