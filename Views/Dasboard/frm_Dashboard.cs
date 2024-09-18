using Agencia_de_Viajes.Views.Destino;
using Agencia_de_Viajes.Views.Guias;
using Agencia_de_Viajes.Views.Turistas;
using Agencia_de_Viajes.Views.Viajes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia_de_Viajes.Views.Dasboard
{
    public partial class frm_Dashboard : Form
    {
        public frm_Dashboard()
        {
            InitializeComponent();
        }

        private void destinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Destinos _Destinos = new frm_Destinos();
            _Destinos.ShowDialog();
        }

        private void guíasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Guias _Guias = new frm_Guias();
            _Guias.ShowDialog();
        }

        private void viajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Viajes _Viajes = new frm_Viajes();
            _Viajes.ShowDialog();
        }

        private void turistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Turistas _Turistas = new frm_Turistas();
            _Turistas.ShowDialog();
        }
    }
}
