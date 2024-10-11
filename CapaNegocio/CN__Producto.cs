using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN__Producto
    {


        private CD_Producto objcd_Producto = new CD_Producto();


        public List<Producto> Listar()
        {
            return objcd_Producto.Listar();
        }

          public int Registrar(Producto obj, out string Mensaje)
          {
               Mensaje = string.Empty;

               if (obj.Codigo == "")
               {
                   Mensaje += "Es necesario el codigo del Producto\n";
               }

               if (obj.Nombre == "")
               {
                   Mensaje += "Es necesario el nombre del Producto\n";
               }

               if (obj.Descripcion == "")
               {
                   Mensaje += "Es necesario la Descripcion del Producto\n";
               }

               if (Mensaje != string.Empty)
               {
                   return 0;
               }
               else
               {
                   return objcd_Producto.Registrar(obj, out Mensaje);
               }


          }
        // Método para registrar un nuevo producto
        public int RegistrarS(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (string.IsNullOrEmpty(obj.Nombre))
            {
                Mensaje += "Es necesario el nombre del Producto\n";
            }

            if (string.IsNullOrEmpty(obj.Descripcion))
            {
                Mensaje += "Es necesaria la Descripción del Producto\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                string query = "INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioVenta, Estado) VALUES (@Codigo, @Nombre, @Descripcion, @IdCategoria, @Stock, @PrecioVenta, @Estado)";
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    using (SqlCommand cmd = new SqlCommand(query, oconexion))
                    {
                        cmd.Parameters.AddWithValue("@Codigo", obj.Codigo);
                        cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                        cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                        cmd.Parameters.AddWithValue("@IdCategoria", 1); // Siempre 1
                        cmd.Parameters.AddWithValue("@Stock", obj.Stock);
                        cmd.Parameters.AddWithValue("@PrecioVenta", obj.PrecioVenta);
                        cmd.Parameters.AddWithValue("@Estado", obj.Estado);

                        try
                        {
                            oconexion.Open();
                            int filasAfectadas = cmd.ExecuteNonQuery();
                            if (filasAfectadas > 0)
                            {
                                return 1; // Retorna 1 si el registro fue exitoso
                            }
                            else
                            {
                                Mensaje = "No se pudo registrar el producto.";
                                return 0;
                            }
                        }
                        catch (Exception ex)
                        {
                            Mensaje = ex.Message;
                            return 0;
                        }
                    }
                }
            }
        }



        public bool ActualizarStock(Producto obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    // Verifica si el producto ya existe en la base de datos
                    string query = "SELECT Stock FROM PRODUCTO WHERE Codigo = @Codigo";
                    using (SqlCommand cmd = new SqlCommand(query, oconexion))
                    {
                        cmd.Parameters.AddWithValue("@Codigo", obj.Codigo);
                        oconexion.Open();

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            // Producto existe, actualizar el stock
                            int stockActual = Convert.ToInt32(result);
                            int nuevoStock = stockActual + obj.Stock;

                            string updateQuery = "UPDATE PRODUCTO SET Stock = @Stock WHERE Codigo = @Codigo";
                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, oconexion))
                            {
                                updateCmd.Parameters.AddWithValue("@Stock", nuevoStock);
                                updateCmd.Parameters.AddWithValue("@Codigo", obj.Codigo);
                                int filasAfectadas = updateCmd.ExecuteNonQuery();

                                if (filasAfectadas > 0)
                                {
                                    respuesta = true;
                                }
                                else
                                {
                                    Mensaje = "No se pudo actualizar el stock del producto.";
                                }
                            }
                        }
                        else
                        {
                            // Producto no existe, insertar como nuevo producto
                            respuesta = RegistrarS(obj, out Mensaje) > 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }

        public bool Editar(Producto obj, out string Mensaje)
        {

            Mensaje = string.Empty;
            

            if (obj.Codigo == "")
            {
                Mensaje += "Es necesario el codigo del Producto\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del Producto\n";
            }

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario la Descripcion del Producto\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Producto.Editar(obj, out Mensaje);
            }
        }

        public bool ActualizarStockN(Producto obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    string query = "SELECT Stock, PrecioVenta FROM PRODUCTO WHERE Nombre = @Nombre";
                    using (SqlCommand cmd = new SqlCommand(query, oconexion))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                        oconexion.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int stockActual = reader.GetInt32(0); // Stock actual
                                decimal precioActual = reader.GetDecimal(1); // Precio actual

                                // Cierra el DataReader antes de proceder con la actualización
                                reader.Close();

                                int nuevoStock = obj.Stock;
                                decimal nuevoPrecio = obj.PrecioVenta;

                                // Actualizar el stock y el precio
                                string updateQuery = "UPDATE PRODUCTO SET Stock = @Stock, PrecioVenta = @PrecioVenta WHERE Nombre = @Nombre";
                                using (SqlCommand updateCmd = new SqlCommand(updateQuery, oconexion))
                                {
                                    updateCmd.Parameters.AddWithValue("@Stock", nuevoStock);
                                    updateCmd.Parameters.AddWithValue("@PrecioVenta", nuevoPrecio);
                                    updateCmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                                    int filasAfectadas = updateCmd.ExecuteNonQuery();

                                    if (filasAfectadas > 0)
                                    {
                                        respuesta = true; // Actualización exitosa
                                    }
                                    else
                                    {
                                        Mensaje = "No se pudo actualizar el stock del producto.";
                                    }
                                }
                            }
                            else
                            {
                                // Si no se encuentra el producto, lo registra
                                respuesta = RegistrarS(obj, out Mensaje) > 0;
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                respuesta = false;
                Mensaje = $"Error en la base de datos: {sqlEx.Message}";
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }







        public bool Eliminar(Producto obj, out string Mensaje)
        {
            return objcd_Producto.Eliminar(obj, out Mensaje);
        }
    }
}
