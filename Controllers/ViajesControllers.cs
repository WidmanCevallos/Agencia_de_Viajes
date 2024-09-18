using Agencia_de_Viajes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_de_Viajes.Controllers
{
    internal class ViajesController
    {
        private ViajesModels viajesModel;

        public ViajesController()
        {
            viajesModel = new ViajesModels();
        }

        public DataTable ObtenerViajes()
        {
            return viajesModel.ObtenerViajes();
        }

        public Viaje ObtenerViajePorId(int idViaje)
        {
            return viajesModel.ObtenerViajePorId(idViaje);
        }

        public void AgregarViaje(int idDestino, int idGuia, DateTime fecha)
        {
            viajesModel.AgregarViaje(idDestino, idGuia, fecha);
        }

        public void ActualizarViaje(int idViaje, int idDestino, int idGuia, DateTime fecha)
        {
            viajesModel.ActualizarViaje(idViaje, idDestino, idGuia, fecha);
        }

        public void EliminarViaje(int idViaje)
        {
            viajesModel.EliminarViaje(idViaje);
        }
    }
}
