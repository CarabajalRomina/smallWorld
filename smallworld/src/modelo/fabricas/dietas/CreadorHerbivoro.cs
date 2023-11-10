using smallworld.src.modelo.dietas;
using smallworld.src.interfaces.dieta;


namespace smallworld.src.modelo.fabricas.dietas
{
    public class CreadorHerbivoro : CreadorDietas
    {

        public override IDieta CrearDieta()
        {
            return new Herbivoro();
        }
    }
}
