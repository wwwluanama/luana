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
    public partial class F_Agendamento2 : Form
    {
        public F_Agendamento2()
        {
            InitializeComponent();
        }

        private void bntprossiga_Click(object sender, EventArgs e)
        {
            string prossiga = bntprossiga.Text;
            F_opcao janelaAgendamento2 = new F_opcao();

            this.Visible = false;
            if (janelaAgendamento2.ShowDialog() != DialogResult.OK)
            {
                Close();
            }
        }
    }
}
