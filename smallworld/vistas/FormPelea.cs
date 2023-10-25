using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using smallworld.controladoras;
using smallworld.interfaces.dieta;
using smallworld.modelo.entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace smallworld.vistas
{
    public partial class FormPelea : Form
    {
        EntidadController ControlEntidad = EntidadController.GetEntidadController();
        public FormPelea()
        {
            InitializeComponent();
            CargarComboBoxEntidad(ControlEntidad.GetEntidades());
        }




        private void CargarComboBoxEntidad(List<Entidad> entidades)
        {
            foreach (var entidad in entidades)
            {
                cbbEntidad1.Items.Add(entidad);
            }

        }

        private void cbbEntidad1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var personajeSeleccionado = ((Entidad)cbbEntidad1.SelectedItem).NOMBRE;

            cbbEntidad2.Items.Clear();

            foreach (var entidad in ControlEntidad.GetEntidades().Where(p => p.NOMBRE != personajeSeleccionado))
            {
                cbbEntidad2.Items.Add(entidad);
            }
            lblAntesPelea.Text = cbbEntidad1.SelectedItem.ToString() + " ";
        }

        private void btnPelear_Click(object sender, EventArgs e)
        {
            ControlEntidad.Pelea((Entidad)cbbEntidad1.SelectedItem, (Entidad)cbbEntidad2.SelectedItem);
            lblDespuesPelea.Text = cbbEntidad1.SelectedItem.ToString();
            lblDespuesPelea2.Text = cbbEntidad2.SelectedItem.ToString();
        }

        private void cbbEntidad2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAntesPelea2.Text = cbbEntidad2.SelectedItem.ToString() + " ";
        }
    }
}
