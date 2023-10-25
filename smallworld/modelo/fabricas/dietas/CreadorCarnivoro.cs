using smallworld.interfaces.dieta;
using smallworld.interfaces.fabricas;
using smallworld.modelo.dietas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.modelo.fabricas.dietas
{
    public class CreadorCarnivoro : CreadorDietas
    {
        public override IDieta CrearDieta()
        {
            return new Carnivoro();
        }
    }
}
