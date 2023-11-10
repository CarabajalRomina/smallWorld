using smallworld.src.controladoras;
using smallworld.src.interfaces.dieta;
using smallworld.src.modelo.componentesForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smallworld.vistas.admin.CRUD.COMIDA
{
    public partial class FormEditarComida : Form
    {
        ComidaController cntComida = ComidaController.GetComidaController();
        EntidadController cntEntidad = EntidadController.GetEntidadController();

        public FormEditarComida(int idComida)
        {
            InitializeComponent();
            ComponentesForm.CargarComboBox(cntEntidad.DIETAS,cbbDieta);
            if (idComida != null)
            {
                CargarFormComidas(idComida);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            VaciarForm();
        }

        private void VaciarForm()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtCalorias.Text = "";
            cbbDieta.SelectedIndex = -1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cntComida.EditarComida(
             Convert.ToInt32(txtId.Text),
             txtNombre.Text,
             Convert.ToInt32(txtCalorias.Text),
             (IDieta)cbbDieta.SelectedItem
             );
            Dispose();
        }

        private void CargarFormComidas(int id)
        {
            var comida = cntComida.BuscarComidaPorId(id);
            txtId.Text = comida.ID.ToString();
            txtNombre.Text = comida.NOMBRE;
            txtCalorias.Text = comida.CALORIAS.ToString();
            cbbDieta.SelectedItem = comida.TIPODIETA;
        }
    }
}
