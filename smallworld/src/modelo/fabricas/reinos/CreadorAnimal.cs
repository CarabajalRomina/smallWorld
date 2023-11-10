using smallworld.src.interfaces.reino;
using smallworld.src.modelo.reinos;


namespace smallworld.src.modelo.fabricas.reinos
{
    internal class CreadorAnimal : CreadorReinos
    {
        public override IReino CrearReino()
        {
            return new Animal();
        }
    }
}
