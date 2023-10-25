using smallworld.interfaces.dieta;
using smallworld.modelo.interactuables;


namespace smallworld.modelo.dietas
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
