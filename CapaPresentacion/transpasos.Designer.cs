namespace CapaPresentacion
{
    partial class transpasos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.txtProductos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgSucursal = new System.Windows.Forms.DataGridView();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IdSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTransSuc = new System.Windows.Forms.TextBox();
            this.txtTransProducto = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSucursal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transpasos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "A que Sucursal";
            // 
            // txtSucursal
            // 
            this.txtSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSucursal.Location = new System.Drawing.Point(57, 182);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(219, 30);
            this.txtSucursal.TabIndex = 2;
            // 
            // txtProductos
            // 
            this.txtProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductos.Location = new System.Drawing.Point(57, 253);
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.Size = new System.Drawing.Size(219, 30);
            this.txtProductos.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Que transpasas";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(65, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgSucursal
            // 
            this.dgSucursal.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSucursal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSucursal,
            this.Nombre,
            this.Direccion,
            this.Telefono});
            this.dgSucursal.GridColor = System.Drawing.SystemColors.Control;
            this.dgSucursal.Location = new System.Drawing.Point(455, 55);
            this.dgSucursal.Name = "dgSucursal";
            this.dgSucursal.RowHeadersWidth = 51;
            this.dgSucursal.RowTemplate.Height = 24;
            this.dgSucursal.Size = new System.Drawing.Size(718, 769);
            this.dgSucursal.TabIndex = 6;
            this.dgSucursal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSucursal_CellClick);
            // 
            // dgProductos
            // 
            this.dgProductos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgProductos.Location = new System.Drawing.Point(1179, 55);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.RowHeadersWidth = 51;
            this.dgProductos.RowTemplate.Height = 24;
            this.dgProductos.Size = new System.Drawing.Size(709, 769);
            this.dgProductos.TabIndex = 7;
            this.dgProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sucursal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1174, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Producto";
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
            // txtTransSuc
            // 
            this.txtTransSuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransSuc.Location = new System.Drawing.Point(65, 470);
            this.txtTransSuc.Name = "txtTransSuc";
            this.txtTransSuc.ReadOnly = true;
            this.txtTransSuc.Size = new System.Drawing.Size(219, 30);
            this.txtTransSuc.TabIndex = 10;
            // 
            // txtTransProducto
            // 
            this.txtTransProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransProducto.Location = new System.Drawing.Point(65, 561);
            this.txtTransProducto.Name = "txtTransProducto";
            this.txtTransProducto.ReadOnly = true;
            this.txtTransProducto.Size = new System.Drawing.Size(219, 30);
            this.txtTransProducto.TabIndex = 11;
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(60, 643);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(219, 30);
            this.txtStock.TabIndex = 12;
            this.txtStock.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sucursal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 522);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 31);
            this.label7.TabIndex = 14;
            this.label7.Text = "Producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 605);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 31);
            this.label8.TabIndex = 15;
            this.label8.Text = "Piezas";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Teal;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEnviar.Location = new System.Drawing.Point(65, 692);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(194, 47);
            this.btnEnviar.TabIndex = 16;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // transpasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 836);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtTransProducto);
            this.Controls.Add(this.txtTransSuc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.dgSucursal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtProductos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSucursal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "transpasos";
            this.Text = "reembolso";
            this.Load += new System.EventHandler(this.reembolso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSucursal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.TextBox txtProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgSucursal;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.TextBox txtTransSuc;
        private System.Windows.Forms.TextBox txtTransProducto;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEnviar;
    }
}