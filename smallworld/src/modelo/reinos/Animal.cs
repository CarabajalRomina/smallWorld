using smallworld.src.interfaces.reino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.src.modelo.reinos
{
    internal class Animal : IReino
    {
        public Animal() { }

        public override string ToString()
        {
            return "Animal";
        }
    }
}
