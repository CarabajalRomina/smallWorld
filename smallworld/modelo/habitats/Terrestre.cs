using smallworld.interfaces.habitat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.modelo.habitats
{
    internal class Terrestre: IHabitat
    {
        public Terrestre() { }

        public override string ToString()
        {
            return "Terrestre";
        }
    }
}
