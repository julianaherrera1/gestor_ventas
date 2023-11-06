using Gestor_de_Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GV
{
    
    public partial class PRODUCTOS : Form
    {
        public PRODUCTOS()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        int cont_mas1 = 0, cont_mas2 = 0,cont_mas3 = 0, cont_mas4 = 0;      

        public class variables_globales
        {
            public static List<int> cantidad = new List<int>();
            public static List<string> nombre = new List<string>();
            public static List<int> precio = new List<int>();
        }
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void cantidadmas3_btn_Click(object sender, EventArgs e)
        {
            cont_mas3 = Convert.ToInt32(cantidad3_label.Text);
            cont_mas3++;
            cantidad3_label.Text = Convert.ToString(cont_mas3);
        }

        private void cantidadmenos3_btn_Click(object sender, EventArgs e)
        {
            cont_mas3 = Convert.ToInt32(cantidad3_label.Text);
            cont_mas3 = cont_mas3 - 1;
            cantidad3_label.Text = Convert.ToString(cont_mas3);
        }

        private void cantidadmas4_btn_Click(object sender, EventArgs e)
        {
            cont_mas4 = Convert.ToInt32(cantidad4_label.Text);
            cont_mas4++;
            cantidad4_label.Text = Convert.ToString(cont_mas4);
        }

        private void cantidadmenos4_btn_Click(object sender, EventArgs e)
        {
            cont_mas4 = Convert.ToInt32(cantidad4_label.Text);
            cont_mas4 = cont_mas4 - 1;
            cantidad4_label.Text = Convert.ToString(cont_mas4);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            nombreimg1.Show();
            nombreimg2.Show();
            nombreimg3.Show(); 
            nombreimg4.Show();
            if (productos_combobox.Text == "PLATOS")
            {
                cantidad1_label.Text = Convert.ToString(0);
                cantidad2_label.Text = Convert.ToString(0);
                cantidad3_label.Text = Convert.ToString(0);
                cantidad4_label.Text = Convert.ToString(0);
                if (nombreimg1.Checked == true)
                {
                    nombreimg1.Checked = false;
                }
                if (nombreimg2.Checked == true)
                {
                    nombreimg2.Checked = false;
                }
                if (nombreimg3.Checked == true)
                {
                    nombreimg3.Checked = false;
                }
                if (nombreimg4.Checked == true)
                {
                    nombreimg4.Checked = false;
                }
                nombrep1.Text = "Carne de cerdo";
                Image platoimg1 = Image.FromFile("plato1.png");
                precio_unidad1.Text = "30.000"; 
                imagen1.Image = platoimg1;
                Image platoimg2 = Image.FromFile("plato2.png");
                nombrep2.Text = "Pollo Kiev";
                imagen2.Image = platoimg2;
                preciounidad2.Text = "38.000";
                Image platoimg3 = Image.FromFile("plato3.png");
                imagen3.Image = platoimg3;
                nombrep3.Text = "Carne a la plancha";
                preciounidad3.Text = "22.000";
                Image platoimg4 = Image.FromFile("plato4.png");
                imagen4.Image = platoimg4;
                nombrep4.Text = "Roti Carne";
                preciounidad4.Text = "28.000";
            }
            if (productos_combobox.Text == "BEBIDAS")
            {
                cantidad1_label.Text = Convert.ToString(0);
                cantidad2_label.Text = Convert.ToString(0);
                cantidad3_label.Text = Convert.ToString(0);
                cantidad4_label.Text = Convert.ToString(0);
                if (nombreimg1.Checked == true)
                {
                    nombreimg1.Checked = false;
                }
                if (nombreimg2.Checked == true)
                {
                    nombreimg2.Checked = false;
                }
                if (nombreimg3.Checked == true)
                {
                    nombreimg3.Checked = false;
                }
                if (nombreimg4.Checked == true)
                {
                    nombreimg4.Checked = false;
                }
                precio_unidad1.Text = "4.000";
                nombrep1.Text = "CocaCola";
                Image bebidaimg1 = Image.FromFile("cocacola.png");
                imagen1.Image = bebidaimg1;
                nombrep2.Text = "Pepsi";
                preciounidad2.Text = "3.500";
                Image bebidaimg2 = Image.FromFile("pepsi.png");
                imagen2.Image = bebidaimg2;
                nombrep3.Text = "Sprite";
                preciounidad3.Text = "3.500";
                Image bebidaimg3 = Image.FromFile("sprite.png");
                imagen3.Image = bebidaimg3;
                nombrep4.Text = "Manzana Postobon";
                Image bebidaimg4 = Image.FromFile("postobon.png");
                imagen4.Image = bebidaimg4;
                preciounidad4.Text = "3.000";
            }
            if (productos_combobox.Text == "POSTRES")
            {
                cantidad1_label.Text = Convert.ToString(0);
                cantidad2_label.Text = Convert.ToString(0);
                cantidad3_label.Text = Convert.ToString(0);
                cantidad4_label.Text = Convert.ToString(0);
                if (nombreimg1.Checked == true)
                {
                    nombreimg1.Checked = false;
                }
                if (nombreimg2.Checked == true)
                {
                    nombreimg2.Checked = false;
                }
                if (nombreimg3.Checked == true)
                {
                    nombreimg3.Checked = false;
                }
                if (nombreimg4.Checked == true)
                {
                    nombreimg4.Checked = false;
                }
                precio_unidad1.Text = "10.000";
                nombrep1.Text = "Pastel de queso";
                Image postreimg1 = Image.FromFile("postre1.png");
                imagen1.Image = postreimg1;
                Image postreimg2 = Image.FromFile("postre2.png");
                nombrep2.Text = "Tarta Pavlova";
                preciounidad2.Text = "12.000";
                imagen2.Image = postreimg2;
                Image postreimg3 = Image.FromFile("postre3.png");
                imagen3.Image = postreimg3;
                nombrep3.Text = "Tarta de Frambuesa";
                preciounidad3.Text = "8.500";
                Image postreimg4 = Image.FromFile("postre4.png");
                imagen4.Image = postreimg4;
                nombrep4.Text = "Cheesecake";
                preciounidad4.Text = "8.000";
            }

        }

        private void PRODUCTOS_Load(object sender, EventArgs e)
        {
            nombreimg1.Hide();
            nombreimg2.Hide();
            nombreimg3.Hide();
            nombreimg4.Hide();
        }

        private void cantidadmas1_btn_Click(object sender, EventArgs e)
        {
            cont_mas1 = Convert.ToInt32(cantidad1_label.Text);
            cont_mas1++;
            cantidad1_label.Text = Convert.ToString(cont_mas1);

        }

        private void agregar_btn_Click(object sender, EventArgs e)
        {
            if (productos_combobox.Text == "PLATOS")
            {
                if (nombreimg1.Checked == true)
                {
                    variables_globales.nombre.Add("Carne de cerdo");
                    variables_globales.cantidad.Add(int.Parse(cantidad1_label.Text));
                    int total = 30000 * int.Parse(cantidad1_label.Text);
                    variables_globales.precio.Add(total);
                    
                } 
                if (nombreimg2.Checked == true)
                {
                    variables_globales.nombre.Add("Pollo Kiev");
                    variables_globales.cantidad.Add(int.Parse(cantidad2_label.Text));
                    int total = 38000 * int.Parse(cantidad2_label.Text);
                    variables_globales.precio.Add(total);
                } 
                if (nombreimg3.Checked == true)
                {
                    variables_globales.nombre.Add("Carne a la plancha");
                    variables_globales.cantidad.Add(int.Parse(cantidad3_label.Text));
                    int total = 22000 * int.Parse(cantidad3_label.Text);
                    variables_globales.precio.Add(total);
                }
                if (nombreimg4.Checked == true)
                {
                    variables_globales.nombre.Add("Roti Carne");
                    variables_globales.cantidad.Add(int.Parse(cantidad4_label.Text));
                    int total = 28000 * int.Parse(cantidad4_label.Text);
                    variables_globales.precio.Add(total);
                }
                
            }
            if (productos_combobox.Text == "BEBIDAS")
            {
                if (nombreimg1.Checked == true)
                {
                    variables_globales.nombre.Add("CocaCola");
                    variables_globales.cantidad.Add(int.Parse(cantidad1_label.Text));
                    int total = 4000 * int.Parse(cantidad1_label.Text);
                    variables_globales.precio.Add(total);
                }
                if (nombreimg2.Checked == true)
                {
                    variables_globales.nombre.Add("Pepsi");
                    variables_globales.cantidad.Add(int.Parse(cantidad2_label.Text));
                    int total = 3500 * int.Parse(cantidad2_label.Text);
                    variables_globales.precio.Add(total);
                }
                if (nombreimg3.Checked == true)
                {
                    variables_globales.nombre.Add("Sprite");
                    variables_globales.cantidad.Add(int.Parse(cantidad3_label.Text));
                    int total = 3500* int.Parse(cantidad3_label.Text);
                    variables_globales.precio.Add(total);
                }
                if (nombreimg4.Checked == true)
                {
                    variables_globales.nombre.Add("Manzana Postobon");
                    variables_globales.cantidad.Add(int.Parse(cantidad4_label.Text));
                    int total = 3000 * int.Parse(cantidad4_label.Text);
                    variables_globales.precio.Add(total);
                }
            }
            if (productos_combobox.Text == "POSTRES")
            {
                if (nombreimg1.Checked == true)
                {
                    variables_globales.nombre.Add("Pastel de queso");
                    variables_globales.cantidad.Add(int.Parse(cantidad1_label.Text));
                    int total = 10000 * int.Parse(cantidad1_label.Text);
                    variables_globales.precio.Add(total);
                }
                if (nombreimg2.Checked == true)
                {
                    variables_globales.nombre.Add("Tarta Pavlova");
                    variables_globales.cantidad.Add(int.Parse(cantidad2_label.Text));
                    int total = 12000 * int.Parse(cantidad2_label.Text);
                    variables_globales.precio.Add(total);
                }
                if (nombreimg3.Checked == true)
                {
                    variables_globales.nombre.Add("Tarta de frambruesa");
                    variables_globales.cantidad.Add(int.Parse(cantidad3_label.Text));
                    int total = 8500 * int.Parse(cantidad3_label.Text);
                    variables_globales.precio.Add(total);
                }
                if (nombreimg4.Checked == true)
                {
                    variables_globales.nombre.Add("Cheesecake");
                    variables_globales.cantidad.Add(int.Parse(cantidad4_label.Text));
                    int total = 8000 * int.Parse(cantidad4_label.Text);
                    variables_globales.precio.Add(total);
                }
            }
            MessageBox.Show("Agregado correctamente", "Gestor de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void continuar_btn_Click(object sender, EventArgs e)
        {
            Form frm = new confirmar();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cantidadmenos1_btn_Click(object sender, EventArgs e)
        {
            cont_mas1 = Convert.ToInt32(cantidad1_label.Text);
            cont_mas1 = cont_mas1 - 1;
            cantidad1_label.Text=Convert.ToString(cont_mas1);
        }

        private void cantidadmas2_btn_Click(object sender, EventArgs e)
        {
            cont_mas2 = Convert.ToInt32(cantidad2_label.Text);
            cont_mas2++;
            cantidad2_label.Text = Convert.ToString(cont_mas2);
        }
        private void cantidadmenos2_btn_Click(object sender, EventArgs e)
        {
            cont_mas2 = Convert.ToInt32(cantidad2_label.Text);
            cont_mas2 = cont_mas2 - 1;
            cantidad2_label.Text = Convert.ToString(cont_mas2);
        }
    }
}
