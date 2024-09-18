using Agencia_de_Viajes.Controllers;
using Agencia_de_Viajes.Reporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia_de_Viajes.Views.Destino
{
    public partial class frm_Destinos : Form
    {
        private DestinoController controller = new DestinoController(); 
        private int destinoSeleccionadoID = -1; 

        public frm_Destinos()
        {
            InitializeComponent();
            CargarDestinos(); 
        }

        private void CargarDestinos()
        {
            lst_destinos.Items.Clear(); 
            DataTable dt = controller.ObtenerDestinos(); 

            foreach (DataRow row in dt.Rows)
            {
                lst_destinos.Items.Add($"{row["ID_Destino"]} - {row["Nombre"]} ({row["País"]})");
            }
        }

        private void lst_destinos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_destinos.SelectedIndex != -1)
            {
                
                string selectedItem = lst_destinos.SelectedItem.ToString();
                destinoSeleccionadoID = Convert.ToInt32(selectedItem.Split('-')[0].Trim());

            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string pais = txt_pais.Text;

            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(pais))
            {
                try
                {
                    controller.AgregarDestino(nombre, pais);
                    MessageBox.Show("Destino agregado exitosamente");
                    CargarDestinos(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar el destino: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los campos");
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (destinoSeleccionadoID != -1)
            {
                string nombre = txt_nombre.Text;
                string pais = txt_pais.Text;

                if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(pais))
                {
                    try
                    {
                        controller.ActualizarDestino(destinoSeleccionadoID, nombre, pais);
                        MessageBox.Show("Destino actualizado exitosamente");
                        CargarDestinos(); 
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al actualizar el destino: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar todos los campos");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un destino para actualizar");
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            frm_reporte _Reporte = new frm_reporte();
            _Reporte.ShowDialog();
        }
    }
}