using smallworld.src.interfaces.interactuable;
using smallworld.src.modelo.dado;
using smallworld.src.modelo.entidades;

namespace smallworld.src.modelo.estrategias.decoradoresConcretos
{
    public class DecoradorAumentarVida: DecoradorEstrategiasBase
    {
        public DecoradorAumentarVida(IEstrategia estrategia) : base(estrategia) { }

        public override void AplicarEfecto(Entidad entidad)
        {
            entidad.AumentarVidaActual(Dado.TirarDado(50, entidad.VIDAMAX));
        }

        public override string ToString()
        {
            return base.ToString() + "-" + "Aumenta vida";
        }

        public override void Decorar(IDecorable decorable)
        {
            decorable.Decorar(this);
        }
    }
}
