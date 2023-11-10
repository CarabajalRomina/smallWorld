using smallworld.src.interfaces.habitat;
using smallworld.src.interfaces.interactuable;
using smallworld.src.modelo.estrategias;
using smallworld.src.modelo.estrategias.decoradoresConcretos;
using smallworld.src.modelo.habitats.decoradoresConcretos;
using smallworld.src.modelo.habitats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.src.controladoras
{
    internal class EstrategiasController
    {
        private readonly static EstrategiasController estrategiasController = new EstrategiasController();
        List<IEstrategia> estrategias = new List<IEstrategia>();
        List<IDecorable> Decoradores = new List<IDecorable>();

        #region SINGLETON
        private EstrategiasController() {

            Decoradores.Add(GetEstrategiaAumentarVida());
            Decoradores.Add(GetEstrategiaAumentarEnergia());
            Decoradores.Add(GetEstrategiaAumentarAtaque());
        }

        public static EstrategiasController GetController()
        {
            return estrategiasController;
        }
        #endregion


        public IDecorable GetEstrategiaAumentarVida()
        {
            return new DecoradorAumentarVida(new EstrategiaComponente());
        }

        public IDecorable GetEstrategiaAumentarEnergia()
        {
            return new DecoradorAumentarEnergia(new EstrategiaComponente());
        }

        public IDecorable GetEstrategiaAumentarAtaque()
        {
            return new DecoradorAumentarAtaque(new EstrategiaComponente());
        }

        public IEstrategia GetEstrategiaSacarVida()
        {
            return new DecoradorSacarVida(new EstrategiaComponente());
        }

        public IEstrategia GetEstrategiaSacarEnergia()
        {
            return new DecoradorSacarEnergia(new EstrategiaComponente());
        }

        public IEstrategia GetEstrategiaSacarEnergiayVida()
        {
            return new DecoradorSacarEnergia(new DecoradorSacarVida(new EstrategiaComponente()));
        }


        public IEstrategia GetEstrategiaAumentarAtaqueyEnergia()
        {
            return new DecoradorAumentarAtaque(new DecoradorAumentarEnergia(new EstrategiaComponente()));
        }

        public void CargarListEstrategias()
        {
            estrategias.Add(GetEstrategiaSacarEnergia());
            estrategias.Add(GetEstrategiaSacarEnergiayVida());
            estrategias.Add(GetEstrategiaSacarVida());
            estrategias.Add(GetEstrategiaAumentarAtaqueyEnergia());
        }

        public List<IEstrategia> ESTRATEGIAS
        {
            get { return estrategias; }
            set { estrategias = value; }
        }

        public List<IDecorable> DECORADORES
        {
            get { return Decoradores; }
        }

    }
}
