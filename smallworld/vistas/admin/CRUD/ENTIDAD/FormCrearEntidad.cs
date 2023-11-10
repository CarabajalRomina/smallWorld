using smallworld.src.controladoras;
using smallworld.src.interfaces.dieta;
using smallworld.src.interfaces.habitat;
using smallworld.src.interfaces.reino;
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

namespace smallworld.vistas.admin.CRUD.ENTIDAD
{
    public partial class FormCrearEntidad : Form
    {
        EntidadController cntEntidad = EntidadController.GetEntidadController();
        HabitatController cntHabitats = HabitatController.getCntHabitat();
        public FormCrearEntidad()
        {
            InitializeComponent();
            CargarComboBoxs();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            cntEntidad.CrearEntidad(
                txtNombre.Text,
                (IReino)cbbReino.SelectedItem,
                (IDieta)cbbDieta.SelectedItem,
                (IHabitat)cbbHabitats.SelectedItem,
                Convert.ToInt32(spnEnergiaMax.Value),
                Convert.ToInt32(spnVidaMax.Value),
                Convert.ToInt32(spnPuntosAtaque.Value),
                Convert.ToInt32(spnPuntosDefensa.Value),
                Convert.ToInt32(spnRangoAtaque.Value)
                );
            VaciarForm();
        }

        private void CargarComboBoxs()
        {
            ComponentesForm.CargarComboBox(cntEntidad.DIETAS, cbbDieta);
            ComponentesForm.CargarComboBox(cntHabitats.CargarYgetListHabitats(), cbbHabitats);
            ComponentesForm.CargarComboBox(cntEntidad.REINOS, cbbReino);

        }
        private void VaciarForm()
        {
            txtNombre.Text = "";
            cbbReino.SelectedIndex = -1;
            cbbHabitats.SelectedIndex = -1;
            cbbDieta.SelectedIndex = -1;
            spnEnergiaMax.Value = 0;
            spnVidaMax.Value = 0;
            spnPuntosAtaque.Value = 0;
            spnPuntosDefensa.Value = 0;
            spnRangoAtaque.Value = 0;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            VaciarForm();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void pcbSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
