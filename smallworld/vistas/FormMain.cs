using smallworld.vistas.admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smallworld.vistas
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void picBoxSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void picBoxSalir_MouseHover(object sender, EventArgs e)
        {
            picBoxSalir.Image = Properties.Resources.cerrarX38;
        }

        private void picBoxSalir_MouseLeave(object sender, EventArgs e)
        {
            picBoxSalir.Image = Properties.Resources.cerrarX32;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormCrudEntidad formCrudEntidad = new FormCrudEntidad();
            formCrudEntidad.ShowDialog();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            var entView = new EntidadView();
            entView.ShowDialog();
        }
    }
}
