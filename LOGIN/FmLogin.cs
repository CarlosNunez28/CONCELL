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

namespace LOGIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=concell; Uid=root; pwd=;"); //Conexion a la base
            conectar.Open();
            //MessageBox.Show("Estas conectado a la base");

            MySqlCommand codigo = new MySqlCommand();

            MySqlConnection conectado = new MySqlConnection();
            codigo.Connection = conectar;

            codigo.CommandText = ("select * from usuarios where usuario_login = '" + usuario_login.Text + "'and password = '" + password.Text + "'");

            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("Bienvenido");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            conectar.Close();
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
