using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ProyectoTest.Logica
{
    public class Conexion
    {
        public static string CN = "Data Source=.;Initial Catalog=DB_CARRITO;Integrated Security=True";
    }


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

}