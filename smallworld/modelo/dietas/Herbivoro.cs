using smallworld.interfaces.dieta;
using smallworld.interfaces.interactuable;
using smallworld.modelo.interactuables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.modelo.dietas
{
    public class Herbivoro : IDieta
    {
        public Herbivoro() { }

        public bool PuedoComer(Comida alimento)
        {
            bool aux;
            if (alimento != null && alimento.TIPODIETA  is Herbivoro)
            {
                aux = true;
            }
            else aux = false;

            return aux;
        }

        public override string ToString()
        {
            return "Herbivoro";
        }
    }
}
