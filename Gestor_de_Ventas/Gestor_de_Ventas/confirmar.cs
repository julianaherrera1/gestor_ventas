using GV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestor_de_Ventas
{
    public partial class confirmar : Form
    {
        public confirmar()
        {
            InitializeComponent();
        }

        private void Exit_btnn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        
        private void confirmar_Load(object sender, EventArgs e)
        {
            
            this.StartPosition = FormStartPosition.CenterScreen;
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

        private void Confirmarcompra_Click(object sender, EventArgs e)
        {
            Form frm = new factura();
            frm.Show();
            this.Hide();
        }
    }
}
