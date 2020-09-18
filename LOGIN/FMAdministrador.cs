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
    public partial class FMAdministrador : Form
    {
        public FMAdministrador()
        {
            InitializeComponent();
        }

        private void FMAdministrador_Load(object sender, EventArgs e)
        {
            
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
    }
}
