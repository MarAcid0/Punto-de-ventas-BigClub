using CapaEntidad;
using CapaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmDetalleCompra : Form
    {
        public frmDetalleCompra()
        {
            InitializeComponent();
            CargarTranspasos(); // Carga los datos al abrir el formulario
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener datos de la sucursal
                Negocio datos = new CN_Negocio().ObtenerDatos();
                string apiUrl = "https://software.bigcluboutlet.com/venta/api/apiTranspasosObtener.php?SucursalNombre=" +
                                Uri.EscapeDataString(datos.Nombre);

                using (HttpClient client = new HttpClient())
                {
                    // Realizar la solicitud GET a la API
                    var response = await client.GetStringAsync(apiUrl);

                    // Deserializar el JSON a una lista de objetos Transpasos
                    var traspasos = JsonConvert.DeserializeObject<List<Transpasos>>(response);

                    // Crear instancia de CN__Transpaso para manejar el almacenamiento
                    CN__Transpaso cnTranspaso = new CN__Transpaso();
                    foreach (var transpaso in traspasos)
                    {
                        // Verificar si el traspaso ya existe
                        if (cnTranspaso.ExisteTranspaso(transpaso.idStokSucursal.ToString()))
                        {
                            continue; // Saltar a la siguiente iteración
                        }

                        // Variable para capturar mensajes de error
                        string mensaje;

                        // Registrar el transpaso en la base de datos
                        if (cnTranspaso.RegistrarTranspaso(transpaso, out mensaje) == 0)
                        {
                            MessageBox.Show($"Error al procesar el traspaso: {mensaje}");
                        }
                    }
                }

                MessageBox.Show("Datos de traspasos actualizados exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void CargarTranspasos()
        {
            CN__Transpaso objTranspasos = new CN__Transpaso();
            DataTable dtTranspasos = objTranspasos.ListarTranspasos();

            if (dtTranspasos.Rows.Count > 0)
            {
                dgvdataP.DataSource = dtTranspasos; // Asigna los datos al DataGridView
            }
            else
            {
                MessageBox.Show("No hay transpasos para mostrar.");
            }
        }

        private void dgvdataP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si se ha hecho clic en una fila válida
            if (e.RowIndex >= 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow row = dgvdataP.Rows[e.RowIndex];

                // Asigna el valor de idStokSucursal al TextBox
                txtidStokSucursal.Text = row.Cells["idStokSucursal"].Value.ToString();
                txtNombreProd.Text = row.Cells["NombreProducto"].Value.ToString();
            }
        }

        private void frmDetalleCompra_Load(object sender, EventArgs e)
        {
            // Cargar datos si es necesario al cargar el formulario
        }
    }
}
