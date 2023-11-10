using smallworld.src.controladoras;
using smallworld.src.interfaces.dieta;
using smallworld.src.interfaces.habitat;
using smallworld.src.interfaces.reino;
using smallworld.src.modelo.componentesForm;
using smallworld.src.modelo.entidades;
using smallworld.vistas.admin;


namespace smallworld.vistas
{
    public partial class EntidadView : Form
    {

        EntidadController ControlEntidad = EntidadController.GetEntidadController();

        public EntidadView()
        {
            InitializeComponent();
            CargarComboBoxsYcheckList();
        }

        private void CargarComboBoxsYcheckList()
        {
            ComponentesForm.CargarComboBox(ControlEntidad.DIETAS, cbbDieta);
            ComponentesForm.CargarComboBox(ControlEntidad.REINOS, cbbReino);
           // ComponentesForm.CargarCheckList(ControlEntidad.GetHabitats(), checkListHabitat);
        }



        #region CRUD

        private void btnCrear_Click(object sender, EventArgs e)
        {
           /* ControlEntidad.CrearEntidad(
                (txtNombre.Text).Substring(0, 1).ToUpper() + (txtNombre.Text).Substring(1).ToLower(),
                (IReino)cbbReino.SelectedItem,
                (IDieta)cbbDieta.SelectedItem,
                //ObtenerHabitatsSeleccionadosCheckList(),
                Convert.ToInt32(spnEnergiaMax.Value),
                Convert.ToInt32(spnVidaMax.Value),
                Convert.ToInt32(spnPuntosAtaque.Value),
                Convert.ToInt32(spnPuntosDefensa.Value),
                Convert.ToInt32(spnRangoAtaque.Value)
                );
            ComponentesForm.CargarComboBox(ControlEntidad.GetEntidades(), cbbEntidad);
            VaciarForm();*/

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var entidad = ControlEntidad.BuscarEntidadPorId(((Entidad)cbbEntidad.SelectedItem).ID);
            cargarForm(entidad);

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           /* ControlEntidad.EditarEntidad(
                Convert.ToInt32(txtId.Text),
                (txtNombre.Text).Substring(0, 1).ToUpper() + (txtNombre.Text).Substring(1).ToLower(),
                (IReino)cbbReino.SelectedItem,
                (IDieta)cbbDieta.SelectedItem,
                ObtenerHabitatsSeleccionadosCheckList(),
                Convert.ToInt32(spnEnergiaMax.Value),
                Convert.ToInt32(spnVidaMax.Value),
                Convert.ToInt32(spnPuntosAtaque.Value),
                Convert.ToInt32(spnPuntosDefensa.Value),
                Convert.ToInt32(spnRangoAtaque.Value)
                );
            VaciarForm();*/
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (var entidad in ControlEntidad.ENTIDADES)
            {
                Console.WriteLine(entidad);
                Console.WriteLine("");
            }
            ControlEntidad.EliminarEntidad(((Entidad)cbbEntidad.SelectedItem).ID);
            Console.WriteLine("Despues de eliminar");
            Console.WriteLine("");
            foreach (var entidad in ControlEntidad.ENTIDADES)
            {
                Console.WriteLine(entidad);
                Console.WriteLine("");
            }
        }

        #endregion



        private List<IHabitat> ObtenerHabitatsSeleccionadosCheckList()
        {
            var habitat = new List<IHabitat>();
            // Obténer los elementos seleccionados en el CheckedListBox
            CheckedListBox.CheckedItemCollection selectedItems = checkListHabitat.CheckedItems;

            foreach (IHabitat item in selectedItems)
            {
                habitat.Add(item);
            }
            return habitat;
        }

        private void btnPelar_Click(object sender, EventArgs e)
        {
            FormPelea formPelea = new FormPelea();
            formPelea.ShowDialog();
        }

        private void cargarForm(Entidad entidad)
        {
            txtId.Text = entidad.ID.ToString();
            txtNombre.Text = entidad.NOMBRE;
            cbbReino.SelectedItem = entidad.REINO;
            cbbDieta.SelectedItem = entidad.DIETA;
            marcarCheckListSeleccionados(entidad);
            spnVidaMax.Value = Convert.ToInt32(spnVidaMax.Value);
            spnEnergiaMax.Value = Convert.ToInt32(spnEnergiaMax.Value);
            spnPuntosAtaque.Value = Convert.ToInt32(spnPuntosAtaque.Value);
            spnPuntosDefensa.Value = Convert.ToInt32(spnPuntosDefensa.Value);
            spnRangoAtaque.Value = Convert.ToInt32(spnRangoAtaque.Value);
            Console.WriteLine(entidad.ToString());
        }
        private void btnCrearComida_Click(object sender, EventArgs e)
        {
            FormCrearComida formCrearComida = new FormCrearComida((Entidad)cbbEntidad.SelectedItem);
            formCrearComida.ShowDialog();
        }

        private void marcarCheckListSeleccionados(Entidad entidad)
        {
           /* foreach (var habitat in entidad.HABITATS)
            {
                for (int i = 0; i < checkListHabitat.Items.Count; i++)
                {
                    if (checkListHabitat.Items[i] == habitat)
                    {
                        checkListHabitat.SetItemChecked(i, true);
                        break; // Opcionalmente, puedes usar break si solo quieres encontrar la primera coincidencia.
                    }
                }
            }*/
        }

        private void VaciarForm()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            cbbReino.SelectedIndex = -1;
            cbbDieta.SelectedIndex = -1;
            ComponentesForm.DesmarcarCheckList(checkListHabitat);
            spnVidaMax.Value = 0;
            spnEnergiaMax.Value = 0;
            spnPuntosAtaque.Value = 0;
            spnPuntosDefensa.Value = 0;
            spnRangoAtaque.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCRUDEntidad form = new FormCRUDEntidad();
            form.ShowDialog();
        }
    }
}
