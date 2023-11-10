using System.Data;
using smallworld.src.modelo.fabricas.dietas;
using smallworld.src.controladoras;
using smallworld.src.interfaces.dieta;
using smallworld.src.modelo.componentesForm;
using smallworld.src.modelo.entidades;
using smallworld.src.modelo.interactuables;

namespace smallworld.vistas
{
    public partial class FormCrearComida : Form
    {
        List<IDieta> Dietas = new List<IDieta> { new CreadorHerbivoro().CrearDieta(), new CreadorCarnivoro().CrearDieta(), new CreadorOmnivoro().CrearDieta() };
        EntidadController ControlEntidad = EntidadController.GetEntidadController();
        ComidaController ControlComida = ComidaController.GetComidaController();
        Entidad entidad;

        public FormCrearComida(Entidad entidad)
        {
            InitializeComponent();
            this.entidad = entidad;
            ComponentesForm.CargarComboBox(ControlEntidad.DIETAS, cbbTipoDieta);


        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            ControlComida.CrearComida(
                (txtNombre.Text).Substring(0, 1).ToUpper() + (txtNombre.Text).Substring(1).ToLower(),
                Convert.ToInt32(txtCalorias.Text),
                (IDieta)cbbTipoDieta.SelectedItem
                );
            MessageBox.Show("Se creo correctamente");

            lblAlimento.Text = $" Habitats: {string.Join("-", ControlComida.COMIDAS.Select(h => h.ToString()))}";
            ComponentesForm.CargarComboBox(ControlComida.COMIDAS, cbbComidas);
        }

        private void btnComer_Click(object sender, EventArgs e)
        {
            if (cbbComidas.SelectedItem != null)
            {
                entidad.Comer((Comida)cbbComidas.SelectedItem);
                Console.WriteLine(entidad.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var comida = ControlComida.BuscarComidaPorId(((Comida)cbbComidas.SelectedItem).ID);
            CargarFormComida(comida);
        }

        private void CargarFormComida(Comida comida)
        {
            txtId.Text = comida.ID.ToString();
            txtNombre.Text = comida.NOMBRE;
            cbbTipoDieta.SelectedItem = comida.TIPODIETA;
            txtCalorias.Text = comida.CALORIAS.ToString();
        }



        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Console.WriteLine(entidad.ToString());
            ControlComida.EditarComida(
                Convert.ToInt32(txtId.Text),
                (txtNombre.Text).Substring(0, 1).ToUpper() + (txtNombre.Text).Substring(1).ToLower(),
                Convert.ToInt32(txtCalorias.Text),
                (IDieta)cbbTipoDieta.SelectedItem
                );
            MessageBox.Show("Se edito correctamente");

        }
    }
}
