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
    public class CN_traspasos
    {
        private Negocio negocio;

        // Método para registrar el traspaso
        public int RegistrarTranspaso(int idSucursalEnvio, long folioNumerico, string nombreEmpleado, List<DetallesTranspaso> detalles, out string mensaje)
        {
            int idTranspasoGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();

                    // Crear la transacción
                    using (SqlTransaction transaccion = oconexion.BeginTransaction())
                    {
                        try
                        {
                            // Registrar el traspaso en la tabla "Transpasos"
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO Transpasos (idSucursal, FOLIO, IdSucursalEnvio, NombreEmpleado, idDetalles) OUTPUT INSERTED.idTranspasos VALUES (@idSucursal, @FOLIO, @IdSucursalEnvio, @NombreEmpleado, @idDetalles)", oconexion, transaccion))
                            {
                                cmd.Parameters.AddWithValue("@idSucursal", 4); // Cambia esto según tu lógica
                                cmd.Parameters.AddWithValue("@FOLIO", folioNumerico);
                                cmd.Parameters.AddWithValue("@IdSucursalEnvio", idSucursalEnvio);
                                cmd.Parameters.AddWithValue("@NombreEmpleado", nombreEmpleado);
                                cmd.Parameters.AddWithValue("@idDetalles", detalles.Count > 0 ? detalles[0].idDetalles : 0);

                                // Obtener el ID del traspaso recién generado
                                idTranspasoGenerado = (int)cmd.ExecuteScalar();
                            }

                            // Registrar los detalles del traspaso
                            foreach (var detalle in detalles)
                            {
                                using (SqlCommand cmd = new SqlCommand("INSERT INTO DetallesTranspaso (idDetalles, FOLIO, NombreProducto, stok) VALUES (@idDetalles, @FOLIO, @NombreProducto, @stok)", oconexion, transaccion))
                                {
                                    cmd.Parameters.AddWithValue("@idDetalles", detalle.idDetalles);
                                    cmd.Parameters.AddWithValue("@FOLIO", folioNumerico);
                                    cmd.Parameters.AddWithValue("@NombreProducto", detalle.NombreProducto);
                                    cmd.Parameters.AddWithValue("@stok", detalle.stok);

                                    cmd.ExecuteNonQuery();
                                }
                            }

                            // Confirmar la transacción
                            transaccion.Commit();
                        }
                        catch (Exception ex)
                        {
                            // Revertir la transacción en caso de error
                            transaccion.Rollback();
                            idTranspasoGenerado = 0;
                            mensaje = ex.Message;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                idTranspasoGenerado = 0;
                mensaje = ex.Message;
            }

            return idTranspasoGenerado;
        }

    }

}
