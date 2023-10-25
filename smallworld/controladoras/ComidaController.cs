using smallworld.interfaces.dieta;
using smallworld.interfaces.habitat;
using smallworld.interfaces.reino;
using smallworld.modelo.entidades;
using smallworld.modelo.interactuables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.controladoras
{
    internal class ComidaController
    {
        private static ComidaController comidaController;
        EntidadController ControlEntidad = EntidadController.GetEntidadController();

        List<Comida> comidas = new List<Comida>();


        private ComidaController() { }

        public static ComidaController GetComidaController()
        {
            if (comidaController == null)
            {
                comidaController = new ComidaController();
            }
            return comidaController;
        }

        #region
        public void CrearComida(string nombre, int calorias, IDieta tipoDieta)
        {
            comidas.Add(new Comida(nombre, calorias, tipoDieta));
        }

        public void EditarComida(int id, string nombre, int calorias, IDieta tipoDieta  )
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
            comidas.RemoveAll(item => item.ID == id);
        }

        public List<Comida> GetListComida()
        {
            return comidas;
        }

        #endregion

        public Comida BuscarComidaPorId(int id)
        {
            return comidas.FirstOrDefault(item => item.ID == id);
        }



    }
}
