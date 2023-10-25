using smallworld.interfaces.dieta;
using smallworld.interfaces.habitat;
using smallworld.interfaces.interactuable;
using smallworld.interfaces.reino;
using smallworld.modelo.dado;
using smallworld.modelo.interactuables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.modelo.entidades
{
    public class Entidad
    {
        int Id;
        private static int GlobalCount;
        string Nombre;
        IReino Reino;
        IDieta Dieta;
        List<IHabitat> Habitats = new List<IHabitat>();
        int EnergiaActual;
        int EnergiaMax;
        int VidaActual;
        int VidaMax;
        int PuntosAtaque;
        int PuntosDefensa;
        int RangoAtaque;

        #region CONSTRUCTORES
        public Entidad() { }
        public Entidad(string nombre, IReino reino, IDieta dieta, List<IHabitat> habitats, int puntosAtaque, int puntosDefensa, int rangoAtaque)
        {
            NOMBRE = nombre;
            REINO = reino;
            DIETA = dieta;
            HABITATS= habitats;
            PUNTOSATAQUE = puntosAtaque;
            PUNTOSDEFENSA = puntosDefensa;
            RANGOATAQUE = rangoAtaque;
        }

        public Entidad(string nombre, IReino reino, IDieta dieta, List<IHabitat> habitats, int energiaMax, int vidaMax, int puntosAtaque, int puntosDefensa, int rangoAtaque)
        {
            Id = ++GlobalCount;
            NOMBRE = nombre;
            REINO = reino;
            DIETA = dieta;
            HABITATS = habitats;
            ENERGIAMAX = energiaMax;
            ENERGIACTUAL = energiaMax;
            VIDAMAX = vidaMax;
            VIDAACTUAL = vidaMax;
            PUNTOSATAQUE = puntosAtaque;
            PUNTOSDEFENSA = puntosDefensa;
            RANGOATAQUE = rangoAtaque;
        }
        #endregion

        #region PROPIEDADES
        public int ID
        {
            get { return Id; }
        }
        public string NOMBRE
        {
            get { return Nombre;}
            set
            {
                if (value != null)
                {
                    Nombre = value;
                }
            }
        }

        public IReino REINO
        {
            get { return Reino;}
            set
            {
                if (value != null)
                {
                    Reino = value;
                }
            }
            
        }

        public IDieta DIETA
        {
            get { return Dieta; }
            set
            {
                if (value != null)
                {
                    Dieta = value;
                }
            }
        }

        public List<IHabitat> HABITATS
        {
            get { return Habitats; }
            set
            {
                if (value != null)
                {
                    Habitats = value;
                }
            }
        }

        public int ENERGIACTUAL
        {
            get { return EnergiaActual; }
            set {
                if (value >= 0 && value <= EnergiaMax)
                {
                    EnergiaActual = value;
                }
            }
        }

        public int ENERGIAMAX
        {
            get { return EnergiaMax;}
            set {
                if (value > 0)
                {
                    EnergiaMax = value;
                }
            }
        }
        public int VIDAACTUAL
        {
            get { return VidaActual; }
            set { 
                if(value >= 0 && value <= VidaMax) { 
                    VidaActual = value;
                }
            }
        }

        public int VIDAMAX
        {
            get { return VidaMax; }
            set {
                if (value > 0) {
                    VidaMax = value;
                }
            }
        }

        public int PUNTOSATAQUE
        {
            get { return PuntosAtaque; }
            set
            {
                if (value > 0)
                {
                    PuntosAtaque = value;
                }
            }
        }

        public int PUNTOSDEFENSA
        {
            get { return PuntosDefensa; }
            set
            {
                if (value > 0)
                {
                    PuntosDefensa = value;
                }
            }
        }

        public int RANGOATAQUE
        {
            get { return RangoAtaque; }
            set
            {
                if (value >= 0 && value <= 1)
                {
                    RangoAtaque = value;
                }
            }
        }

        #endregion


        #region METODOS ATAQUE Y DEFENSA
        public int AtarcarPersonaje()
        {
            var dado = Dado.TirarDado(1, 6);
            Console.WriteLine($"Metodo atraque personaje" + NOMBRE + "Puntos de ataque mas dado: " + PUNTOSATAQUE + "valor dado " + dado + "= " + (PUNTOSATAQUE + dado));
            return PUNTOSATAQUE + dado;
        }

        public int DefenderDeAtaque()
        {
            var dado = Dado.TirarDado(1, 6);
            Console.WriteLine("Metodo defensa personaje" + NOMBRE + "Puntos de defensa mas dado: " + PUNTOSDEFENSA + "valor dado " + dado + "= " + (PUNTOSDEFENSA + dado));
            return PUNTOSDEFENSA + dado;
        }

        #endregion

        public void Comer(Comida alimento)
        { 
            if(Dieta.PuedoComer(alimento)  == false)
            {
                Console.WriteLine("no puedes comer este alimento");
            }
            else
            {
                ActualizarEnergia(alimento.CALORIAS);
                Console.WriteLine("puedes comer este alimento");
            }
        }

        private void ActualizarEnergia(int valor)
        {
            if (valor > 0 && ENERGIACTUAL + valor >= ENERGIAMAX)
            {
                ENERGIACTUAL = ENERGIAMAX;
            }
            else ENERGIACTUAL =+ valor;
        }

        public override string ToString()
        {
            return $"" +
                $" Entidad: " +
                $" Id: {ID}," +
                $" Nombre: {NOMBRE}," +
                $" Reino: {REINO}," +
                $" Dieta: {DIETA}," +
                $" Habitats: {string.Join("-", HABITATS.Select(h => h.ToString()))}," +
                $" Energia maxima: {ENERGIAMAX}," +
                $" Energia actual: {ENERGIACTUAL}," +
                $" Vida maxima: {VIDAMAX}," +
                $" Vida actual: {VIDAACTUAL}," +
                $" Puntos de ataque: {PUNTOSATAQUE}," +
                $" Puntos de defensa: {PUNTOSDEFENSA}," +
                $" Rango de ataque: {RANGOATAQUE}";
        }

        public void AumentarEnergiaActual(int valor)
        {
            ENERGIACTUAL += valor;
        }

        public void AumentarVidaActual(int valor)
        {
            VIDAACTUAL += valor;
        }

        public void ReducirEnergiaActual(int valor)
        {
            ENERGIACTUAL -= valor;
        }

        public void ReducirVidaActual(int valor)
        {
            VIDAACTUAL -= valor;
        }

        public void UsarItem(Item item)
        {
            item.interactuar(this);
        }

    }
}
