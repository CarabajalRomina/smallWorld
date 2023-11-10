using smallworld.src.interfaces.terreno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.src.modelo.terrenos
{
    internal class Tierra : ITerreno
    {
        public Tierra() { }
        public override string ToString()
        {
            return "Tierra";
        }
    }
}
