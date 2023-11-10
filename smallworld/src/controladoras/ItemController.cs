using smallworld.src.interfaces.interactuable;
using smallworld.src.interfaces.reino;
using smallworld.src.modelo.entidades;
using smallworld.src.modelo.estrategias.decoradoresConcretos;
using smallworld.src.modelo.interactuables;

namespace smallworld.src.controladoras
{
    internal class ItemController
    {
        private readonly static ItemController itemController = new ItemController();
        List<Item> Items = new List<Item>();

        #region SINGLETON
        private ItemController() { }

        public static ItemController GetController() 
        {
            return itemController;
        }

        #endregion

        public List<Item> ITEMS
        {
            get { return Items; }
        }


        #region CRUD
        public void CrearItem(string nombre, IEstrategia estrategias)
        {
            Items.Add(new Item(nombre, estrategias));
        }

        public void EditarItem(int id, string nombre, IEstrategia estrategia)
        {
            var item  = BuscarItemPorId(id);

            if (item != null)
            {
                item.NOMBRE = nombre;
                item.ESTRATEGIAS = estrategia;
            }
            else
            {
                throw new Exception("No existe el objeto");
            }

        }

        public void EliminarItem(int id)
        {
            var item = BuscarItemPorId(id);

            if (item != null)
            {
                Items.Remove(item);
            }
        }


        #endregion

        public Item BuscarItemPorId(int id)
        {
            return Items.FirstOrDefault(item => item.ID == id);
        }

    }
}
