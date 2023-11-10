using smallworld.src.interfaces.interactuable;
using smallworld.src.modelo.entidades;


namespace smallworld.src.modelo.interactuables
{
    public class Item : Iinteractuable
    {
        int Id;
        static int GlobalCount;
        string? Nombre;
        IEstrategia Estrategias;

        public Item(string nombre,IEstrategia estrategias)
        {
            Id = ++GlobalCount;
            NOMBRE = nombre;
            ESTRATEGIAS = estrategias;
        }

        #region PROPIEDADES
        public int ID
        {
            get { return Id; }
        }
        public string NOMBRE
        {
            get { return Nombre; }
            set
            {
                if (value != null)
                {
                    Nombre = value;
                }
            }
        }

        public IEstrategia ESTRATEGIAS
        {
            get { return Estrategias; }
            set
            {
                if (value != null)
                {
                    Estrategias = value;
                }
            }

        }


        #endregion

        public void interactuar(Entidad entidad)
        {
           /* foreach (var estrategia in Estrategias)
            {
                estrategia.AplicarEfecto(entidad);
            }*/

            ESTRATEGIAS.AplicarEfecto(entidad);
        }

    }
}
