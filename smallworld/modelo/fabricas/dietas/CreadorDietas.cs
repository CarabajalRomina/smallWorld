using smallworld.interfaces.dieta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.modelo.fabricas.dietas
{
    public abstract class CreadorDietas
    {
        public abstract IDieta CrearDieta();
    }
}
