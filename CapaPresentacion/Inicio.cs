using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using FontAwesome.Sharp;

using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using MySqlX.XDevAPI;
using System.Net.Http;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DocumentFormat.OpenXml.Drawing.Charts;


namespace CapaPresentacion
{
    public partial class Inicio : Form
    {

        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;


        public Inicio(Usuario objusuario = null)
        {
    
            if (objusuario == null)
                usuarioActual = new Usuario() { NombreCompleto = "ADMIN PREDEFINIDO", IdUsuario = 1 };
            else
                usuarioActual = objusuario;

            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);
            
            

            foreach (IconMenuItem iconmenu in menu.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconmenu.Name);
                iconmenu.Visible = encontrado;
            }
            lblusuario.Text = usuarioActual.NombreCompleto.ToString();

            ActualizarProductosDesdeNuevaApi();
            ActualizarClientes();

        }



        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {

            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;

            contenedor.Controls.Add(formulario);
            formulario.Show();


        }


        private void menuusuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }

        private void submenucategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new frmCategoria());
        }

        private void submenuproducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new frmProducto());
        }

        private void submenuregistrarventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmVentas(usuarioActual));
        }

        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmDetalleVenta());
        }

        private void submenuregistrarcompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmCompras(usuarioActual));
        }

        private void submenutverdetallecompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmDetalleCompra());
        }

        private void menuclientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void menuproveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedores());
        }





        private void submenunegocio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new frmNegocio());
        }

        private void submenureportecompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menureportes, new frmReporteCompras());
        }

        private void submenureporteventas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menureportes, new frmReporteVentas());
        }

        private void menuacercade_Click(object sender, EventArgs e)
        {
            mdAcercade md = new mdAcercade();
            md.ShowDialog();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { 
                this.Close();
            }
        }
        private async void btnActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                ActualizarProductosDesdeNuevaApi();//p
                await ActualizarProductos();//p
                await ActualizarClientes();
                await obtenercategoria();
            }
            catch (HttpRequestException httpRequestException)
            {
                MessageBox.Show("Error al obtener los datos de la API: " + httpRequestException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ActualizarProductos()
        {

            Negocio datos = new CN_Negocio().ObtenerDatos();
            string apiUrl = "https://software.bigcluboutlet.com/venta/apiProductos.php?SucursalNombre=" +
                             Uri.EscapeDataString(datos.Nombre) + "&password=9v67XodGxtE3Dd8X6wf8iYZP8o7zupnOf77wFXCNMpzHIf2ctr";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // Verifica si la respuesta contiene un mensaje de error
                if (responseBody.Contains("No se encontraron productos para la sucursal especificada"))
                {
                   // MessageBox.Show("No se encontraron productos para la sucursal especificada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<Producto> productos = JsonConvert.DeserializeObject<List<Producto>>(responseBody);
                if (productos == null || productos.Count == 0)
                {
                    MessageBox.Show("No se encontraron productos en la API.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dgvdata.Rows.Clear(); // Limpia los datos existentes en el DataGridView

                foreach (var producto in productos)
                {
                    if (producto == null) continue;

                    dgvdata.Rows.Add(new object[]
                    {
                producto.IdProducto,
                producto.Codigo ?? "Sin código",
                producto.Nombre ?? "Sin nombre",
                producto.Descripcion ?? "Sin descripción",
                producto.oCategoria?.IdCategoria ?? 1,
                producto.Stock,
                producto.PrecioVenta,
                producto.Estado ? "Activo" : "Inactivo"
                    });

                    string mensaje;
                    try
                    {
                        bool resultado = new CN__Producto().ActualizarStock(producto, out mensaje);
                        if (!resultado)
                        {
                            MessageBox.Show($"Error al actualizar el stock del producto {producto.Nombre}: {mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al procesar el producto {producto.Nombre}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private readonly CN_Categoria _cnCategoria = new CN_Categoria();

        private static readonly HttpClient client = new HttpClient();

        private async Task obtenercategoria()
        {
            try
            {
                // Llamar a la API para obtener categorías
                string apiUrl = "https://software.bigcluboutlet.com/venta/api/mandarcategoria.php"; // URL de tu API
                var response = await client.GetStringAsync(apiUrl);

                // Deserializar el JSON en una lista de categorías
                List<Categoria> categoriasApi = JsonConvert.DeserializeObject<List<Categoria>>(response);

                // Obtener todas las categorías existentes en la base de datos local
                List<Categoria> categoriasExistentes = _cnCategoria.ObtenerTodas(); // Asegúrate de que este método esté implementado

                // Filtrar las categorías que no existen en la base de datos
                var categoriasNuevas = categoriasApi
                    .Where(c => !categoriasExistentes.Any(ce => ce.Descripcion.Equals(c.Descripcion, StringComparison.OrdinalIgnoreCase))) // Comparar por nombre
                    .ToList();

                // Registrar las nuevas categorías desde el JSON
                foreach (var categoriaApi in categoriasNuevas)
                {
                    string mensaje;
                    var resultado = _cnCategoria.Registrar(categoriaApi, out mensaje);
                    if (resultado == 0)
                    {
                        //MessageBox.Show($"Error al registrar categoría: {mensaje}");
                    }
                }

                if (categoriasNuevas.Any())
                {
                    //MessageBox.Show($"{categoriasNuevas.Count} categorías han sido registradas.");
                }
                else
                {
                    //MessageBox.Show("No hay nuevas categorías para registrar.");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error al obtener categorías: {ex.Message}");
            }
        }









        public class ProductoResponse
        {
            public List<ProductoApi> productos { get; set; }
        }

        public class ProductoApi
        {
            public int IdProducto { get; set; }
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public string PrecioCompra { get; set; }
            public string PrecioVenta { get; set; }
            public int Estado { get; set; }
            public int Stock { get; set; } // Debe ser int
            public string ProductoNombre { get; set; }
        }

        private async Task ActualizarProductosDesdeNuevaApi()
        {
            Negocio datos = new CN_Negocio().ObtenerDatos();
            string apiUrl = "https://software.bigcluboutlet.com/venta/api/obtenerproductostokcaja.php?sucursal=" + Uri.EscapeDataString(datos.Nombre) + "&password=hNIt42p4t11lwGz6frhX1suALFfflKOA272AIPDTKNJNvXg9pt";



            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    // Verifica si la respuesta JSON no está vacía
                    if (string.IsNullOrEmpty(jsonResponse))
                    {
                        MessageBox.Show("La respuesta de la API está vacía.");
                        return;
                    }

                    // Deserializa la respuesta
                    var productosResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductoResponse>(jsonResponse);

                    // Verifica si productosResponse o productos son nulos
                    if (productosResponse?.productos == null)
                    {
                        MessageBox.Show("No se encontraron productos en la respuesta de la API.");
                        return;
                    }

                    foreach (var producto1 in productosResponse.productos)
                    {
                        // Crear un nuevo objeto Producto
                        Producto nuevoProducto = new Producto
                        {
                            IdProducto = producto1.IdProducto,
                            Codigo = string.IsNullOrEmpty(producto1.Codigo) ? null : producto1.Codigo, // Permite null para Código
                            Nombre = producto1.Nombre,
                            Descripcion = producto1.Descripcion,
                            PrecioCompra = Convert.ToDecimal(producto1.PrecioCompra),
                            PrecioVenta = Convert.ToDecimal(producto1.PrecioVenta),
                            Estado = producto1.Estado == 1, // Convertir a bool
                            Stock = producto1.Stock // Asegúrate de que el campo 'stock' está en minúsculas
                        };

                        // Verifica si el producto ya existe por Código y actualiza el stock
                        bool resultado = new CN__Producto().ActualizarStockN(nuevoProducto, out string mensaje);
                        if (!resultado)
                        {
                            MessageBox.Show($"Error al actualizar el producto {nuevoProducto.Nombre}: {mensaje}");
                        }
                    }
                    MessageBox.Show("Actualizado con exito");

                }
                catch (HttpRequestException httpEx)
                {
                    MessageBox.Show($"Error de conexión con la API: {httpEx.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al obtener productos de la API: {ex.Message}");
                }
            }
        }










        private async Task ActualizarClientes()
        {
            string apiUrlClient = "https://software.bigcluboutlet.com/venta/api/mandarclientes.php?password=7BqEWB3qLt7bFwAGOf1au5gYfFh43LmvyDO3HgWcQkZPPUZohQ";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage responseClient = await client.GetAsync(apiUrlClient);
                responseClient.EnsureSuccessStatusCode();
                string responseBodyClient = await responseClient.Content.ReadAsStringAsync();

                List<Cliente> clientes = JsonConvert.DeserializeObject<List<Cliente>>(responseBodyClient);
                if (clientes == null || clientes.Count == 0)
                {
                    MessageBox.Show("No se encontraron clientes en la API.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (var cliente in clientes)
                {
                    if (cliente == null) continue;

                    // Agregar al DataGridView
                    dgvdata.Rows.Add(new object[]
                    {
                cliente.IdCliente,
                cliente.Documento ?? "Sin código",
                cliente.NombreCompleto ?? "Sin nombre",
                cliente.Correo ?? "Sin descripción",
                cliente.Telefono ?? "0",
                cliente.Estado,
                cliente.FechaRegistro,
                cliente.Puntos ?? "0" // Asegúrate de que sea un string
                    });

                    string mensaje;
                    try
                    {
                        // Cambia la llamada aquí
                        int resultado = new CN_Cliente().RegistrarC(cliente, out mensaje);
                        if (resultado <= 0) // Verifica si no se registró
                        {
                            // Opcional: muestra un mensaje en caso de error
                            // MessageBox.Show($"Error al actualizar el cliente {cliente.NombreCompleto}: {mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Opcional: maneja la excepción
                        // MessageBox.Show($"Error al procesar el cliente {cliente.NombreCompleto}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }





        private void lblusuario_Click(object sender, EventArgs e)
        {

        }

        private void btnTranspaso_Click(object sender, EventArgs e)
        {
            // Obtener los datos de la sucursal actual
            Negocio datos = new CN_Negocio().ObtenerDatos();
            //MessageBox.Show("Sucursal: " + datos.Nombre, "Bienvenido a Big Club");

            lblusuario.Text = usuarioActual.NombreCompleto;

            // Obtener todos los productos de la base de datos local
            List<Producto> productosLocales = new CN__Producto().Listar();

            // Enviar todos los productos a la nube
            // Crear una instancia del formulario que deseas abrir
            Form nombreDelFormulario = new transpasos(); // Reemplaza con el nombre de tu formulario

            // Mostrar el formulario
            nombreDelFormulario.Show(); // Usa Show() para abrirlo de manera no modal
                                        // nombreDelFormulario.ShowDialog(); // Usa ShowDialog() si quieres que sea modal
            ActualizarProductosDesdeNuevaApi();
        }

        private void menutitulo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
