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
    public class SacarEnergia : IEstrategia
    {
        public void AplicarEfecto(Entidad entidad)
        {
            entidad.ReducirEnergiaActual(Dado.TirarDado(50, entidad.ENERGIAMAX));
        }

        public override string ToString()
        {
            return "Sacar energia";
        }
    }
}
