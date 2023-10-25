using smallworld.interfaces.dieta;
using smallworld.modelo.interactuables;


namespace smallworld.modelo.dietas
{
    public class Carnivoro: IDieta
    {
        public Carnivoro() { }

        public bool PuedoComer(Comida alimento)
        {
           bool aux;
           if (alimento != null && alimento.TIPODIETA is Carnivoro)
           {
                 aux = true;
           }
           else aux = false;

           return aux;
        }

        public override string ToString()
        {
            return "Carnivoro";
        }
    }
}
