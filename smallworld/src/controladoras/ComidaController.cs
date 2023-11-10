
using smallworld.src.interfaces.dieta;
using smallworld.src.modelo.interactuables;


namespace smallworld.src.controladoras
{
    internal class ComidaController
    {
        private static ComidaController comidaController;
        EntidadController ControlEntidad = EntidadController.GetEntidadController();

        List<Comida> comidas = new List<Comida>();

        #region SINGLETON
        private ComidaController() { }

        public static ComidaController GetComidaController()
        {
            if (comidaController == null)
            {
                comidaController = new ComidaController();
            }
            return comidaController;
        }
        #endregion

        #region CRUD
        public void CrearComida(string nombre, int calorias, IDieta tipoDieta)
        {
            comidas.Add(new Comida(nombre, calorias, tipoDieta));
        }

        public void EditarComida(int id, string nombre, int calorias, IDieta tipoDieta)
        {
            var comida = BuscarComidaPorId(id);

            if (BuscarComidaPorId(id) != null)
            {
                comida.NOMBRE = nombre;
                comida.CALORIAS = calorias;
                comida.TIPODIETA = tipoDieta;
            }
            else
            {
                throw new Exception("No existe el objeto");
            }
        }

        public void EliminarComida(int id)
        {
            var comida = BuscarComidaPorId(id);
            comidas.Remove(comida);
        }

        public List<Comida> COMIDAS
        {
            get { return comidas; }
            set { comidas = value; }
        }

        #endregion 

        public Comida BuscarComidaPorId(int id)
        {
            return comidas.FirstOrDefault(item => item.ID == id);
        }

    }
}
