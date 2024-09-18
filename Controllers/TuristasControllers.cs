using Agencia_de_Viajes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_de_Viajes.Controllers
{
    internal class TuristasController
    {
        private TuristasModels turistasModel;

        public TuristasController()
        {
            turistasModel = new TuristasModels();
        }

        public DataTable ObtenerTuristas()
        {
            return turistasModel.ObtenerTuristas();
        }

        public DataTable ObtenerViajes()
        {
            return turistasModel.ObtenerViajes();
        }

        public void AgregarTurista(string nombre, int idViaje)
        {
            turistasModel.AgregarTurista(nombre, idViaje);
        }

        public void ActualizarTurista(int idTurista, string nombre, int idViaje)
        {
            turistasModel.ActualizarTurista(idTurista, nombre, idViaje);
        }

        public void EliminarTurista(int idTurista)
        {
            turistasModel.EliminarTurista(idTurista);
        }

        public DataRow ObtenerTuristaPorId(int idTurista)
        {
            return turistasModel.ObtenerTuristaPorId(idTurista);
        }
    }
}