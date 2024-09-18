using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencia_de_Viajes.Config;

namespace Agencia_de_Viajes.Models
{
    internal class DestinoModels
    {
        public DataTable ObtenerDestinos()
        {
            DataTable dtDestinos = new DataTable();
            string query = "SELECT * FROM Destinos";

            using (SqlConnection conn = Conexion.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                conn.Open();
                da.Fill(dtDestinos);
                conn.Close();
            }

            return dtDestinos;
        }

        public void AgregarDestino(string nombre, string pais)
        {
            string query = "INSERT INTO Destinos (Nombre, País) VALUES (@Nombre, @Pais)";

            using (SqlConnection conn = Conexion.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Pais", pais);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void ActualizarDestino(int idDestino, string nombre, string pais)
        {
            string query = "UPDATE Destinos SET Nombre = @Nombre, País = @Pais WHERE ID_Destino = @ID_Destino";

            using (SqlConnection conn = Conexion.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID_Destino", idDestino);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Pais", pais);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void EliminarDestino(int idDestino)
        {
            string query = "DELETE FROM Destinos WHERE ID_Destino = @ID_Destino";

            using (SqlConnection conn = Conexion.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID_Destino", idDestino);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}