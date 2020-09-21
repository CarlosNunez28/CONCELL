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
    public partial class FMInventarioMenuLinks : Form
    {
        public FMInventarioMenuLinks()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FMCrearProducto Prod = new FMCrearProducto();
            Prod.Visible = true;
            Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FMEntradaSalidaDeProductos entrasale = new FMEntradaSalidaDeProductos();
            entrasale.Visible = true;
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FMAdministrador adm = new FMAdministrador();
            adm.Visible = true;
            Visible = false;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FMAdministrador adm = new FMAdministrador();
            adm.Visible = true;
            Visible = false;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
