using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad;
using System.Net.Http;
using System.Data.SqlClient;
using System.Configuration;


namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {

            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == txtdocumento.Text && u.Clave == txtclave.Text).FirstOrDefault();


            if (ousuario != null)
            {

                Inicio form = new Inicio(ousuario);

                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;

            }
            else {
                MessageBox.Show("no se encontro el usuario","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

            

        }

        private void frm_closing(object sender, FormClosingEventArgs e) {

            txtdocumento.Text = "";
            txtclave.Text = "";
            this.Show();
        }
        private async Task<bool> IsInternetAvailable()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    // Realizar una solicitud a un recurso conocido
                    using (var response = await client.GetAsync("https://www.google.com"))
                    {
                        return response.IsSuccessStatusCode; // Retorna verdadero si se recibe una respuesta exitosa
                    }
                }
            }
            catch
            {
                return false; // En caso de error, se considera que no hay conexión
            }
        }
        private async void Login_Load(object sender, EventArgs e)
        {
            label6.Text = "En línea";

            // Verificar la conexión a Internet
            if (!await IsInternetAvailable())
            {
                label6.Text = "Offline";
                return; // Detener el proceso si no hay conexión
            }

            // URL de la API
            string apiUrl = "https://software.bigcluboutlet.com/venta/api/obtenerusuarios.php?password=28292929292929292";

            // Obtener la cadena de conexión del archivo de configuración
            string connectionString = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;

            try
            {
                // Usar HttpClient para obtener los datos
                using (HttpClient client = new HttpClient())
                {
                    // Realizar la solicitud GET a la API
                    var response = await client.GetStringAsync(apiUrl);

                    // Deserializar la respuesta JSON
                    var usuarios = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Usuarios>>(response);

                    // Conectar a la base de datos local
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        await conn.OpenAsync();

                        foreach (var usuario in usuarios)
                        {
                            // Comprobar si el usuario ya existe por documento
                            string checkUserQuery = "SELECT COUNT(1) FROM usuario WHERE Documento = @Documento";
                            using (SqlCommand checkCmd = new SqlCommand(checkUserQuery, conn))
                            {
                                checkCmd.Parameters.AddWithValue("@Documento", usuario.Documento);
                                int exists = (int)await checkCmd.ExecuteScalarAsync();

                                if (exists == 0) // Si no existe, insertar
                                {
                                    string insertQuery = "INSERT INTO usuario ( Documento, NombreCompleto, Correo, Clave, IdRol, Estado) " +
                                                         "VALUES ( @Documento, @NombreCompleto, @Correo, @Clave, @IdRol, @Estado)";

                                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                                    {
                                        insertCmd.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
                                        insertCmd.Parameters.AddWithValue("@Documento", usuario.Documento);
                                        insertCmd.Parameters.AddWithValue("@NombreCompleto", usuario.NombreCompleto);
                                        insertCmd.Parameters.AddWithValue("@Correo", usuario.Correo);
                                        insertCmd.Parameters.AddWithValue("@Clave", usuario.Clave);
                                        insertCmd.Parameters.AddWithValue("@IdRol", usuario.IdRol); // Asegúrate que IdRol se asigna correctamente
                                        insertCmd.Parameters.AddWithValue("@Estado", usuario.Estado);
                                        insertCmd.Parameters.AddWithValue("@FechaRegistro", usuario.FechaRegistro);

                                        await insertCmd.ExecuteNonQueryAsync();
                                    }
                                }
                                // Si el usuario ya existe, simplemente se salta la inserción
                            }
                        }
                    }
                }
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show("Error de conexión: " + httpEx.Message);
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error de base de datos: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private class Usuarios
        {
            public int IdUsuario { get; set; }
            public string Documento { get; set; }
            public string NombreCompleto { get; set; }
            public string Correo { get; set; }
            public string Clave { get; set; }
            public int IdRol { get; set; }
            public bool Estado { get; set; }
            public string FechaRegistro { get; set; }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
