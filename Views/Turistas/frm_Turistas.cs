using Agencia_de_Viajes.Controllers;
using Agencia_de_Viajes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia_de_Viajes.Views.Turistas
{
    public partial class frm_Turistas : Form
    {
        private TuristasController turistasController;
        private int selectedTuristaId;

        public frm_Turistas()
        {
            InitializeComponent();
            turistasController = new TuristasController();
            CargarComboboxes();
            CargarTuristas(); 
        }

        private void CargarComboboxes()
        {
            
            cmb_viajes.DataSource = turistasController.ObtenerViajes();
            cmb_viajes.DisplayMember = "NombreDestino";
            cmb_viajes.ValueMember = "ID_Viaje";
        }

        private void CargarTuristas()
        {
            DataTable dt = turistasController.ObtenerTuristas();
            lst_turistas.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                lst_turistas.Items.Add($"{row["ID_Turista"]} - {row["Nombre"]} - {row["ID_Viaje"]}");
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_nombre.Text) && cmb_viajes.SelectedValue != null)
            {
                string nombre = txt_nombre.Text;
                int idViaje = Convert.ToInt32(cmb_viajes.SelectedValue);

                turistasController.AgregarTurista(nombre, idViaje);
                MessageBox.Show("Turista agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTuristas(); 
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (selectedTuristaId != 0 && !string.IsNullOrWhiteSpace(txt_nombre.Text) && cmb_viajes.SelectedValue != null)
            {
                string nombre = txt_nombre.Text;
                int idViaje = Convert.ToInt32(cmb_viajes.SelectedValue);

                turistasController.ActualizarTurista(selectedTuristaId, nombre, idViaje);
                MessageBox.Show("Turista actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTuristas(); 
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un turista y complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (selectedTuristaId != 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este turista?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    turistasController.EliminarTurista(selectedTuristaId);
                    MessageBox.Show("Turista eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTuristas(); 
                    LimpiarFormulario();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un turista para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lst_turistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_turistas.SelectedItem != null)
            {
                string selectedItem = lst_turistas.SelectedItem.ToString();
                string[] partes = selectedItem.Split(new[] { " - " }, StringSplitOptions.None);
                if (partes.Length > 0)
                {
                    selectedTuristaId = Convert.ToInt32(partes[0]);

                    DataRow turista = turistasController.ObtenerTuristaPorId(selectedTuristaId); 
                    if (turista != null)
                    {
                        txt_nombre.Text = turista["Nombre"].ToString();
                        cmb_viajes.SelectedValue = turista["ID_Viaje"];
                    }
                }
            }
        }

        private void LimpiarFormulario()
        {
            txt_nombre.Clear();
            cmb_viajes.SelectedIndex = -1;
            lst_turistas.ClearSelected();
            selectedTuristaId = 0;
        }
    }
}
