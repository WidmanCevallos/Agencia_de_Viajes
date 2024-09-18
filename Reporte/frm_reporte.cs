using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia_de_Viajes.Reporte
{
    public partial class frm_reporte : Form
    {
        public frm_reporte()
        {
            InitializeComponent();
        }

        private void frm_reporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ds2.Destinos' Puede moverla o quitarla según sea necesario.
            this.destinosTableAdapter1.Fill(this.ds2.Destinos);
            // TODO: esta línea de código carga datos en la tabla 'ds1.Destinos' Puede moverla o quitarla según sea necesario.
            //this.destinosTableAdapter.Fill(this.ds2.Destinos);

            this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
            //this.reportViewer3.RefreshReport();
            //this.reportViewer2.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
