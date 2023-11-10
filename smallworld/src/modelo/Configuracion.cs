using smallworld.src.modelo.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.src.modelo
{
    internal static class Configuracion
    {
        public static int  maxVida = 1000;
        public static int maxEnergia = 1000;
        public static int minVida = 100;
        public static int minEnergia = 100;
        public static double costoEnergia = 0.10;

        public static void AplicarCostoEnergia(Entidad entidad)
        {
            entidad.ENERGIACTUAL -= Convert.ToInt32(Math.Ceiling(Convert.ToDouble(entidad.ENERGIACTUAL * costoEnergia)));
        }

    }
}
