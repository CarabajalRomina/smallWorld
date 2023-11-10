using smallworld.src.interfaces.habitat;
using smallworld.src.interfaces.terreno;
using smallworld.src.modelo.habitats;
using smallworld.src.modelo.terrenos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.src.modelo.habitats.decoradoresConcretos
{
    public class DecoradorAcuatico : DecoradorHabitatsBase
    {
        public DecoradorAcuatico(IHabitat habitat) : base(habitat){}

        public override bool PuedoMover(ITerreno terreno)
        {
            return base.PuedoMover(terreno) || terreno is Agua;
        }



        public override string ToString()
        {
            return base.ToString()+"-"+"Acuatico";
        }
    }
}
