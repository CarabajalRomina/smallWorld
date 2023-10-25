using smallworld.interfaces.terreno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.modelo.terrenos
{
    internal class Aire: ITerreno
    {
        public Aire() { }

        public override string ToString()
        {
            return "Aire";
        }
    }
}
