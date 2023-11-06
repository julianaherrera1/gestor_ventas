using GV;

namespace Prueba
{
    public partial class LOGIN : Form
    {
        public class variables_globales
        {
            public static List<string> id = new List<string>();
            public static List<string> password = new List<string>();
            public static string cuenta_iniciada;
        }
        
        public LOGIN()
        {
            InitializeComponent();
        }
        private void txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text == "USUARIO")
            {
                txt_user.Text = "";
                txt_user.ForeColor = Color.LightGray;
            }
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "CONTRASEÑA")
            {
                txt_pass.Text = "";
                txt_pass.ForeColor = Color.LightGray;
                txt_pass.UseSystemPasswordChar = true;
            }
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            {
                txt_user.Text = "USUARIO";
                txt_user.ForeColor = Color.DimGray;
            }
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text == "")
            {
                txt_pass.Text = "CONTRASEÑA";
                txt_pass.ForeColor = Color.DimGray;
                txt_pass.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txt_pass.UseSystemPasswordChar == false)
            {
                txt_pass.UseSystemPasswordChar = true;
            }
            else if (txt_pass.UseSystemPasswordChar == true)
            {
                txt_pass.UseSystemPasswordChar = false;
            }

        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            int cont = 0;
            string id_inicio = txt_user.Text;
            string password_inicio = txt_pass.Text;
            for (int i = 0; i < variables_globales.id.Count; i++)
            {
                if (id_inicio == variables_globales.id[i] && password_inicio == variables_globales.password[i])
                {
                    txt_pass.Text = "CONTRASEÑA";
                    txt_user.Text = "USUARIO";
                    txt_pass.UseSystemPasswordChar = false;
                    MessageBox.Show("Has iniciado sesión correctamente", "Gestor de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    i = variables_globales.id.Count;
                    cont = 0;
                    variables_globales.cuenta_iniciada = id_inicio;
                }
                else
                {
                    cont++;
                }
            }
            if (cont != 0)
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Gestor de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                Form frm = new PRODUCTOS();
                frm.Show();
                this.Hide();
            }
        }
            private void Btn_Registro_Click(object sender, EventArgs e)
        {
            variables_globales.id.Add(txt_user.Text);
            variables_globales.password.Add(txt_pass.Text);
            txt_pass.Text = "CONTRASEÑA";
            txt_user.Text = "USUARIO";
            txt_pass.UseSystemPasswordChar = false;
            MessageBox.Show("Te has registrado correctamente", "Gestor de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}