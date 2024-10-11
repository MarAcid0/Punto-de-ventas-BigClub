namespace CapaPresentacion
{
    partial class frmDetalleCompra
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
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvdataP = new System.Windows.Forms.DataGridView();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidStokSucursal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataP)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-6, -5);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(1502, 708);
            this.label10.TabIndex = 137;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(231, 29);
            this.label9.TabIndex = 194;
            this.label9.Text = "Detalle Transpasos";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkCyan;
            this.button1.Location = new System.Drawing.Point(18, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 69);
            this.button1.TabIndex = 195;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvdataP
            // 
            this.dgvdataP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdataP.Location = new System.Drawing.Point(319, 12);
            this.dgvdataP.Name = "dgvdataP";
            this.dgvdataP.RowHeadersWidth = 51;
            this.dgvdataP.RowTemplate.Height = 24;
            this.dgvdataP.Size = new System.Drawing.Size(1449, 676);
            this.dgvdataP.TabIndex = 196;
            this.dgvdataP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdataP_CellClick);
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProd.Location = new System.Drawing.Point(18, 229);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(295, 30);
            this.txtNombreProd.TabIndex = 197;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 198;
            this.label1.Text = "Nombre de producto";
            // 
            // txtidStokSucursal
            // 
            this.txtidStokSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidStokSucursal.Location = new System.Drawing.Point(173, 154);
            this.txtidStokSucursal.Name = "txtidStokSucursal";
            this.txtidStokSucursal.Size = new System.Drawing.Size(99, 30);
            this.txtidStokSucursal.TabIndex = 199;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 200;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 202;
            this.label3.Text = "Nombre de producto";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(12, 309);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(254, 30);
            this.textBox3.TabIndex = 201;
            // 
            // frmDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1767, 763);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidStokSucursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreProd);
            this.Controls.Add(this.dgvdataP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDetalleCompra";
            this.Text = "frmDetalleCompra";
            this.Load += new System.EventHandler(this.frmDetalleCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvdataP;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtidStokSucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
    }
}