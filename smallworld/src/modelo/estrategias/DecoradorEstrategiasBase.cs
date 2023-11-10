using smallworld.src.interfaces.interactuable;
using smallworld.src.modelo.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.src.modelo.estrategias
{
    public class DecoradorEstrategiasBase : IEstrategia,IDecorable
    {
        private IEstrategia Estrategia;

      
       public DecoradorEstrategiasBase(IEstrategia estrategia)
        {
            Estrategia = estrategia;
        }
        
        public virtual void AplicarEfecto(Entidad entidad)
        {
            Estrategia.AplicarEfecto(entidad);
        }

        public override string ToString()
        {
            return Estrategia.ToString();
        }

      
        public virtual void Decorar(IDecorable decorable)
        {
           
        }
    }
}
