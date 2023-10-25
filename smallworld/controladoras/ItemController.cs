using smallworld.interfaces.interactuable;
using smallworld.interfaces.reino;
using smallworld.modelo.interactuables;


namespace smallworld.controladoras
{
    internal class ItemController
    {
        private readonly static ItemController itemController = new ItemController();
        List<Item> Items = new List<Item>();

        private ItemController() { }

        public ItemController GetController() 
        {
            return itemController;
        }




        #region CRUD
        public void CrearItem(string nombre, List<IEstrategia> estrategias)
        {
            Items.Add(new Item(nombre, estrategias));
        }

        public void EditarItem(int id, string nombre, IReino reino)
        {
            var item  = BuscarItemPorId(id);

            if (BuscarItemPorId(id) != null)
            {
                item.NOMBRE = nombre;
            }
            else
            {
                throw new Exception("No existe el objeto");
            }

        }

        public void EliminarItem(int id)
        {
            Items.RemoveAll(item => item.ID == id);
        }

        public Item BuscarItemPorId(int id)
        {
            return Items.FirstOrDefault(item => item.ID == id);
        }

        #endregion



    }
}
