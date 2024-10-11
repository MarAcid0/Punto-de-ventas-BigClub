namespace CapaPresentacion
{
    partial class frmCompras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.dgProducto = new System.Windows.Forms.DataGridView();
            this.dgSucursal = new System.Windows.Forms.DataGridView();
            this.IdSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFactura = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtSelecSucursal = new System.Windows.Forms.TextBox();
            this.txtSelecProducto = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSucursal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-2, 1);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(1709, 791);
            this.label10.TabIndex = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 29);
            this.label2.TabIndex = 195;
            this.label2.Text = "Registrar Transpasos";
            // 
            // txtSucursal
            // 
            this.txtSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSucursal.Location = new System.Drawing.Point(18, 148);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(246, 30);
            this.txtSucursal.TabIndex = 196;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 198;
            this.label3.Text = "Sucursal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 199;
            this.label1.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(12, 236);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(246, 30);
            this.txtProducto.TabIndex = 200;
            // 
            // dgProducto
            // 
            this.dgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducto.Location = new System.Drawing.Point(676, 12);
            this.dgProducto.Name = "dgProducto";
            this.dgProducto.RowHeadersWidth = 51;
            this.dgProducto.RowTemplate.Height = 24;
            this.dgProducto.Size = new System.Drawing.Size(431, 608);
            this.dgProducto.TabIndex = 201;
            // 
            // dgSucursal
            // 
            this.dgSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSucursal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSucursal,
            this.Nombre,
            this.Direccion,
            this.Telefono});
            this.dgSucursal.Location = new System.Drawing.Point(274, 12);
            this.dgSucursal.Name = "dgSucursal";
            this.dgSucursal.RowHeadersWidth = 51;
            this.dgSucursal.RowTemplate.Height = 24;
            this.dgSucursal.Size = new System.Drawing.Size(396, 608);
            this.dgSucursal.TabIndex = 202;
            this.dgSucursal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSucursal_CellClick);
            // 
            // IdSucursal
            // 
            this.IdSucursal.HeaderText = "IdSucursal";
            this.IdSucursal.MinimumWidth = 6;
            this.IdSucursal.Name = "IdSucursal";
            this.IdSucursal.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 125;
            // 
            // dgFactura
            // 
            this.dgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFactura.Location = new System.Drawing.Point(1113, 12);
            this.dgFactura.Name = "dgFactura";
            this.dgFactura.RowHeadersWidth = 51;
            this.dgFactura.RowTemplate.Height = 24;
            this.dgFactura.Size = new System.Drawing.Size(594, 608);
            this.dgFactura.TabIndex = 203;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(43, 294);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(148, 60);
            this.btnBuscar.TabIndex = 204;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtSelecSucursal
            // 
            this.txtSelecSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelecSucursal.Location = new System.Drawing.Point(18, 376);
            this.txtSelecSucursal.Name = "txtSelecSucursal";
            this.txtSelecSucursal.Size = new System.Drawing.Size(246, 30);
            this.txtSelecSucursal.TabIndex = 205;
            // 
            // txtSelecProducto
            // 
            this.txtSelecProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelecProducto.Location = new System.Drawing.Point(18, 412);
            this.txtSelecProducto.Name = "txtSelecProducto";
            this.txtSelecProducto.Size = new System.Drawing.Size(246, 30);
            this.txtSelecProducto.TabIndex = 206;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(44, 520);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(148, 60);
            this.btnAgregar.TabIndex = 207;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(19, 484);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(246, 30);
            this.txtCantidad.TabIndex = 208;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 456);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 209;
            this.label4.Text = "Cantidad";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(1113, 626);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(581, 152);
            this.btnEnviar.TabIndex = 210;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1706, 790);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtSelecProducto);
            this.Controls.Add(this.txtSelecSucursal);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgFactura);
            this.Controls.Add(this.dgSucursal);
            this.Controls.Add(this.dgProducto);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSucursal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCompras";
            this.Text = "frmCompras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSucursal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.DataGridView dgProducto;
        private System.Windows.Forms.DataGridView dgSucursal;
        private System.Windows.Forms.DataGridView dgFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtSelecSucursal;
        private System.Windows.Forms.TextBox txtSelecProducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnviar;
    }
}