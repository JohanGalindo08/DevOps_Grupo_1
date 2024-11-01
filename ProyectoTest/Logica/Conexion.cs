using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
<<<<<<< HEAD
using System.Data.SqlClient;
=======
>>>>>>> bfa03de5ce5317cadb11a56dfda7c7f899918476

namespace ProyectoTest.Logica
{
    public class Conexion
    {
        public static string CN = "Data Source=.;Initial Catalog=DB_CARRITO;Integrated Security=True";
    }
<<<<<<< HEAD


    public interface IDatabase
    {
        bool ExecuteNonQuery(string query, SqlParameter[] parameters);
    }

    public class Database : IDatabase
    {
        public bool ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(Conexion.CN))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }

=======
>>>>>>> bfa03de5ce5317cadb11a56dfda7c7f899918476
}