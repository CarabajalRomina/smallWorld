using smallworld.Properties;
using smallworld.vistas.admin.interactuables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smallworld.vistas.admin
{
    public partial class FormPrincipal : Form
    {
        Form activeForm;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void pcbSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void pcbSalir_MouseHover(object sender, EventArgs e)
        {
            pcbSalir.Image = Resources.cerrarX38;
        }

        private void pcbSalir_MouseLeave(object sender, EventArgs e)
        {
            pcbSalir.Image = Resources.cerrarX32;
        }


        public void CargarForm(Form childForm)
        {
            //if (pnlContenedor.Controls.Count > 0)
            // {
            //pnlContenedor.Controls.RemoveAt(0);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(childForm);
            pnlContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //}
        }

        private void btnEntidad_Click(object sender, EventArgs e)
        {
            CargarForm(new FormCRUDEntidad());
        }

        private void btnComida_Click(object sender, EventArgs e)
        {
            CargarForm(new FormCRUDComida());

        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            CargarForm(new FormCRUDItems());
        }
    }
}
