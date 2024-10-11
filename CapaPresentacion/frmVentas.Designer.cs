namespace CapaPresentacion
{
    partial class frmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbotipodocumento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtClientePuntos = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtdocumentocliente = new System.Windows.Forms.TextBox();
            this.btnbuscarcliente = new FontAwesome.Sharp.IconButton();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtprecioInicial = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            this.txtcodproducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnagregarproducto = new FontAwesome.Sharp.IconButton();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcambio = new System.Windows.Forms.TextBox();
            this.txtpagocon = new System.Windows.Forms.TextBox();
            this.txttotalpagar = new System.Windows.Forms.TextBox();
            this.btncrearventa = new FontAwesome.Sharp.IconButton();
            this.lblDolar = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbMetodo = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbPorcentaje = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label22 = new System.Windows.Forms.Label();
            this.lblTotalEnDolar = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtPagoDolar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-1, -1);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(1919, 886);
            this.label10.TabIndex = 96;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 54);
            this.label2.TabIndex = 196;
            this.label2.Text = "Registrar Venta";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtfecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbotipodocumento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(900, 140);
            this.groupBox1.TabIndex = 197;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Venta";
            // 
            // txtfecha
            // 
            this.txtfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha.Location = new System.Drawing.Point(7, 80);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.ReadOnly = true;
            this.txtfecha.Size = new System.Drawing.Size(335, 38);
            this.txtfecha.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 31);
            this.label3.TabIndex = 89;
            this.label3.Text = "Fecha:";
            // 
            // cbotipodocumento
            // 
            this.cbotipodocumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbotipodocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipodocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipodocumento.FormattingEnabled = true;
            this.cbotipodocumento.Location = new System.Drawing.Point(506, 80);
            this.cbotipodocumento.Margin = new System.Windows.Forms.Padding(4);
            this.cbotipodocumento.Name = "cbotipodocumento";
            this.cbotipodocumento.Size = new System.Drawing.Size(359, 39);
            this.cbotipodocumento.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(507, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 31);
            this.label4.TabIndex = 91;
            this.label4.Text = "Tipo Documento:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txtClientePuntos);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtdocumentocliente);
            this.groupBox2.Controls.Add(this.btnbuscarcliente);
            this.groupBox2.Controls.Add(this.txtnombrecliente);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(912, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(771, 201);
            this.groupBox2.TabIndex = 198;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Cliente";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(158, 146);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(107, 31);
            this.label21.TabIndex = 89;
            this.label21.Text = "Puntos:";
            // 
            // txtClientePuntos
            // 
            this.txtClientePuntos.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientePuntos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtClientePuntos.Location = new System.Drawing.Point(316, 141);
            this.txtClientePuntos.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientePuntos.Name = "txtClientePuntos";
            this.txtClientePuntos.ReadOnly = true;
            this.txtClientePuntos.Size = new System.Drawing.Size(195, 45);
            this.txtClientePuntos.TabIndex = 88;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 32);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(264, 31);
            this.label14.TabIndex = 84;
            this.label14.Text = "Número Documento:";
            // 
            // txtdocumentocliente
            // 
            this.txtdocumentocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocumentocliente.Location = new System.Drawing.Point(16, 77);
            this.txtdocumentocliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtdocumentocliente.Name = "txtdocumentocliente";
            this.txtdocumentocliente.Size = new System.Drawing.Size(271, 38);
            this.txtdocumentocliente.TabIndex = 85;
            // 
            // btnbuscarcliente
            // 
            this.btnbuscarcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarcliente.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscarcliente.IconColor = System.Drawing.Color.Black;
            this.btnbuscarcliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarcliente.IconSize = 18;
            this.btnbuscarcliente.Location = new System.Drawing.Point(337, 32);
            this.btnbuscarcliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuscarcliente.Name = "btnbuscarcliente";
            this.btnbuscarcliente.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnbuscarcliente.Size = new System.Drawing.Size(107, 82);
            this.btnbuscarcliente.TabIndex = 87;
            this.btnbuscarcliente.UseVisualStyleBackColor = true;
            this.btnbuscarcliente.Click += new System.EventHandler(this.btnbuscarcliente_Click);
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrecliente.Location = new System.Drawing.Point(452, 80);
            this.txtnombrecliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(295, 38);
            this.txtnombrecliente.TabIndex = 86;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(446, 45);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(241, 31);
            this.label15.TabIndex = 83;
            this.label15.Text = "Nombre Completo:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txtprecioInicial);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.txtidproducto);
            this.groupBox3.Controls.Add(this.btnbuscarproducto);
            this.groupBox3.Controls.Add(this.txtcodproducto);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtproducto);
            this.groupBox3.Controls.Add(this.txtcantidad);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtstock);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtprecio);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(4, 221);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1236, 97);
            this.groupBox3.TabIndex = 199;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion de Producto";
            // 
            // txtprecioInicial
            // 
            this.txtprecioInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecioInicial.Location = new System.Drawing.Point(758, 55);
            this.txtprecioInicial.Margin = new System.Windows.Forms.Padding(4);
            this.txtprecioInicial.Name = "txtprecioInicial";
            this.txtprecioInicial.ReadOnly = true;
            this.txtprecioInicial.Size = new System.Drawing.Size(103, 30);
            this.txtprecioInicial.TabIndex = 227;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(942, 18);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(30, 25);
            this.label23.TabIndex = 226;
            this.label23.Text = "%";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25"});
            this.comboBox1.Location = new System.Drawing.Point(842, 16);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 33);
            this.comboBox1.TabIndex = 225;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(226, 16);
            this.txtidproducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.ReadOnly = true;
            this.txtidproducto.Size = new System.Drawing.Size(41, 22);
            this.txtidproducto.TabIndex = 0;
            this.txtidproducto.Visible = false;
            // 
            // btnbuscarproducto
            // 
            this.btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscarproducto.IconColor = System.Drawing.Color.Black;
            this.btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarproducto.IconSize = 18;
            this.btnbuscarproducto.Location = new System.Drawing.Point(302, 25);
            this.btnbuscarproducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuscarproducto.Name = "btnbuscarproducto";
            this.btnbuscarproducto.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnbuscarproducto.Size = new System.Drawing.Size(131, 60);
            this.btnbuscarproducto.TabIndex = 2;
            this.btnbuscarproducto.UseVisualStyleBackColor = true;
            this.btnbuscarproducto.Click += new System.EventHandler(this.btnbuscarproducto_Click);
            // 
            // txtcodproducto
            // 
            this.txtcodproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodproducto.Location = new System.Drawing.Point(11, 51);
            this.txtcodproducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodproducto.Name = "txtcodproducto";
            this.txtcodproducto.Size = new System.Drawing.Size(256, 30);
            this.txtcodproducto.TabIndex = 1;
            this.txtcodproducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodproducto_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 19);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 25);
            this.label9.TabIndex = 96;
            this.label9.Text = "Cod. Producto:";
            // 
            // txtproducto
            // 
            this.txtproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproducto.Location = new System.Drawing.Point(468, 51);
            this.txtproducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.ReadOnly = true;
            this.txtproducto.Size = new System.Drawing.Size(259, 30);
            this.txtproducto.TabIndex = 3;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(1119, 58);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtcantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtcantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(104, 30);
            this.txtcantidad.TabIndex = 6;
            this.txtcantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1115, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 98;
            this.label5.Text = "Cantidad:";
            // 
            // txtstock
            // 
            this.txtstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstock.Location = new System.Drawing.Point(1006, 54);
            this.txtstock.Margin = new System.Windows.Forms.Padding(4);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(103, 30);
            this.txtstock.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(474, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 97;
            this.label8.Text = "Producto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1002, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 100;
            this.label7.Text = "Stock:";
            // 
            // txtprecio
            // 
            this.txtprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(869, 55);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(103, 30);
            this.txtprecio.TabIndex = 4;
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(733, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 99;
            this.label6.Text = "Precio:";
            // 
            // btnagregarproducto
            // 
            this.btnagregarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregarproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarproducto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnagregarproducto.IconColor = System.Drawing.Color.ForestGreen;
            this.btnagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnagregarproducto.IconSize = 30;
            this.btnagregarproducto.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregarproducto.Location = new System.Drawing.Point(1248, 221);
            this.btnagregarproducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnagregarproducto.Name = "btnagregarproducto";
            this.btnagregarproducto.Size = new System.Drawing.Size(321, 154);
            this.btnagregarproducto.TabIndex = 200;
            this.btnagregarproducto.Text = "Agregar";
            this.btnagregarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnagregarproducto.UseVisualStyleBackColor = true;
            this.btnagregarproducto.Click += new System.EventHandler(this.btnagregarproducto_Click);
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.SubTotal,
            this.btneliminar});
            this.dgvdata.Location = new System.Drawing.Point(4, 325);
            this.dgvdata.Margin = new System.Windows.Forms.Padding(4);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(1084, 545);
            this.dgvdata.TabIndex = 201;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.editarCantidad);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.MinimumWidth = 6;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Visible = false;
            this.IdProducto.Width = 150;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.Width = 200;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 130;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SubTotal.Width = 125;
            // 
            // btneliminar
            // 
            this.btneliminar.HeaderText = "";
            this.btneliminar.MinimumWidth = 6;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btneliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btneliminar.Width = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1630, 646);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 31);
            this.label16.TabIndex = 202;
            this.label16.Text = "Cambio:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1635, 569);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 31);
            this.label13.TabIndex = 203;
            this.label13.Text = "Pago Pesos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1635, 488);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 31);
            this.label1.TabIndex = 204;
            this.label1.Text = "Total a Pagar:";
            // 
            // txtcambio
            // 
            this.txtcambio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtcambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcambio.Location = new System.Drawing.Point(1635, 681);
            this.txtcambio.Margin = new System.Windows.Forms.Padding(4);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.ReadOnly = true;
            this.txtcambio.Size = new System.Drawing.Size(248, 38);
            this.txtcambio.TabIndex = 207;
            // 
            // txtpagocon
            // 
            this.txtpagocon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpagocon.Location = new System.Drawing.Point(1635, 604);
            this.txtpagocon.Margin = new System.Windows.Forms.Padding(4);
            this.txtpagocon.Name = "txtpagocon";
            this.txtpagocon.Size = new System.Drawing.Size(248, 38);
            this.txtpagocon.TabIndex = 206;
            this.txtpagocon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpagocon_KeyDown);
            this.txtpagocon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpagocon_KeyPress);
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txttotalpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalpagar.Location = new System.Drawing.Point(1635, 528);
            this.txttotalpagar.Margin = new System.Windows.Forms.Padding(4);
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.Size = new System.Drawing.Size(248, 38);
            this.txttotalpagar.TabIndex = 205;
            this.txttotalpagar.Text = "0";
            // 
            // btncrearventa
            // 
            this.btncrearventa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncrearventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrearventa.ForeColor = System.Drawing.Color.Blue;
            this.btncrearventa.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btncrearventa.IconColor = System.Drawing.Color.DodgerBlue;
            this.btncrearventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncrearventa.IconSize = 30;
            this.btncrearventa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncrearventa.Location = new System.Drawing.Point(1101, 730);
            this.btncrearventa.Margin = new System.Windows.Forms.Padding(4);
            this.btncrearventa.Name = "btncrearventa";
            this.btncrearventa.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btncrearventa.Size = new System.Drawing.Size(803, 140);
            this.btncrearventa.TabIndex = 208;
            this.btncrearventa.Text = "Crear Venta";
            this.btncrearventa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncrearventa.UseVisualStyleBackColor = true;
            this.btncrearventa.Click += new System.EventHandler(this.btncrearventa_Click);
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.BackColor = System.Drawing.SystemColors.Window;
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblDolar.Location = new System.Drawing.Point(628, 45);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(32, 33);
            this.lblDolar.TabIndex = 209;
            this.lblDolar.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Window;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.ForestGreen;
            this.label11.Location = new System.Drawing.Point(591, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 33);
            this.label11.TabIndex = 210;
            this.label11.Text = "$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Window;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.ForestGreen;
            this.label12.Location = new System.Drawing.Point(591, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(229, 33);
            this.label12.TabIndex = 211;
            this.label12.Text = "Tipo de cambio";
            // 
            // cbMetodo
            // 
            this.cbMetodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMetodo.FormattingEnabled = true;
            this.cbMetodo.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Transferencia",
            "Efectivo y Tarjeta"});
            this.cbMetodo.Location = new System.Drawing.Point(1632, 420);
            this.cbMetodo.Margin = new System.Windows.Forms.Padding(4);
            this.cbMetodo.Name = "cbMetodo";
            this.cbMetodo.Size = new System.Drawing.Size(249, 39);
            this.cbMetodo.TabIndex = 94;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1632, 380);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(174, 31);
            this.label17.TabIndex = 212;
            this.label17.Text = "Metodo Pago";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbPorcentaje
            // 
            this.cbPorcentaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPorcentaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPorcentaje.FormattingEnabled = true;
            this.cbPorcentaje.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25"});
            this.cbPorcentaje.Location = new System.Drawing.Point(1101, 576);
            this.cbPorcentaje.Margin = new System.Windows.Forms.Padding(4);
            this.cbPorcentaje.Name = "cbPorcentaje";
            this.cbPorcentaje.Size = new System.Drawing.Size(215, 33);
            this.cbPorcentaje.TabIndex = 213;
            this.cbPorcentaje.SelectedIndexChanged += new System.EventHandler(this.cbPorcentaje_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1100, 522);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(198, 42);
            this.label18.TabIndex = 214;
            this.label18.Text = "Descuento";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1324, 576);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 42);
            this.label19.TabIndex = 215;
            this.label19.Text = "%";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNotas
            // 
            this.txtNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotas.Location = new System.Drawing.Point(1101, 675);
            this.txtNotas.Margin = new System.Windows.Forms.Padding(4);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(248, 38);
            this.txtNotas.TabIndex = 216;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(1100, 629);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(116, 42);
            this.label20.TabIndex = 217;
            this.label20.Text = "Notas";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CcAmazonPay;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.Location = new System.Drawing.Point(1343, 380);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(260, 150);
            this.iconButton1.TabIndex = 218;
            this.iconButton1.Text = "Usar Puntos";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton2.Location = new System.Drawing.Point(1577, 222);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(327, 154);
            this.iconButton2.TabIndex = 219;
            this.iconButton2.Text = "IVA";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.SystemColors.Window;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.ForestGreen;
            this.label22.Location = new System.Drawing.Point(1095, 397);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 33);
            this.label22.TabIndex = 220;
            this.label22.Text = "Dolar";
            // 
            // lblTotalEnDolar
            // 
            this.lblTotalEnDolar.AutoSize = true;
            this.lblTotalEnDolar.BackColor = System.Drawing.SystemColors.Window;
            this.lblTotalEnDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEnDolar.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTotalEnDolar.Location = new System.Drawing.Point(1132, 439);
            this.lblTotalEnDolar.Name = "lblTotalEnDolar";
            this.lblTotalEnDolar.Size = new System.Drawing.Size(32, 33);
            this.lblTotalEnDolar.TabIndex = 221;
            this.lblTotalEnDolar.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.SystemColors.Window;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.ForestGreen;
            this.label24.Location = new System.Drawing.Point(1098, 439);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 33);
            this.label24.TabIndex = 222;
            this.label24.Text = "$";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.White;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(1388, 570);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(157, 31);
            this.label25.TabIndex = 223;
            this.label25.Text = "Pago Dolar:";
            // 
            // txtPagoDolar
            // 
            this.txtPagoDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagoDolar.Location = new System.Drawing.Point(1388, 605);
            this.txtPagoDolar.Margin = new System.Windows.Forms.Padding(4);
            this.txtPagoDolar.Name = "txtPagoDolar";
            this.txtPagoDolar.Size = new System.Drawing.Size(203, 38);
            this.txtPagoDolar.TabIndex = 224;
            this.txtPagoDolar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpagocon_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(1690, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 225;
            this.pictureBox1.TabStop = false;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1917, 905);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtPagoDolar);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.lblTotalEnDolar);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbPorcentaje);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbMetodo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.btncrearventa);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcambio);
            this.Controls.Add(this.txtpagocon);
            this.Controls.Add(this.txttotalpagar);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.btnagregarproducto);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbotipodocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtdocumentocliente;
        private FontAwesome.Sharp.IconButton btnbuscarcliente;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtidproducto;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private System.Windows.Forms.TextBox txtcodproducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnagregarproducto;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcambio;
        private System.Windows.Forms.TextBox txtpagocon;
        private System.Windows.Forms.TextBox txttotalpagar;
        private FontAwesome.Sharp.IconButton btncrearventa;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbMetodo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbPorcentaje;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label label20;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtClientePuntos;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblTotalEnDolar;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtPagoDolar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtprecioInicial;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}