using smallworld.modelo.fabricas.reinos;
using smallworld.src.interfaces.dieta;
using smallworld.src.interfaces.habitat;
using smallworld.src.interfaces.reino;
using smallworld.src.modelo.entidades;
using smallworld.src.modelo.fabricas.dietas;
using smallworld.src.modelo.fabricas.reinos;

namespace smallworld.src.controladoras
{
    public class EntidadController
    {
        private static EntidadController entidadController;

        private List<IDieta> Dietas = new List<IDieta> { new CreadorHerbivoro().CrearDieta(), new CreadorCarnivoro().CrearDieta(), new CreadorOmnivoro().CrearDieta() };
        //List<IDieta> DietasSegunAlan = new List<IDieta> { new Herbivoro(),new Carnivoro(),new Omnivoro() };
        List<IReino> Reinos = new List<IReino> { new CreadorAnimal().CrearReino(), new CreadorPlanta().CrearReino(), new CreadorMaquina().CrearReino(), new CreadorExtraterrestre().CrearReino() };
        List<Entidad> Entidades = new List<Entidad>();


        #region SINGLETON
        private EntidadController() { }

        public static EntidadController GetEntidadController()
        {
            if (entidadController == null)
            {
                entidadController = new EntidadController();
            }
            return entidadController;
        }
        #endregion

        #region PROPIEDADES
        public List<IDieta> DIETAS
        {
            get{ return Dietas;}
            set{Dietas = value;}
        }

        public List<IReino> REINOS
        {
            get{ return Reinos;}
            set{ Reinos = value;}
        }

        public List<Entidad> ENTIDADES
        {
            get{ return Entidades;}
            set{ Entidades = value;}
        }

        #endregion

        #region CRUD
        public void CrearEntidad(string nombre, IReino reino, IDieta dieta, IHabitat habitat, int energiaMax, int vidaMax, int puntosAtaque, int puntosDefensa, int rangoAtaque)
        {
            Entidades.Add(
                new Entidad(nombre,
                reino,
                dieta,
                habitat,
                energiaMax,
                vidaMax,
                puntosAtaque,
                puntosDefensa,
                rangoAtaque)
                );
        }

        public void EditarEntidad(int id, string nombre, IReino reino, IDieta dieta, IHabitat habitat, int energiaMax, int vidaMax, int puntosAtaque, int puntosDefensa, int rangoAtaque)
        {
            var entidad = BuscarEntidadPorId(id);

            if (entidad != null)
            {
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
            var entidad = BuscarEntidadPorId(id);

            if(entidad != null)
            {
                Entidades.Remove(entidad);
            }
        }
        #endregion

        public Entidad BuscarEntidadPorId(int id)
        {
            return Entidades.FirstOrDefault(entidad => entidad.ID == id);
        }

        public void Pelea(Entidad entidadQueAtaca, Entidad entidadQueEsAtacada)
        {
            var ataque = entidadQueAtaca.AtarcarPersonaje();
            var defensa = entidadQueEsAtacada.DefenderDeAtaque();
            Console.WriteLine($"Estoy en la pelea: valor del ataque {ataque}, valor de la defensa : {defensa}, valor total de la pelea: {ataque - defensa}");

            if (ataque - defensa < 0)
            {
                entidadQueAtaca.VIDAACTUAL += ataque - defensa;
            }
            else
                entidadQueEsAtacada.VIDAACTUAL -= ataque - defensa;

        }




    }
}
