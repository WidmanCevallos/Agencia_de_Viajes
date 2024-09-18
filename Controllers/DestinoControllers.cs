using Agencia_de_Viajes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_de_Viajes.Controllers
{
    public class DestinoController
    {
        private DestinoModels modelo = new DestinoModels();

        public DataTable ObtenerDestinos()
        {
            return modelo.ObtenerDestinos();
        }

        public void AgregarDestino(string nombre, string pais)
        {
            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(pais))
            {
                modelo.AgregarDestino(nombre, pais);
            }
            else
            {
                throw new ArgumentException("Los campos de nombre y país no pueden estar vacíos.");
            }
        }

        public void ActualizarDestino(int idDestino, string nombre, string pais)
        {
            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(pais) && idDestino > 0)
            {
                modelo.ActualizarDestino(idDestino, nombre, pais);
            }
            else
            {
                throw new ArgumentException("Debe proporcionar un ID de destino válido y no dejar los campos en blanco.");
            }
        }

        public void EliminarDestino(int idDestino)
        {
            if (idDestino > 0)
            {
                modelo.EliminarDestino(idDestino);
            }
            else
            {
                throw new ArgumentException("Debe proporcionar un ID de destino válido para eliminar.");
            }
        }
    }
}
