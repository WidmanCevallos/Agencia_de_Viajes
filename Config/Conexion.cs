using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_de_Viajes.Config
{
    public static class Conexion
    {
        private static string connectionString = "Server=DESKTOP-SU2G25G\\SQLEXPRESS;Database=Agenciadeviajes;User Id=sa;Password=widman;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}
