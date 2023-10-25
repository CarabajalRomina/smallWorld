using smallworld.interfaces.dieta;
using smallworld.interfaces.habitat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.modelo.interactuables
{
    public class Comida
    {
        int Id;
        private static int GlobalCount;
        string Nombre;
        int Calorias;
        IDieta TipoDieta;


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
        public int CALORIAS
        {
            get { return Calorias; }
            set
            {
                if (value != null && value > 0)
                {
                    Calorias = value;
                }
            }

        }
        public IDieta TIPODIETA
        {
            get { return TipoDieta; }
            set
            {
                if (value != null)
                {
                    TipoDieta = value;
                }
            }

        }
        #endregion

        #region CONSTRUCTORES
        public Comida() { }

        public Comida(string nombre, int calorias, IDieta tipoDieta)
        {
            Id = ++GlobalCount;
            NOMBRE = nombre;
            CALORIAS = calorias;
            TIPODIETA = tipoDieta;
        }
        #endregion

        public override string ToString()
        {
            return $"" +
                $" Comida: " +
                $" Id: {ID}," +
                $" Nombre: {NOMBRE}," +
                $" Calorias: {CALORIAS}," +
                $" Dieta: {TIPODIETA},";
        }
    }
}
