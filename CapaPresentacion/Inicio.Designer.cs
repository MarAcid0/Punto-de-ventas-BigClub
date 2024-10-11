namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuusuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menumantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.submenucategoria = new FontAwesome.Sharp.IconMenuItem();
            this.submenuproducto = new FontAwesome.Sharp.IconMenuItem();
            this.submenunegocio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuventas = new FontAwesome.Sharp.IconMenuItem();
            this.submenuregistrarventa = new FontAwesome.Sharp.IconMenuItem();
            this.submenuverdetalleventa = new FontAwesome.Sharp.IconMenuItem();
            this.menucompras = new FontAwesome.Sharp.IconMenuItem();
            this.submenuregistrarcompra = new FontAwesome.Sharp.IconMenuItem();
            this.submenutverdetallecompra = new FontAwesome.Sharp.IconMenuItem();
            this.menuclientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuproveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menureportes = new FontAwesome.Sharp.IconMenuItem();
            this.submenureportecompras = new System.Windows.Forms.ToolStripMenuItem();
            this.submenureporteventas = new System.Windows.Forms.ToolStripMenuItem();
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.btnsalir = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.menu.SuspendLayout();
            this.contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusuarios,
            this.menumantenedor,
            this.menuventas,
            this.menucompras,
            this.menuclientes,
            this.menuproveedores,
            this.menureportes});
            this.menu.Location = new System.Drawing.Point(0, 81);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1913, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuusuarios
            // 
            this.menuusuarios.AutoSize = false;
            this.menuusuarios.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.menuusuarios.IconColor = System.Drawing.Color.Black;
            this.menuusuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuusuarios.IconSize = 50;
            this.menuusuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuusuarios.Name = "menuusuarios";
            this.menuusuarios.Size = new System.Drawing.Size(100, 69);
            this.menuusuarios.Text = "Usuarios";
            this.menuusuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuusuarios.Click += new System.EventHandler(this.menuusuarios_Click);
            // 
            // menumantenedor
            // 
            this.menumantenedor.AutoSize = false;
            this.menumantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenucategoria,
            this.submenuproducto,
            this.submenunegocio});
            this.menumantenedor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menumantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.menumantenedor.IconColor = System.Drawing.Color.Black;
            this.menumantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menumantenedor.IconSize = 50;
            this.menumantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menumantenedor.Name = "menumantenedor";
            this.menumantenedor.Size = new System.Drawing.Size(130, 69);
            this.menumantenedor.Text = "Mantenedor";
            this.menumantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenucategoria
            // 
            this.submenucategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenucategoria.IconColor = System.Drawing.Color.Black;
            this.submenucategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenucategoria.Name = "submenucategoria";
            this.submenucategoria.Size = new System.Drawing.Size(157, 26);
            this.submenucategoria.Text = "Categoria";
            this.submenucategoria.Click += new System.EventHandler(this.submenucategoria_Click);
            // 
            // submenuproducto
            // 
            this.submenuproducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuproducto.IconColor = System.Drawing.Color.Black;
            this.submenuproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuproducto.Name = "submenuproducto";
            this.submenuproducto.Size = new System.Drawing.Size(157, 26);
            this.submenuproducto.Text = "Producto";
            this.submenuproducto.Click += new System.EventHandler(this.submenuproducto_Click);
            // 
            // submenunegocio
            // 
            this.submenunegocio.Name = "submenunegocio";
            this.submenunegocio.Size = new System.Drawing.Size(157, 26);
            this.submenunegocio.Text = "Negocio";
            this.submenunegocio.Click += new System.EventHandler(this.submenunegocio_Click);
            // 
            // menuventas
            // 
            this.menuventas.AutoSize = false;
            this.menuventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuregistrarventa,
            this.submenuverdetalleventa});
            this.menuventas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menuventas.IconColor = System.Drawing.Color.Black;
            this.menuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuventas.IconSize = 50;
            this.menuventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuventas.Name = "menuventas";
            this.menuventas.Size = new System.Drawing.Size(152, 69);
            this.menuventas.Text = "Ventas";
            this.menuventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuregistrarventa
            // 
            this.submenuregistrarventa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuregistrarventa.IconColor = System.Drawing.Color.Black;
            this.submenuregistrarventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuregistrarventa.Name = "submenuregistrarventa";
            this.submenuregistrarventa.Size = new System.Drawing.Size(165, 26);
            this.submenuregistrarventa.Text = "Registrar";
            this.submenuregistrarventa.Click += new System.EventHandler(this.submenuregistrarventa_Click);
            // 
            // submenuverdetalleventa
            // 
            this.submenuverdetalleventa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuverdetalleventa.IconColor = System.Drawing.Color.Black;
            this.submenuverdetalleventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuverdetalleventa.Name = "submenuverdetalleventa";
            this.submenuverdetalleventa.Size = new System.Drawing.Size(165, 26);
            this.submenuverdetalleventa.Text = "Ver Detalle";
            this.submenuverdetalleventa.Click += new System.EventHandler(this.submenuverdetalleventa_Click);
            // 
            // menucompras
            // 
            this.menucompras.AutoSize = false;
            this.menucompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuregistrarcompra,
            this.submenutverdetallecompra});
            this.menucompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.menucompras.IconColor = System.Drawing.Color.Black;
            this.menucompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menucompras.IconSize = 50;
            this.menucompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucompras.Name = "menucompras";
            this.menucompras.Size = new System.Drawing.Size(100, 69);
            this.menucompras.Text = "Transpasos";
            this.menucompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuregistrarcompra
            // 
            this.submenuregistrarcompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuregistrarcompra.IconColor = System.Drawing.Color.Black;
            this.submenuregistrarcompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuregistrarcompra.Name = "submenuregistrarcompra";
            this.submenuregistrarcompra.Size = new System.Drawing.Size(165, 26);
            this.submenuregistrarcompra.Text = "Registrar";
            this.submenuregistrarcompra.Click += new System.EventHandler(this.submenuregistrarcompra_Click);
            // 
            // submenutverdetallecompra
            // 
            this.submenutverdetallecompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenutverdetallecompra.IconColor = System.Drawing.Color.Black;
            this.submenutverdetallecompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenutverdetallecompra.Name = "submenutverdetallecompra";
            this.submenutverdetallecompra.Size = new System.Drawing.Size(165, 26);
            this.submenutverdetallecompra.Text = "Ver Detalle";
            this.submenutverdetallecompra.Click += new System.EventHandler(this.submenutverdetallecompra_Click);
            // 
            // menuclientes
            // 
            this.menuclientes.AutoSize = false;
            this.menuclientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.menuclientes.IconColor = System.Drawing.Color.Black;
            this.menuclientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuclientes.IconSize = 50;
            this.menuclientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuclientes.Name = "menuclientes";
            this.menuclientes.Size = new System.Drawing.Size(100, 69);
            this.menuclientes.Text = "Clientes";
            this.menuclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuclientes.Click += new System.EventHandler(this.menuclientes_Click);
            // 
            // menuproveedores
            // 
            this.menuproveedores.AutoSize = false;
            this.menuproveedores.Enabled = false;
            this.menuproveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menuproveedores.IconColor = System.Drawing.Color.Black;
            this.menuproveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuproveedores.IconSize = 50;
            this.menuproveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuproveedores.Name = "menuproveedores";
            this.menuproveedores.Size = new System.Drawing.Size(130, 69);
            this.menuproveedores.Text = "Proveedores";
            this.menuproveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuproveedores.Visible = false;
            this.menuproveedores.Click += new System.EventHandler(this.menuproveedores_Click);
            // 
            // menureportes
            // 
            this.menureportes.AutoSize = false;
            this.menureportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenureportecompras,
            this.submenureporteventas});
            this.menureportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.menureportes.IconColor = System.Drawing.Color.Black;
            this.menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menureportes.IconSize = 50;
            this.menureportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureportes.Name = "menureportes";
            this.menureportes.Size = new System.Drawing.Size(100, 69);
            this.menureportes.Text = "Reportes";
            this.menureportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenureportecompras
            // 
            this.submenureportecompras.Name = "submenureportecompras";
            this.submenureportecompras.Size = new System.Drawing.Size(208, 26);
            this.submenureportecompras.Text = "Reporte Compras";
            this.submenureportecompras.Click += new System.EventHandler(this.submenureportecompras_Click);
            // 
            // submenureporteventas
            // 
            this.submenureporteventas.Name = "submenureporteventas";
            this.submenureporteventas.Size = new System.Drawing.Size(208, 26);
            this.submenureporteventas.Text = "Reporte Ventas";
            this.submenureporteventas.Click += new System.EventHandler(this.submenureporteventas_Click);
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menutitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(1913, 81);
            this.menutitulo.TabIndex = 1;
            this.menutitulo.Text = "menuStrip2";
            this.menutitulo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menutitulo_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Ventas";
            // 
            // contenedor
            // 
            this.contenedor.Controls.Add(this.dgvdata);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 154);
            this.contenedor.Margin = new System.Windows.Forms.Padding(4);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1913, 901);
            this.contenedor.TabIndex = 3;
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.Categoria,
            this.Stock,
            this.Precio,
            this.PrecioVenta,
            this.Estado});
            this.dgvdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdata.Location = new System.Drawing.Point(0, 0);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.RowHeadersWidth = 51;
            this.dgvdata.RowTemplate.Height = 24;
            this.dgvdata.Size = new System.Drawing.Size(1913, 901);
            this.dgvdata.TabIndex = 0;
            this.dgvdata.Visible = false;
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.MinimumWidth = 6;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Width = 125;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "oCategoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 125;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "PrecioVenta";
            this.PrecioVenta.MinimumWidth = 6;
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1098, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.SteelBlue;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.White;
            this.lblusuario.Location = new System.Drawing.Point(1185, 38);
            this.lblusuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(71, 18);
            this.lblusuario.TabIndex = 5;
            this.lblusuario.Text = "lblusuario";
            this.lblusuario.Click += new System.EventHandler(this.lblusuario_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.SteelBlue;
            this.btnsalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnsalir.IconColor = System.Drawing.Color.White;
            this.btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsalir.IconSize = 52;
            this.btnsalir.Location = new System.Drawing.Point(1448, 10);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.btnsalir.Size = new System.Drawing.Size(79, 63);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.LogoCanal;
            this.pictureBox1.Location = new System.Drawing.Point(1448, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(1188, 79);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(339, 75);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar Datos";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1913, 1055);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BigClubSoftware";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuusuarios;
        private FontAwesome.Sharp.IconMenuItem menumantenedor;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem menucompras;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private FontAwesome.Sharp.IconMenuItem menuproveedores;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private System.Windows.Forms.MenuStrip menutitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblusuario;
        private FontAwesome.Sharp.IconMenuItem submenucategoria;
        private FontAwesome.Sharp.IconMenuItem submenuproducto;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarventa;
        private FontAwesome.Sharp.IconMenuItem submenuverdetalleventa;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarcompra;
        private FontAwesome.Sharp.IconMenuItem submenutverdetallecompra;
        private System.Windows.Forms.ToolStripMenuItem submenunegocio;
        private System.Windows.Forms.ToolStripMenuItem submenureportecompras;
        private System.Windows.Forms.ToolStripMenuItem submenureporteventas;
        private FontAwesome.Sharp.IconButton btnsalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvdata;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}

