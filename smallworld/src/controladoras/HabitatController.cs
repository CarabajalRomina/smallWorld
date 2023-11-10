using smallworld.modelo.habitats.decoradoresConcretos;
using smallworld.src.interfaces.habitat;
using smallworld.src.modelo.habitats;
using smallworld.src.modelo.habitats.decoradoresConcretos;


namespace smallworld.src.controladoras
{
    public class HabitatController
    {
        private static HabitatController cntHabitat;
        List<IHabitat> habitats = new List<IHabitat>();


        #region SINGLETON
        private HabitatController() { }

        public static HabitatController getCntHabitat()
        {
            if (cntHabitat == null)
            {
                cntHabitat = new HabitatController();
            }
            return cntHabitat;
        }
        #endregion

        public List<IHabitat> HABITATS
        {
            get { return habitats; }
        }


        private IHabitat GetTerrestre()
        {
            return new DecoradorTerrestre(new HabitatComponente());
        }

        private IHabitat GetAcuatico()
        {
            return new DecoradorAcuatico(new HabitatComponente());
        }

        private IHabitat GetAereo()
        {
            return new DecoradorAereo(new HabitatComponente());
        }

        private IHabitat GetAeroTerrestre()
        {
            return new DecoradorAereo(new DecoradorTerrestre(new HabitatComponente()));
        }

        private IHabitat GetAcuaterrestre()
        {
            return new DecoradorAcuatico(new DecoradorTerrestre(new HabitatComponente()));
        }


        private IHabitat GetAeroAcuaTerrestre()
        {
            return new DecoradorAereo(new DecoradorAcuatico(new DecoradorTerrestre( new HabitatComponente())));
        }

        public List<IHabitat> CargarYgetListHabitats()
        {
            if(habitats.Count == 0)
            {
                habitats.Add(GetAereo());
                habitats.Add(GetAcuatico());
                habitats.Add(GetTerrestre());
                habitats.Add(GetAcuaterrestre());
                habitats.Add(GetAeroTerrestre());
                habitats.Add(GetAeroAcuaTerrestre());
            }
            return HABITATS;
        }
    }
}
