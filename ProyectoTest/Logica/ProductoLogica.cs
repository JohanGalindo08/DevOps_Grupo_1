using ProyectoTest.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;

namespace ProyectoTest.Logica
{
    public class ProductoLogica
    {
        private static ProductoLogica _instancia = null;

        public ProductoLogica()
        {

        }

<<<<<<< HEAD
        private readonly IDatabase _database;

        public ProductoLogica(IDatabase database)
        {
            _database = database;
        }

=======
>>>>>>> bfa03de5ce5317cadb11a56dfda7c7f899918476
        public static ProductoLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ProductoLogica();
                }

                return _instancia;
            }
        }

        public List<Producto> Listar()
        {

            List<Producto> rptListaProducto = new List<Producto>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                SqlCommand cmd = new SqlCommand("sp_obtenerProducto", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        rptListaProducto.Add(new Producto()
                        {
                            IdProducto = Convert.ToInt32(dr["IdProducto"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Descripcion = dr["Descripcion"].ToString(),
<<<<<<< HEAD
                            oMarca = new Marca() { IdMarca = Convert.ToInt32(dr["IdMarca"].ToString()), Descripcion = dr["DescripcionMarca"].ToString() },
=======
                            oMarca = new Marca() { IdMarca = Convert.ToInt32(dr["IdMarca"].ToString()),Descripcion = dr["DescripcionMarca"].ToString() },
>>>>>>> bfa03de5ce5317cadb11a56dfda7c7f899918476
                            oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(dr["IdCategoria"].ToString()), Descripcion = dr["DescripcionCategoria"].ToString() },
                            Precio = Convert.ToDecimal(dr["Precio"].ToString(), new CultureInfo("es-PE")),
                            Stock = Convert.ToInt32(dr["Stock"].ToString()),
                            RutaImagen = dr["RutaImagen"].ToString(),
                            Activo = Convert.ToBoolean(dr["Activo"].ToString())
                        });
                    }
                    dr.Close();

                    return rptListaProducto;

                }
                catch (Exception ex)
                {
                    rptListaProducto = null;
                    return rptListaProducto;
                }
            }
        }



        public int Registrar(Producto oProducto)
        {
            int respuesta = 0;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_registrarProducto", oConexion);
                    cmd.Parameters.AddWithValue("Nombre", oProducto.Nombre );
                    cmd.Parameters.AddWithValue("Descripcion", oProducto.Descripcion );
                    cmd.Parameters.AddWithValue("IdMarca", oProducto.oMarca.IdMarca );
                    cmd.Parameters.AddWithValue("IdCategoria", oProducto.oCategoria.IdCategoria);
                    cmd.Parameters.AddWithValue("Precio", oProducto.Precio );
                    cmd.Parameters.AddWithValue("Stock", oProducto.Stock );
                    cmd.Parameters.AddWithValue("RutaImagen",oProducto.RutaImagen );
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToInt32(cmd.Parameters["Resultado"].Value);

                }
                catch (Exception ex)
                {
                    respuesta = 0;
                }
            }
            return respuesta;
        }

<<<<<<< HEAD

        /*public new int Registrar(Producto oProducto)
        {
            string query = "sp_registrarProducto";
            SqlParameter[] parameters = {
            new SqlParameter("Nombre", oProducto.Nombre),
            new SqlParameter("Descripcion", oProducto.Descripcion),
            new SqlParameter("IdMarca", oProducto.oMarca.IdMarca),
            new SqlParameter("IdCategoria", oProducto.oCategoria.IdCategoria),
            new SqlParameter("Precio", oProducto.Precio),
            new SqlParameter("Stock", oProducto.Stock),
            new SqlParameter("RutaImagen", oProducto.RutaImagen),
            new SqlParameter("Resultado", SqlDbType.Int) { Direction = ParameterDirection.Output }
        };

            _database.ExecuteNonQuery(query, parameters);

            return Convert.ToInt32(parameters.First(p => p.ParameterName == "Resultado").Value);
        }*/

=======
>>>>>>> bfa03de5ce5317cadb11a56dfda7c7f899918476
        public bool Modificar(Producto oProducto)
        {
            bool respuesta = false;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_editarProducto", oConexion);
                    cmd.Parameters.AddWithValue("IdProducto", oProducto.IdProducto);
                    cmd.Parameters.AddWithValue("Nombre", oProducto.Nombre);
                    cmd.Parameters.AddWithValue("Descripcion", oProducto.Descripcion);
                    cmd.Parameters.AddWithValue("IdMarca", oProducto.oMarca.IdMarca);
                    cmd.Parameters.AddWithValue("IdCategoria", oProducto.oCategoria.IdCategoria);
                    cmd.Parameters.AddWithValue("Precio", oProducto.Precio);
                    cmd.Parameters.AddWithValue("Stock", oProducto.Stock);
                    cmd.Parameters.AddWithValue("Activo", oProducto.Activo);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);

                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
        

        public bool ActualizarRutaImagen(Producto oProducto)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_actualizarRutaImagen", oConexion);
                    cmd.Parameters.AddWithValue("IdProducto", oProducto.IdProducto);
                    cmd.Parameters.AddWithValue("RutaImagen", oProducto.RutaImagen);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public bool Eliminar(int id)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("delete from Producto where idProducto = @id", oConexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.CommandType = CommandType.Text;

                    oConexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = true;

                }
                catch (Exception ex)
                {
                    respuesta = false;
                }

            }

            return respuesta;

        }

<<<<<<< HEAD

        /*public new bool Eliminar(int id)
        {
            string query = "delete from Producto where idProducto = @id";
            SqlParameter[] parameters = { new SqlParameter("@id", id) };

            return _database.ExecuteNonQuery(query, parameters);
        }*/

=======
>>>>>>> bfa03de5ce5317cadb11a56dfda7c7f899918476
    }
}