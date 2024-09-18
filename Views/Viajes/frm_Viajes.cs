using Agencia_de_Viajes.Controllers;
using Agencia_de_Viajes.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace Agencia_de_Viajes.Views.Viajes
{
    public partial class frm_Viajes : Form
    {
        private ViajesController viajesController;
        private DestinoController destinoController;
        private GuiasController guiaController;
        private int selectedViajeId;

        public frm_Viajes()
        {
            InitializeComponent();
            viajesController = new ViajesController();
            destinoController = new DestinoController();
            guiaController = new GuiasController();
            CargarComboboxes();
            CargarViajes(); 
        }

        private void CargarComboboxes()
        {
            
            cmb_destinos.DataSource = destinoController.ObtenerDestinos();
            cmb_destinos.DisplayMember = "Nombre";
            cmb_destinos.ValueMember = "ID_Destino";

            
            cmb_guias.DataSource = guiaController.ObtenerGuias();
            cmb_guias.DisplayMember = "Nombre";
            cmb_guias.ValueMember = "ID_Guía";


            CargarViajesEnListBox();
        }

        private void CargarViajesEnListBox()
        {
            DataTable dt = viajesController.ObtenerViajes();
            lst_viajes.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {

                string idViaje = row["ID_Viaje"].ToString();
                string nombreDestino = row["ID_Destino"].ToString();
                string nombreGuia = row["ID_Guía"].ToString();
                string fecha = Convert.ToDateTime(row["Fecha"]).ToString("d"); 

                lst_viajes.Items.Add($"{idViaje} - {nombreDestino} - {nombreGuia} ({fecha})");
            }
        }

        private void CargarViajes()
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (cmb_destinos.SelectedValue != null && cmb_guias.SelectedValue != null)
            {
                int idDestino = Convert.ToInt32(cmb_destinos.SelectedValue);
                int idGuia = Convert.ToInt32(cmb_guias.SelectedValue);
                DateTime fecha = dtp_fecha.Value;

                viajesController.AgregarViaje(idDestino, idGuia, fecha);
                MessageBox.Show("Viaje agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarViajes(); 
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (selectedViajeId != 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este viaje?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    viajesController.EliminarViaje(selectedViajeId);
                    MessageBox.Show("Viaje eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarViajes(); 
                    LimpiarFormulario();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un viaje para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lst_viajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_viajes.SelectedItem != null)
            {
                
                string selectedItem = lst_viajes.SelectedItem.ToString();
                string[] partes = selectedItem.Split(new[] { " - " }, StringSplitOptions.None);
                if (partes.Length > 0)
                {
                    selectedViajeId = Convert.ToInt32(partes[0]);

                    Viaje viaje = viajesController.ObtenerViajePorId(selectedViajeId);
                    if (viaje != null)
                    {
                        cmb_destinos.SelectedValue = viaje.ID_Destino;
                        cmb_guias.SelectedValue = viaje.ID_Guía;
                        dtp_fecha.Value = viaje.Fecha;
                    }
                }
            }
        }

        private void LimpiarFormulario()
        {
            cmb_destinos.SelectedIndex = -1;
            cmb_guias.SelectedIndex = -1;
            dtp_fecha.Value = DateTime.Now;
            lst_viajes.ClearSelected();
            selectedViajeId = 0;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_actualiza_Click(object sender, EventArgs e)
        {
            CargarViajesEnListBox(); 
            MessageBox.Show("Lista de viajes actualizada correctamente", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}