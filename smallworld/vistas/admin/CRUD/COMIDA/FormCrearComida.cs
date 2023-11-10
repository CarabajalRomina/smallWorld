using smallworld.src.controladoras;
using smallworld.src.interfaces.dieta;
using smallworld.src.modelo.componentesForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smallworld.vistas.admin.CRUD.COMIDA
{
    public partial class FormCrearComida : Form
    {
        ComidaController cntComida = ComidaController.GetComidaController();
        EntidadController cntEntidad = EntidadController.GetEntidadController();

        public FormCrearComida()
        {
            InitializeComponent();
            ComponentesForm.CargarComboBox(cntEntidad.DIETAS, cbbDieta);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            cntComida.CrearComida(
            txtNombre.Text,
            Convert.ToInt32(txtCalorias.Text),
            (IDieta)cbbDieta.SelectedItem
            );
            VaciarForm();
        }

        private void VaciarForm()
        {
            txtNombre.Text = "";
            txtCalorias.Text = "";
            cbbDieta.SelectedIndex = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            VaciarForm();
        }

        private void pcbSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
