using CapaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Transpaso
    {
        public DataTable ListarTranspasos()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM Transpasos";  // Asegúrate que el nombre de la tabla sea correcto en tu base de datos

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, oconexion);
                    da.Fill(tabla);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los datos de Transpasos: " + ex.Message);
                }
            }

            return tabla;
        }
        public bool ExisteTranspaso(string idStokSucursal)
        {
            bool existe = false;

            // Usar el bloque using para manejar la conexión
            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Transpasos WHERE idStokSucursal = @idStokSucursal";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idStokSucursal", idStokSucursal);

                    // Ejecutar el comando y obtener el conteo
                    int count = (int)cmd.ExecuteScalar();
                    existe = count > 0; // Si hay al menos un registro, existe
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    throw new Exception("Error al verificar la existencia del traspaso: " + ex.Message);
                }
            }
            return existe;
        }



        public int RegistrarTranspaso(Transpasos transpaso, out string mensaje)
        {
            mensaje = string.Empty;
            int resultado = 0;

            string query = "INSERT INTO Transpasos (idStokSucursal, idProducto, stok, idSucursal, procesado, FOLIO, IdSucursalEnvio, NombreProducto) " +
                           "VALUES (@idStokSucursal, @idProducto, @stok, @idSucursal, @procesado, @FOLIO, @idSucursalEnvio, @NombreProducto)";

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@idProducto", transpaso.idProducto);
                    cmd.Parameters.AddWithValue("@stok", transpaso.stok);
                    cmd.Parameters.AddWithValue("@idSucursal", transpaso.idSucursal);
                    cmd.Parameters.AddWithValue("@procesado", transpaso.procesado);
                    cmd.Parameters.AddWithValue("@FOLIO", transpaso.FOLIO);
                    cmd.Parameters.AddWithValue("@idSucursalEnvio", transpaso.idSucursalEnvio);
                    cmd.Parameters.AddWithValue("@NombreProducto", transpaso.NombreProducto);
                    cmd.Parameters.AddWithValue("@idStokSucursal", transpaso.idStokSucursal);

                    try
                    {
                        connection.Open();
                        resultado = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        mensaje = ex.Message;
                    }
                }
            }

            return resultado;
        }
    }
}
