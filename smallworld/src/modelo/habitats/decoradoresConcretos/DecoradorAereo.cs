using smallworld.src.interfaces.habitat;
using smallworld.src.interfaces.terreno;
using smallworld.src.modelo.habitats;
using smallworld.src.modelo.terrenos;


namespace smallworld.modelo.habitats.decoradoresConcretos
{
    public class DecoradorAereo : DecoradorHabitatsBase
    {
        public DecoradorAereo(IHabitat habitat) : base(habitat){ }


        public override bool PuedoMover(ITerreno terreno)
        {
            return base.PuedoMover(terreno) || terreno is Aire || terreno is Tierra || terreno is Agua;
        }


        public override string ToString()
        {
        return base.ToString() + "-" + "Aereo";
        }
    }
}
