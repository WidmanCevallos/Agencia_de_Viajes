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
    public class Turista
    {
        public int ID_Turista { get; set; }
        public string Nombre { get; set; }
        public int ID_Viaje { get; set; }
    }

    internal class TuristasModels
    {
        public DataTable ObtenerTuristas()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = Conexion.GetConnection())
            {
                con.Open(); // Abre la conexión
                string query = "SELECT ID_Turista, Nombre, ID_Viaje FROM Turistas";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable ObtenerViajes()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = Conexion.GetConnection())
            {
                con.Open(); // Abre la conexión
                string query = "SELECT ID_Viaje, (SELECT Nombre FROM Destinos WHERE ID_Destino = v.ID_Destino) AS NombreDestino " +
                               "FROM Viajes v";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public void AgregarTurista(string nombre, int idViaje)
        {
            using (SqlConnection con = Conexion.GetConnection())
            {
                con.Open(); // Abre la conexión
                string query = "INSERT INTO Turistas (Nombre, ID_Viaje) VALUES (@Nombre, @ID_Viaje)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@ID_Viaje", idViaje);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarTurista(int idTurista, string nombre, int idViaje)
        {
            using (SqlConnection con = Conexion.GetConnection())
            {
                con.Open(); // Abre la conexión
                string query = "UPDATE Turistas SET Nombre = @Nombre, ID_Viaje = @ID_Viaje WHERE ID_Turista = @ID_Turista";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID_Turista", idTurista);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@ID_Viaje", idViaje);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarTurista(int idTurista)
        {
            using (SqlConnection con = Conexion.GetConnection())
            {
                con.Open(); // Abre la conexión
                string query = "DELETE FROM Turistas WHERE ID_Turista = @ID_Turista";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID_Turista", idTurista);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataRow ObtenerTuristaPorId(int idTurista)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = Conexion.GetConnection())
            {
                con.Open(); // Abre la conexión
                string query = "SELECT ID_Turista, Nombre, ID_Viaje FROM Turistas WHERE ID_Turista = @ID_Turista";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@ID_Turista", idTurista);
                    adapter.Fill(dt);
                }
            }
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            return null;
        }
    }
}