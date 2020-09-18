using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONCELL
{
    public partial class FMUsuarios : Form
    {
        public FMUsuarios()
        {
            InitializeComponent();
            Mostrar();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            int nUsuario = int.Parse(txtNumeroempleado.Text);
            

            string eliminarusuario = "DELETE FROM usuarios WHERE id_usuario = '" + nUsuario + "'";

            MySqlConnection conectarbase = ConexionBD.conexion();
            conectarbase.Open();

            try
            {
                MySqlCommand insertar = new MySqlCommand(eliminarusuario, conectarbase);
                insertar.ExecuteNonQuery();
                MessageBox.Show("Registro eliminadodo");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
            finally
            {
                conectarbase.Close();
                Mostrar();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void usuario_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpiar();
            Mostrar();
        }

        private void limpiar()
        {
            txtNumeroempleado.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";
            txtCargo.Text = "";
            txtEstado.Text = "";
        }


        public void Mostrar()
        {
            MySqlConnection conectarbase = ConexionBD.conexion();
            conectarbase.Open();
            
            MySqlCommand mostrar = new MySqlCommand("SELECT * FROM usuarios", conectarbase);

            MySqlDataAdapter mostrar2 = new MySqlDataAdapter(mostrar);
            DataSet datset = new DataSet();
            mostrar2.Fill(datset);

            dataGridView1.DataSource = datset.Tables[0];
            conectarbase.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nUsuario = txtNumeroempleado.Text;
            MySqlDataReader reader = null;

            string buscar = "SELECT id_usuario, usuario_nombre, usuario_apellidos, usuario_login, password, id_rol, estado FROM usuarios WHERE id_usuario LIKE '" + nUsuario + "' LIMIT 1";
            MySqlConnection conectarbase = ConexionBD.conexion();
            conectarbase.Open();

            try
            {
                MySqlCommand comandoBusqueda = new MySqlCommand(buscar, conectarbase);
                reader = comandoBusqueda.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtNumeroempleado.Text = reader.GetString(0);
                        txtNombre.Text = reader.GetString(1);
                        txtApellidos.Text = reader.GetString(2);
                        txtUsuario.Text = reader.GetString(3);
                        txtPassword.Text = reader.GetString(4);
                        txtCargo.Text = reader.GetString(5);
                        txtEstado.Text = reader.GetString(6);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }
            } catch(MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
            }
            finally
            {
                conectarbase.Close();
                Mostrar();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nUsuario = int.Parse(txtNumeroempleado.Text);
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            string cargo = txtCargo.Text;
            int estado = int.Parse(txtEstado.Text);

            string ingresarusuario = "UPDATE usuarios SET usuario_nombre='" + nombre + "' , usuario_apellidos= '" + apellidos + "', usuario_login = '" + usuario + "' , password = '" + password + "', id_rol = '" + cargo + "', estado = '" + estado + "'WHERE id_usuario = '" + nUsuario + "'";

            MySqlConnection conectarbase = ConexionBD.conexion();
            conectarbase.Open();

            try
            {
                MySqlCommand insertar = new MySqlCommand(ingresarusuario, conectarbase);
                insertar.ExecuteNonQuery();
                MessageBox.Show("Registro modificado");
                limpiar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
            finally
            {
                conectarbase.Close();
                Mostrar();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int nUsuario = int.Parse(txtNumeroempleado.Text);
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            string cargo = txtCargo.Text;
            int estado = int.Parse(txtEstado.Text);

            string ingresarusuario = "INSERT INTO usuarios (id_usuario, usuario_nombre, usuario_apellidos, usuario_login, password, id_rol, estado) VALUES ('" + nUsuario + "', '" + nombre + "', '" + apellidos + "', '" + usuario + "', '" + password + "', '" + cargo + "', '" + estado + "')";

            MySqlConnection conectarbase = ConexionBD.conexion();
            conectarbase.Open();

            try
            {
                MySqlCommand insertar = new MySqlCommand(ingresarusuario, conectarbase);
                insertar.ExecuteNonQuery();
                MessageBox.Show("Registro guardado");
                limpiar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                conectarbase.Close();
                Mostrar();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FMAdministrador adm = new FMAdministrador();
            adm.Visible = true;
            Visible=false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
