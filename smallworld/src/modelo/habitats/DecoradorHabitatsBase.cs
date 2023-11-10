using smallworld.src.interfaces.habitat;
using smallworld.src.interfaces.terreno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.src.modelo.habitats
{
    public class DecoradorHabitatsBase : IHabitat
    {
        IHabitat Habitat { get; set; }

        public DecoradorHabitatsBase(IHabitat habitat)
        {
            Habitat = habitat;
        }

        public virtual bool PuedoMover(ITerreno terreno)
        {
            return Habitat.PuedoMover(terreno);
        }

        public override string ToString()
        {
            return Habitat.ToString();
        }
    }
}
