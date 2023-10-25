using smallworld.interfaces.dieta;
using smallworld.interfaces.interactuable;
using smallworld.interfaces.reino;
using smallworld.modelo.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.modelo.interactuables
{
    public class Item : Iinteractuable
    {
        int Id;
        static int GlobalCount;
        string? Nombre;
        List<IEstrategia> Estrategias;

        public Item(string nombre, List<IEstrategia> estrategias)
        {
            Id = ++GlobalCount;
            NOMBRE = nombre;
            ESTRATEGIA = estrategias;
        } 

        #region PROPIEDADES
        public int ID
        {
            get { return Id; }
        }
        public string NOMBRE
        {
            get { return Nombre; }
            set
            {
                if (value != null)
                {
                    Nombre = value;
                }
            }
        }
        
        public List<IEstrategia> ESTRATEGIA
        {
            get { return Estrategias; }
            set
            {
                if (value != null)
                {
                    Estrategias = value;
                }
            }

        }

        public void interactuar(Entidad entidad)
        {
            foreach (var estrategia in Estrategias) 
            { 
                estrategia.AplicarEfecto(entidad);
            }
        }

        #endregion
    }
}
