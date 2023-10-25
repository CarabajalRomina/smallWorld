using smallworld.interfaces.interactuable;
using smallworld.modelo.dado;
using smallworld.modelo.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.modelo.estrategias.item
{
    public class SacarVida : IEstrategia
    {
        public void AplicarEfecto(Entidad entidad)
        {
            entidad.ReducirVidaActual(Dado.TirarDado(50, entidad.VIDAMAX));
        }

        public override string ToString()
        {
            return "Sacar energia";
        }
    }
}
