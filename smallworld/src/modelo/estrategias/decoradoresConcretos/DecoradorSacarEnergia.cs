using smallworld.src.interfaces.interactuable;
using smallworld.src.modelo.dado;
using smallworld.src.modelo.entidades;


namespace smallworld.src.modelo.estrategias.decoradoresConcretos
{
    public class DecoradorSacarEnergia: DecoradorEstrategiasBase
    {
        public DecoradorSacarEnergia(IEstrategia estrategia) : base(estrategia) { }

        public override void AplicarEfecto(Entidad entidad)
        {
            entidad.ReducirEnergiaActual(Dado.TirarDado(50, entidad.ENERGIAMAX));
        }

        public override string ToString()
        {
            return base.ToString() + "-" + "Saca energia";
        }

        public override void Decorar(IDecorable decorable)
        {
            decorable.Decorar(this);
        }
    }
}
