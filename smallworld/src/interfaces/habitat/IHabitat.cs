using smallworld.src.interfaces.terreno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.src.interfaces.habitat
{
    public interface IHabitat
    {
        public bool PuedoMover(ITerreno terreno);
    }
}
