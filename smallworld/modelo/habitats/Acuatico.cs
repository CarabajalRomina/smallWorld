using smallworld.interfaces.habitat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.modelo.habitats
{
    internal class Acuatico: IHabitat
    {
        public Acuatico() { }

        public override string ToString()
        {
            return "Acuatico";
        }
    }
}
