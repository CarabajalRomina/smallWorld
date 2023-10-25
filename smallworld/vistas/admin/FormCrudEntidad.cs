using smallworld.modelo.componentesForm;
using smallworld.controladoras;


namespace smallworld.vistas.admin
{
    public partial class FormCrudEntidad : Form
    {
        public EntidadController entController = EntidadController.GetEntidadController();
        public FormCrudEntidad()
        {
            InitializeComponent();
            cargarTablaEntidad();
        }



        private void cargarTablaEntidad()
        {

            ComponentesForm.CargarDataGrid(dvEntidades, entController.GetEntidades());
            foreach(var e in entController.GetEntidades())
            {
                Console.WriteLine(e);
                Console.WriteLine("");
            }
            
            dvEntidades.DataSource = entController.GetEntidades();

        }
    }
}
