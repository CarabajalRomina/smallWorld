using smallworld.src.interfaces.interactuable;
using smallworld.src.modelo.dado;
using smallworld.src.modelo.entidades;


namespace smallworld.src.modelo.estrategias.decoradoresConcretos
{
    public class DecoradorSacarVida: DecoradorEstrategiasBase
    {
        public DecoradorSacarVida(IEstrategia estrategia) : base(estrategia) { }
        public override void AplicarEfecto(Entidad entidad)
        {
            entidad.ReducirVidaActual(Dado.TirarDado(50, entidad.VIDAMAX));
        }

        public override string ToString()
        {
            return base.ToString() + "-" + "Saca vida";
        }

        public override void Decorar(IDecorable decorable)
        {
            decorable.Decorar(this);
        }
    }
}
