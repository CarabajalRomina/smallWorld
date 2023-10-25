using smallworld.interfaces.reino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.modelo.reinos
{
    internal class Planta: IReino
    {
        public Planta() { }

        public override string ToString()
        {
            return "Vegetal";
        }
    }
}
