using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salão_de_beleza__VIVIANE_E_LUANA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntAgendamrnto_Click(object sender, EventArgs e)
        {
            string agendamento = bntAgendamento.Text;
            F_Agendamento2 janelaAgendamento = new F_Agendamento2();

                this.Visible = false;
                if (janelaAgendamento.ShowDialog() != DialogResult.OK)
                {
                    Close();
                }
        }
    }
}
