using Agencia_de_Viajes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_de_Viajes.Controllers
{
    public class GuiasController
    {
        private GuiasModel model = new GuiasModel();

        public DataTable ObtenerGuias()
        {
            return model.ObtenerGuias();
        }

        public void AgregarGuia(string nombre)
        {
            model.AgregarGuia(nombre);
        }

        public void ActualizarGuia(int idGuia, string nombre)
        {
            model.ActualizarGuia(idGuia, nombre);
        }

        public void EliminarGuia(int idGuia)
        {
            model.EliminarGuia(idGuia);
        }
    }
}
