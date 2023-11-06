namespace Gestor_de_Ventas
{
    partial class confirmar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(confirmar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Confirmarcompra = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Exit_btnn = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.producto = new System.Windows.Forms.ColumnHeader();
            this.cantidad = new System.Windows.Forms.ColumnHeader();
            this.precio = new System.Windows.Forms.ColumnHeader();
            this.precio_total = new System.Windows.Forms.ColumnHeader();
            this.volver_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.volver_btn);
            this.panel1.Controls.Add(this.Confirmarcompra);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Exit_btnn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 450);
            this.panel1.TabIndex = 2;
            // 
            // Confirmarcompra
            // 
            this.Confirmarcompra.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Confirmarcompra.FlatAppearance.BorderSize = 0;
            this.Confirmarcompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Confirmarcompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Confirmarcompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirmarcompra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Confirmarcompra.ForeColor = System.Drawing.Color.Black;
            this.Confirmarcompra.Location = new System.Drawing.Point(31, 206);
            this.Confirmarcompra.Name = "Confirmarcompra";
            this.Confirmarcompra.Size = new System.Drawing.Size(188, 27);
            this.Confirmarcompra.TabIndex = 13;
            this.Confirmarcompra.Text = "Confirmar venta";
            this.Confirmarcompra.UseVisualStyleBackColor = false;
            this.Confirmarcompra.Click += new System.EventHandler(this.Confirmarcompra_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(217, 143);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Exit_btnn
            // 
            this.Exit_btnn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Exit_btnn.FlatAppearance.BorderSize = 0;
            this.Exit_btnn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Exit_btnn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Exit_btnn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btnn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exit_btnn.ForeColor = System.Drawing.Color.Black;
            this.Exit_btnn.Location = new System.Drawing.Point(31, 345);
            this.Exit_btnn.Name = "Exit_btnn";
            this.Exit_btnn.Size = new System.Drawing.Size(188, 27);
            this.Exit_btnn.TabIndex = 11;
            this.Exit_btnn.Text = "Salir";
            this.Exit_btnn.UseVisualStyleBackColor = false;
            this.Exit_btnn.Click += new System.EventHandler(this.Exit_btnn_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.producto,
            this.cantidad,
            this.precio,
            this.precio_total});
            this.listView.Location = new System.Drawing.Point(302, 57);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(434, 344);
            this.listView.TabIndex = 3;
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
            // volver_btn
            // 
            this.volver_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.volver_btn.FlatAppearance.BorderSize = 0;
            this.volver_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.volver_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.volver_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volver_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.volver_btn.ForeColor = System.Drawing.Color.Black;
            this.volver_btn.Location = new System.Drawing.Point(31, 260);
            this.volver_btn.Name = "volver_btn";
            this.volver_btn.Size = new System.Drawing.Size(188, 27);
            this.volver_btn.TabIndex = 20;
            this.volver_btn.Text = "Volver";
            this.volver_btn.UseVisualStyleBackColor = false;
            this.volver_btn.Click += new System.EventHandler(this.volver_btn_Click);
            // 
            // confirmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.panel1);
            this.Name = "confirmar";
            this.Text = "confirmar";
            this.Load += new System.EventHandler(this.confirmar_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button Exit_btnn;
        private Button Confirmarcompra;
        private PictureBox pictureBox2;
        private ListView listView;
        private ColumnHeader producto;
        private ColumnHeader cantidad;
        private ColumnHeader precio;
        private ColumnHeader precio_total;
        private Button volver_btn;
    }
}