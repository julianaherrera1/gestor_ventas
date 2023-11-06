namespace Gestor_de_Ventas
{
    partial class factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(factura));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id_empleado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numero_factura = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.producto = new System.Windows.Forms.ColumnHeader();
            this.cantidad = new System.Windows.Forms.ColumnHeader();
            this.precio = new System.Windows.Forms.ColumnHeader();
            this.precio_total = new System.Windows.Forms.ColumnHeader();
            this.nuevacompra_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Factura por:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // id_empleado
            // 
            this.id_empleado.AutoSize = true;
            this.id_empleado.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id_empleado.Location = new System.Drawing.Point(28, 212);
            this.id_empleado.Name = "id_empleado";
            this.id_empleado.Size = new System.Drawing.Size(91, 21);
            this.id_empleado.TabIndex = 12;
            this.id_empleado.Text = "Factura por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(226, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fecha:";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fecha.Location = new System.Drawing.Point(284, 178);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(91, 21);
            this.fecha.TabIndex = 14;
            this.fecha.Text = "Factura por:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(226, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nº Factura:";
            // 
            // numero_factura
            // 
            this.numero_factura.AutoSize = true;
            this.numero_factura.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numero_factura.Location = new System.Drawing.Point(318, 212);
            this.numero_factura.Name = "numero_factura";
            this.numero_factura.Size = new System.Drawing.Size(91, 21);
            this.numero_factura.TabIndex = 16;
            this.numero_factura.Text = "Factura por:";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.producto,
            this.cantidad,
            this.precio,
            this.precio_total});
            this.listView.Location = new System.Drawing.Point(17, 261);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(439, 217);
            this.listView.TabIndex = 17;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // producto
            // 
            this.producto.Text = "Producto";
            this.producto.Width = 120;
            // 
            // cantidad
            // 
            this.cantidad.Text = "Cantidad";
            this.cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cantidad.Width = 90;
            // 
            // precio
            // 
            this.precio.Text = "Precio";
            this.precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.precio.Width = 100;
            // 
            // precio_total
            // 
            this.precio_total.Text = "Precio total";
            this.precio_total.Width = 120;
            // 
            // nuevacompra_btn
            // 
            this.nuevacompra_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nuevacompra_btn.FlatAppearance.BorderSize = 0;
            this.nuevacompra_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.nuevacompra_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nuevacompra_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevacompra_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nuevacompra_btn.ForeColor = System.Drawing.Color.Black;
            this.nuevacompra_btn.Location = new System.Drawing.Point(268, 495);
            this.nuevacompra_btn.Name = "nuevacompra_btn";
            this.nuevacompra_btn.Size = new System.Drawing.Size(188, 27);
            this.nuevacompra_btn.TabIndex = 19;
            this.nuevacompra_btn.Text = "Realizar otra venta";
            this.nuevacompra_btn.UseVisualStyleBackColor = false;
            this.nuevacompra_btn.Click += new System.EventHandler(this.nuevacompra_btn_Click_1);
            // 
            // factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 534);
            this.Controls.Add(this.nuevacompra_btn);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.numero_factura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id_empleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "factura";
            this.Text = "factura";
            this.Load += new System.EventHandler(this.factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label id_empleado;
        private Label label2;
        private Label fecha;
        private Label label4;
        private Label numero_factura;
        private ListView listView;
        private ColumnHeader producto;
        private ColumnHeader cantidad;
        private ColumnHeader precio;
        private ColumnHeader precio_total;
        private Button nuevacompra_btn;
    }
}