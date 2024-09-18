using Agencia_de_Viajes.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia_de_Viajes.Views.Guias
{
    public partial class frm_Guias : Form
    {
        private GuiasController guiasController;
        private int selectedGuiaId; 

        public frm_Guias()
        {
            InitializeComponent();
            guiasController = new GuiasController();
            CargarGuias(); 
        }

        
        private void CargarGuias()
        {
            lst_guias.Items.Clear(); 
            DataTable guias = guiasController.ObtenerGuias();

            foreach (DataRow row in guias.Rows)
            {
                lst_guias.Items.Add($"{row["ID_Guía"]} - {row["Nombre"]}");
            }
        }

        private void lst_guias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_guias.SelectedIndex != -1)
            {
                
                string selectedText = lst_guias.SelectedItem.ToString();
                selectedGuiaId = int.Parse(selectedText.Split('-')[0].Trim());

                
                txt_nombre.Text = selectedText.Split('-')[1].Trim();
            }
        }

        
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_nombre.Text))
            {
                guiasController.AgregarGuia(txt_nombre.Text);
                MessageBox.Show("Guía agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGuias(); 
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (selectedGuiaId != 0 && !string.IsNullOrEmpty(txt_nombre.Text))
            {
                guiasController.ActualizarGuia(selectedGuiaId, txt_nombre.Text);
                MessageBox.Show("Guía actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGuias(); 
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un guía y ingrese un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (selectedGuiaId != 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este guía?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    guiasController.EliminarGuia(selectedGuiaId);
                    MessageBox.Show("Guía eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGuias(); 
                    LimpiarFormulario();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un guía para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void LimpiarFormulario()
        {
            txt_nombre.Clear();
            lst_guias.ClearSelected();
            selectedGuiaId = 0;
        }
    }
}
