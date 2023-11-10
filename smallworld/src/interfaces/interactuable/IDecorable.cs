using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.src.interfaces.interactuable
{
    public interface IDecorable
    {
        public void Decorar(IDecorable decorador);
    }
}
