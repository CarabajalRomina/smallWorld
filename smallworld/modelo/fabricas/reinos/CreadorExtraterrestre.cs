using smallworld.interfaces.reino;
using smallworld.modelo.reinos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.modelo.fabricas.reinos
{
    internal class CreadorExtraterrestre : CreadorReinos
    {
        public override IReino CrearReino()
        {
            return new Extraterrestre();
        }
    }
}
