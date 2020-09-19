using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using CONCELL;
using CONCELL.Datos;
namespace LOGIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            General.OpenConnection();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection c = General.GetConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT U.id_usuario, R.ID_ROL, U.usuario_login, U.password, U.usuario_nombre, U.usuario_apellidos, U.estado, R.rol_nombre, R.rol_descripcion, R.rol_estado FROM usuarios U INNER JOIN roles R ON U.id_rol = R.id_rol WHERE U.usuario_login=@val1 AND U.estado = 1 AND R.rol_estado = 1", c);
                cmd.Parameters.AddWithValue("@val1", usuario_login.Text);
                MySqlDataReader r = cmd.ExecuteReader();
                if (!r.Read() || !String.Equals(r["password"], password.Text))
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    r.Close();
                    return;
                }
                cRol rol = new cRol(Convert.ToInt32(r["id_rol"]), r["rol_nombre"].ToString(), r["rol_descripcion"].ToString(), Convert.ToInt32(r["rol_estado"]));
                General.CurrUsuario = new cUsuario(Convert.ToInt32(r["id_usuario"]), rol, r["usuario_login"].ToString(), r["usuario_nombre"].ToString(), r["usuario_apellidos"].ToString(), Convert.ToInt32(r["estado"]));
                r.Close();

                MessageBox.Show("Bienvenido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                switch (General.CurrUsuario.Rol.Id)
                {
                    case 1:
                        FMAdministrador fmadmin = new FMAdministrador();
                        fmadmin.Show();
                        this.Hide();
                        break;
                    case 2:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error al ingresar al sistema: " + exp.Message);
            }
        }

        private void usuario_login_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void usuario_login_Enter(object sender, EventArgs e)
        {
            if (usuario_login.Text == "USUARIO")
            {
                usuario_login.Text = "";
                usuario_login.ForeColor = Color.LightGray;
            }
        }

        private void usuario_login_Leave(object sender, EventArgs e)
        {
            if (usuario_login.Text == "")
            {
                usuario_login.Text = "USUARIO";
                usuario_login.ForeColor = Color.DimGray;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if(password.Text == "PASSWORD")
            {
                password.Text = "";
                password.ForeColor = Color.LightGray;
                password.UseSystemPasswordChar = true;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if(password.Text == "")
            {
                password.Text = "PASSWORD";
                password.ForeColor = Color.DimGray;
                password.UseSystemPasswordChar = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
