using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONCELL.Datos;
namespace CONCELL
{
    public partial class FMAdministrador : Form
    {
        public FMAdministrador()
        {
            InitializeComponent();
        }

        private void FMAdministrador_Load(object sender, EventArgs e)
        {
            MessageBox.Show(General.CurrUsuario.Nombre + " " + General.CurrUsuario.Apellido);
            MessageBox.Show(General.CurrUsuario.Rol.Nombre);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel4_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FMUsuarios US = new FMUsuarios();
            US.Visible = true;
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FMInventarioMenuLinks inventario = new FMInventarioMenuLinks();
            inventario.Visible = true;
            Visible = false;
        }
    }
}
