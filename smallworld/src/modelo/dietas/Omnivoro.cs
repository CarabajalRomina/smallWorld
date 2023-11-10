using smallworld.src.interfaces.dieta;
using smallworld.src.modelo.interactuables;

namespace smallworld.src.modelo.dietas
{
    public class Omnivoro : IDieta
    {
        public Omnivoro() { }

        public bool PuedoComer(Comida alimento)
        {
            bool aux;
            if (alimento != null && (alimento.TIPODIETA is Herbivoro || alimento.TIPODIETA is Carnivoro))
            {
                aux = true;
            }
            else aux = false;

            return aux;
        }


        public override string ToString()
        {
            return "Omnivoro";
        }

    }
}
