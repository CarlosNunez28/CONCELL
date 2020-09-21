using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CONCELL
{
    public partial class FMCrearProducto : Form
    {
        public FMCrearProducto()
        {
            InitializeComponent();
        }

        private void txtNumeroempleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodproducto.Text);
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            float precioCompra = float.Parse(txtPreciocompra.Text);
            float precioVenta = float.Parse(txtPrecioventa.Text);


            string ingresarproducto = "INSERT INTO productos (id_producto, prod_nombre, prod_descripcion, prod_marca, prod_modelo, prod_precioCompra, prod_precioVenta) VALUES ('" + codigo + "', '" + nombre + "', '" + descripcion + "', '" + marca + "', '" + modelo + "', '" + precioCompra + "', '" + precioVenta + "')";

            MySqlConnection conectarbase = General.GetConnection();


            try
            {
                MySqlCommand insertar = new MySqlCommand(ingresarproducto, conectarbase);
                insertar.ExecuteNonQuery();
                MessageBox.Show("Producto guardado");
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FMAdministrador adm = new FMAdministrador();
            adm.Visible = true;
            Visible = false;
        }
    }
}
