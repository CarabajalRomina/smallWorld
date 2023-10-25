using smallworld.interfaces.dieta;
using smallworld.interfaces.reino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.modelo.fabricas.reinos
{
    public abstract class CreadorReinos
    {
        public abstract IReino CrearReino();

    }
}
