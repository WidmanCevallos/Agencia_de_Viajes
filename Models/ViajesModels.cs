using Agencia_de_Viajes.Config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia_de_Viajes.Models
{
    public class Viaje
    {
        public int ID_Viaje { get; set; }
        public int ID_Destino { get; set; }
        public int ID_Guía { get; set; }
        public DateTime Fecha { get; set; }
    }

    internal class ViajesModels
    {
        public DataTable ObtenerViajes()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (var connection = Conexion.GetConnection())
                {
                    string query = "SELECT ID_Viaje, ID_Destino, ID_Guía, Fecha FROM Viajes"; 
                    var adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los viajes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        public Viaje ObtenerViajePorId(int idViaje)
        {
            Viaje viaje = null;
            string query = "SELECT * FROM Viajes WHERE ID_Viaje = @ID_Viaje";

            using (var connection = Conexion.GetConnection())
            {
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Viaje", idViaje);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        viaje = new Viaje
                        {
                            ID_Viaje = Convert.ToInt32(reader["ID_Viaje"]),
                            ID_Destino = Convert.ToInt32(reader["ID_Destino"]),
                            ID_Guía = Convert.ToInt32(reader["ID_Guía"]),
                            Fecha = Convert.ToDateTime(reader["Fecha"])
                        };
                    }
                }
            }

            return viaje;
        }

        public void AgregarViaje(int idDestino, int idGuia, DateTime fecha)
        {
            using (var connection = Conexion.GetConnection())
            {
                string query = "INSERT INTO Viajes (ID_Destino, ID_Guía, Fecha) VALUES (@ID_Destino, @ID_Guía, @Fecha)";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Destino", idDestino);
                command.Parameters.AddWithValue("@ID_Guía", idGuia);
                command.Parameters.AddWithValue("@Fecha", fecha);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void ActualizarViaje(int idViaje, int idDestino, int idGuia, DateTime fecha)
        {
            using (var connection = Conexion.GetConnection())
            {
                string query = "UPDATE Viajes SET ID_Destino = @ID_Destino, ID_Guía = @ID_Guía, Fecha = @Fecha WHERE ID_Viaje = @ID_Viaje";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Destino", idDestino);
                command.Parameters.AddWithValue("@ID_Guía", idGuia);
                command.Parameters.AddWithValue("@Fecha", fecha);
                command.Parameters.AddWithValue("@ID_Viaje", idViaje);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void EliminarViaje(int idViaje)
        {
            using (var connection = Conexion.GetConnection())
            {
                string query = "DELETE FROM Viajes WHERE ID_Viaje = @ID_Viaje";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Viaje", idViaje);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}