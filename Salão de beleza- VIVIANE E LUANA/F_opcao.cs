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
    public partial class F_opcao : Form
    {
        public F_opcao()
        {
            InitializeComponent();
        }

        private void bntConcluido_Click(object sender, EventArgs e)
        {
            string conluído = bntConcluido.Text;
            F_confirmar janelaConfirmar = new F_confirmar();

            this.Visible = false;
            if (janelaConfirmar.ShowDialog() != DialogResult.OK)
            {
                Close();
            }
        }

        private void btnopcao1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
