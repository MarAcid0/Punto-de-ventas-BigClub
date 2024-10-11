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
    public class CN_Categoria
    {
       
        private CD_Categoria objcd_Categoria = new CD_Categoria();

        public List<Categoria> Listar()
        {
            return objcd_Categoria.Listar();
        }

        public int Registrar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;


            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario la descripcion de la Categoria\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Categoria.Registrar(obj, out Mensaje);
            }


        }


        public bool Editar(Categoria obj, out string Mensaje)
        {

            Mensaje = string.Empty;

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario la descripcion de la Categoria\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Categoria.Editar(obj, out Mensaje);
            }


        }


        public bool Eliminar(Categoria obj, out string Mensaje)
        {
            return objcd_Categoria.Eliminar(obj, out Mensaje);
        }
        public bool EliminarTodas(out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM CATEGORIA", oconexion); // Consulta SQL para eliminar todas las categorías
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = true; // Si no hay excepciones, se considera que la eliminación fue exitosa
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }

            return respuesta;
        }
        public List<Categoria> ObtenerTodas()
        {
            return objcd_Categoria.Listar(); // Asumiendo que Listar() obtiene todas las categorías
        }

    }
}
