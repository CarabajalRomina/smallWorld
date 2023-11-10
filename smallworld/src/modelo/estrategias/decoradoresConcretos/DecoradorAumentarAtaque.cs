using smallworld.src.interfaces.habitat;
using smallworld.src.interfaces.interactuable;
using smallworld.src.modelo.dado;
using smallworld.src.modelo.entidades;


namespace smallworld.src.modelo.estrategias.decoradoresConcretos
{
    public class DecoradorAumentarAtaque : DecoradorEstrategiasBase
    {
        public DecoradorAumentarAtaque(IEstrategia estrategia) : base(estrategia) { }

       
        public override void AplicarEfecto(Entidad entidad)
        {
            entidad.PUNTOSATAQUE += Dado.TirarDado(10, 50);
        }

        public override string ToString()
        {
            return base.ToString()+"-"+"Aumentar puntos de ataque";
        }

        public override void Decorar(IDecorable decorable)
        {
            this.Decorar(decorable);
        }
    }
}
