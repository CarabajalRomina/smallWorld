using smallworld.interfaces.interactuable;
using smallworld.modelo.dado;
using smallworld.modelo.entidades;
using smallworld.modelo.interactuables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.modelo.estrategias.item
{
    public class AumentarAtaque : IEstrategia
    {
        public void AplicarEfecto(Entidad entidad)
        {
            entidad.PUNTOSATAQUE += Dado.TirarDado(10, 50);
        }

        public override string ToString()
        {
            return "Aumentar ataque";
        }
    }
}
