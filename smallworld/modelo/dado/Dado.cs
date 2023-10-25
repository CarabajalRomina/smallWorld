using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.modelo.dado
{
    internal static class Dado
    {
        public static int TirarDado(int minCaras, int maxCaras)
        {
            var random = new Random();
            return random.Next(minCaras, maxCaras+1);
        }


    }
}
