using smallworld.src.interfaces.interactuable;
using smallworld.src.modelo.dado;
using smallworld.src.modelo.entidades;


namespace smallworld.src.modelo.estrategias.decoradoresConcretos
{
    public class DecoradorAumentarEnergia: DecoradorEstrategiasBase
    {
        public DecoradorAumentarEnergia(IEstrategia estrategia) : base(estrategia) { }

        public override void AplicarEfecto(Entidad entidad)
        {
            entidad.AumentarEnergiaActual(Dado.TirarDado(50, entidad.ENERGIAMAX));
        }

        public override string ToString()
        {
            return base.ToString() + "-" + "Aumenta energia";
        }

        public override void Decorar(IDecorable decorable)
        {
            decorable.Decorar(this);
        }
    }
}
