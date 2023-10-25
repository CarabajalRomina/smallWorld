using smallworld.interfaces.reino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.modelo.reinos
{
    internal class Animal: IReino
    {
        public Animal() { }

        public override string ToString()
        {
            return "Animal";
        }
    }
}
