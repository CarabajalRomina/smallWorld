using smallworld.src.interfaces.habitat;
using smallworld.src.interfaces.terreno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.src.modelo.habitats
{
    internal class HabitatComponente : IHabitat
    {
        public virtual bool PuedoMover(ITerreno terreno)
        {
            return false;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
