using GV;
using Prueba;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_Ventas
{
    public partial class factura : Form
    {
        public factura()
        {
            InitializeComponent();
        }

        private void factura_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            string date = DateTime.UtcNow.ToString("dd-MM-yyyy");
            fecha.Text = date;
            id_empleado.Text = Convert.ToString(LOGIN.variables_globales.cuenta_iniciada);
            Random rdn = new Random();
            int num_generado = rdn.Next(9999999, 99999999);
            numero_factura.Text = Convert.ToString(num_generado);
            int total = 0;
            for (int i = 0; i <= PRODUCTOS.variables_globales.nombre.Count; i++)
            {
                if (i < PRODUCTOS.variables_globales.nombre.Count)
                {
                    ListViewItem lista = new ListViewItem(PRODUCTOS.variables_globales.nombre[i]);
                    lista.SubItems.Add(Convert.ToString(PRODUCTOS.variables_globales.cantidad[i]));
                    lista.SubItems.Add(Convert.ToString(PRODUCTOS.variables_globales.precio[i]));
                    listView.Items.Add(lista);
                    total = total + PRODUCTOS.variables_globales.precio[i];
                }
                else
                {
                    ListViewItem lista = new ListViewItem("");
                    lista.SubItems.Add("");
                    lista.SubItems.Add("");
                    lista.SubItems.Add(Convert.ToString(total));
                    listView.Items.Add(lista);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nuevacompra_btn_Click_1(object sender, EventArgs e)
        {
            PRODUCTOS.variables_globales.precio.Clear();
            PRODUCTOS.variables_globales.nombre.Clear();
            PRODUCTOS.variables_globales.cantidad.Clear();
            Form frm = new PRODUCTOS();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
