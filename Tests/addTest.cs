using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoTest.Logica;
using ProyectoTest.Models;
using ProyectoTest.Controllers;
using Moq;
using System.Data.SqlClient;




namespace Tests
{
    [TestClass]
    public class addTest
    {
        //Este metodo verifica que las compras si se estén registrando
        [TestMethod]
        public void Registrar_CompraValida_RetornaTrue()
        {
            // Arrange
            var mockDatabase = new Mock<IDatabase>();
            mockDatabase.Setup(db => db.ExecuteNonQuery(It.IsAny<string>(), It.IsAny<SqlParameter[]>()))
                        .Returns(true); // Simula que la ejecución fue exitosa

            var compraLogica = new CompraLogica(mockDatabase.Object); // Usar el mock aquí

            var oCompra = new Compra
            {
                IdUsuario = 2,
                TotalProducto = "100", // Asegúrate de que esto sea del tipo correcto
                Total = 120,
                Contacto = "Test Contact",
                Telefono = "123456789",
                Direccion = "123 Test Street",
                IdDistrito = "5", // Asegúrate de que esto sea del tipo correcto
                oDetalleCompra = new List<DetalleCompra>
                {
                    new DetalleCompra { IdProducto = 1, Cantidad = 2, Total = 40 },
                    new DetalleCompra { IdProducto = 2, Cantidad = 3, Total = 60 }
                }
            };

            // Act
            bool resultado = compraLogica.Registrar(oCompra);

            // Assert
            Assert.IsTrue(resultado, "El método debería haber registrado la compra correctamente.");
        }




        //Este test revisa que si se estan registrando los usuario
        [TestMethod]
        public void Registrar_UsuarioValido_RetornaIdUsuario()
        {
            // Arrange
            var mockDatabase = new Mock<IDatabase>();

            // Configura el mock para establecer el valor de 'Resultado' en 1 al ejecutar el método
            mockDatabase.Setup(db => db.ExecuteNonQuery(It.IsAny<string>(), It.IsAny<SqlParameter[]>()))
                .Callback<string, SqlParameter[]>((query, parameters) =>
                {
                    // Busca el parámetro "Resultado" y le asigna el valor 1
                    var resultadoParam = parameters.FirstOrDefault(p => p.ParameterName == "Resultado");
                    if (resultadoParam != null)
                    {
                        resultadoParam.Value = 1;  // Simula que la base de datos devolvió el ID 1
                    }
                })
                .Returns(true);  // Indica que la operación fue exitosa

            var usuarioLogica = UsuarioLogica.GetInstancia(mockDatabase.Object);

            var oUsuario = new Usuario
            {
                Nombres = "John",
                Apellidos = "Doe",
                Correo = "john.doe@example.com",
                Contrasena = "password123",
                EsAdministrador = false
            };

            // Act
            int resultado = usuarioLogica.Registrar(oUsuario);

            // Assert
            Assert.AreEqual(1, resultado, "El método debería haber registrado el usuario correctamente y devuelto un ID.");
        }




        [TestMethod]
        public void Registrar_ProductoValido_RetornaIdProducto()
        {
            // Arrange
            var mockDatabase = new Mock<IDatabase>();

            // Configura el mock para simular que la ejecución fue exitosa y asignar un ID al parámetro de salida "Resultado"
            mockDatabase.Setup(db => db.ExecuteNonQuery(It.IsAny<string>(), It.IsAny<SqlParameter[]>()))
                .Callback<string, SqlParameter[]>((query, parameters) =>
                {
                    var resultadoParam = parameters.FirstOrDefault(p => p.ParameterName == "Resultado");
                    if (resultadoParam != null)
                    {
                        resultadoParam.Value = 1;  // Simula que se registró con ID 1
                    }
                })
                .Returns(true);  // Simula que la operación fue exitosa

            var productoLogica = new ProductoLogica(mockDatabase.Object);

            var oProducto = new Producto
            {
                Nombre = "Producto Test",
                Descripcion = "Descripción de prueba",
                oMarca = new Marca { IdMarca = 1 },
                oCategoria = new Categoria { IdCategoria = 1 },
                Precio = 100.00m,
                Stock = 50,
                RutaImagen = "ruta/imagen.jpg",
                Activo = true
            };

            // Act
            int resultado = productoLogica.Registrar(oProducto);

            // Assert
            Assert.AreEqual(1, resultado, "El método debería haber registrado el producto y devuelto un ID.");
        }

        [TestMethod]
        public void Eliminar_ProductoExistente_RetornaTrue()
        {
            // Arrange
            var mockDatabase = new Mock<IDatabase>();
            mockDatabase.Setup(db => db.ExecuteNonQuery(It.IsAny<string>(), It.IsAny<SqlParameter[]>()))
                        .Returns(true); // Simula que la operación de eliminación fue exitosa

            var productoLogica = new ProductoLogica(mockDatabase.Object);

            int idProducto = 1; // ID de un producto que se va a eliminar

            // Act
            bool resultado = productoLogica.Eliminar(idProducto);

            // Assert
            Assert.IsTrue(resultado, "El método debería haber eliminado el producto correctamente.");
        }





    }
}
