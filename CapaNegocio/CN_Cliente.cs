using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cliente
    {

        private CD_Cliente objcd_Cliente = new CD_Cliente();


        public List<Cliente> Listar()
        {
            return objcd_Cliente.Listar();
        }

        public int Registrar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el documento del Cliente\n";
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre completo del Cliente\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Es necesario el correo del Cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Cliente.Registrar(obj, out Mensaje);
            }


        }


        public bool Editar(Cliente obj, out string Mensaje)
        {

            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el documento del Cliente\n";
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre completo del Cliente\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Es necesario el correo del Cliente\n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Cliente.Editar(obj, out Mensaje);
            }


        }


        public bool Eliminar(Cliente obj, out string Mensaje)
        {
            return objcd_Cliente.Eliminar(obj, out Mensaje);
        }


        public int RegistrarC(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            // Verificar si el cliente ya existe
            if (ExisteCliente(obj.Documento))
            {
                // Si el cliente existe, actualiza sus puntos
                ActualizarPuntos(obj.Documento, obj.Puntos);
                Mensaje = "Cliente existente, puntos actualizados.";
                return 1; // Devuelve un valor que indica que se actualizó
            }

            int idClientegenerado = 0;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarCliente", oconexion);
                    cmd.Parameters.AddWithValue("Documento", obj.Documento);
                    cmd.Parameters.AddWithValue("NombreCompleto", obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("Telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    idClientegenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idClientegenerado = 0;
                Mensaje = ex.Message;
            }

            return idClientegenerado;
        }

        private void ActualizarPuntos(string documento, string nuevosPuntos)
        {
            // Lógica para actualizar los puntos en la base de datos
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                // Definir la instrucción SQL para actualizar los puntos
                string sql = "UPDATE CLIENTE SET puntos = @puntos WHERE Documento = @Documento";

                using (SqlCommand cmd = new SqlCommand(sql, oconexion))
                {
                    // Añadir parámetros al comando
                    cmd.Parameters.AddWithValue("@Documento", documento);
                    cmd.Parameters.AddWithValue("@puntos", nuevosPuntos);

                    // Abrir conexión y ejecutar la instrucción SQL
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }





        public bool ExisteCliente(string documento)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT COUNT(*) FROM CLIENTE WHERE Documento = @Documento";
                using (SqlCommand cmd = new SqlCommand(query, oconexion))
                {
                    cmd.Parameters.AddWithValue("@Documento", documento);
                    oconexion.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; // Retorna true si existe
                }
            }
        }


    }
}
