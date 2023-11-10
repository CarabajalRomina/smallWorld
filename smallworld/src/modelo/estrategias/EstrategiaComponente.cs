using smallworld.src.interfaces.interactuable;
using smallworld.src.modelo.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.src.modelo.estrategias
{
    internal class EstrategiaComponente : IEstrategia
    {
        public void AplicarEfecto(Entidad entidad)
        {
            entidad.ENERGIACTUAL -= 10;
        }

       

        public override string ToString()
        {
            return "";
        }
    }
}
