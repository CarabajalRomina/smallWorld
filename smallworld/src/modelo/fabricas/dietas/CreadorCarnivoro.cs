using smallworld.src.modelo.dietas;
using smallworld.src.interfaces.dieta;


namespace smallworld.src.modelo.fabricas.dietas
{
    public class CreadorCarnivoro : CreadorDietas
    {
        public override IDieta CrearDieta()
        {
            return new Carnivoro();
        }
    }
}
