using smallworld.interfaces.dieta;
using smallworld.interfaces.habitat;
using smallworld.interfaces.reino;
using smallworld.modelo.dietas;
using smallworld.modelo.entidades;
using smallworld.modelo.fabricas.dietas;
using smallworld.modelo.fabricas.reinos;
using smallworld.modelo.habitats;
using smallworld.modelo.reinos;


namespace smallworld.controladoras
{
    public class EntidadController
    {
        private static EntidadController entidadController;
        
        List<IDieta> Dietas = new List<IDieta> {new CreadorHerbivoro().CrearDieta(), new CreadorCarnivoro().CrearDieta(), new CreadorOmnivoro().CrearDieta()};
        //List<IDieta> DietasSegunAlan = new List<IDieta> { new Herbivoro(),new Carnivoro(),new Omnivoro() };
        
        List <IHabitat> Habitats = new List<IHabitat> { new Acuatico(), new Terrestre(), new Aereo() };
        List<IReino> Reinos = new List<IReino> { new CreadorAnimal().CrearReino(), new CreadorPlanta().CrearReino(), new CreadorMaquina().CrearReino(), new CreadorExtraterrestre().CrearReino()};
        List<Entidad> Entidades = new List<Entidad>();
        

        private EntidadController() { }

        public static EntidadController GetEntidadController()
        {
            if (entidadController == null)
            {
                entidadController = new EntidadController();
            }
            return entidadController;
        }

        public List<IDieta> GetDietas()
        {
            return Dietas;
        }

        public List<IHabitat> GetHabitats()
        {
            return Habitats;
        }

        public List<IReino> GetReinos()
        {
            return Reinos;
        }

        public List<Entidad> GetEntidades()
        {
            return Entidades;
        }


      

        public void CrearEntidad(string nombre, IReino reino, IDieta dieta, List<IHabitat> habitat,int energiaMax,int vidaMax, int puntosAtaque, int puntosDefensa, int rangoAtaque)
        {
            Entidades.Add(new Entidad(nombre, reino, dieta, habitat, energiaMax, vidaMax, puntosAtaque, puntosDefensa, rangoAtaque));
        }

        public void EditarEntidad(int id, string nombre, IReino reino, IDieta dieta, List<IHabitat> habitat, int energiaMax, int vidaMax, int puntosAtaque, int puntosDefensa, int rangoAtaque)
        {
            var entidad = BuscarEntidadPorId(id);

            if (BuscarEntidadPorId(id) != null) {
                entidad.NOMBRE = nombre;
                entidad.REINO = reino;
                entidad.DIETA = dieta;
                entidad.HABITATS = habitat;
                entidad.ENERGIAMAX = energiaMax;
                entidad.VIDAMAX = vidaMax;
                entidad.PUNTOSDEFENSA = puntosDefensa;
                entidad.PUNTOSATAQUE = puntosAtaque;
                entidad.RANGOATAQUE = puntosDefensa;
            }
            else
            {
                throw new Exception("No existe el objeto");
            }
        }

        public void EliminarEntidad(int id) 
        {
            Entidades.RemoveAll(item => item.ID == id);
        }

        public Entidad BuscarEntidadPorId(int id)
        {
            return Entidades.FirstOrDefault(item => item.ID == id);
        }

        public void Pelea(Entidad entidadQueAtaca, Entidad entidadQueEsAtacada)
        {
            var ataque = entidadQueAtaca.AtarcarPersonaje();
            var defensa = entidadQueEsAtacada.DefenderDeAtaque();
            Console.WriteLine($"Estoy en la pelea: valor del ataque {ataque}, valor de la defensa : {defensa}, valor total de la pelea: {(ataque - defensa)}");

            if ( ataque - defensa < 0)
            { 
                entidadQueAtaca.VIDAACTUAL += ataque - defensa;
            }
            else
                entidadQueEsAtacada.VIDAACTUAL -= ataque - defensa;

        }




    }
}
