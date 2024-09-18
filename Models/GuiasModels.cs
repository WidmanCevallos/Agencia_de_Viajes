using Agencia_de_Viajes.Config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_de_Viajes.Models
{
    internal class GuiasModel
    {
        // Obtener todos los guías
        public DataTable ObtenerGuias()
        {
            DataTable dtGuias = new DataTable();
            string query = "SELECT * FROM Guias";

            using (SqlConnection conn = Conexion.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                conn.Open();
                da.Fill(dtGuias);
                conn.Close();
            }

            return dtGuias;
        }

        // Agregar un guía
        public void AgregarGuia(string nombre)
        {
            string query = "INSERT INTO Guias (Nombre) VALUES (@Nombre)";

            using (SqlConnection conn = Conexion.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        // Actualizar un guía
        public void ActualizarGuia(int idGuia, string nombre)
        {
            string query = "UPDATE Guias SET Nombre = @Nombre WHERE ID_Guía = @ID_Guía";

            using (SqlConnection conn = Conexion.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID_Guía", idGuia);
                cmd.Parameters.AddWithValue("@Nombre", nombre);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        // Eliminar un guía
        public void EliminarGuia(int idGuia)
        {
            string query = "DELETE FROM Guias WHERE ID_Guía = @ID_Guía";

            using (SqlConnection conn = Conexion.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID_Guía", idGuia);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}