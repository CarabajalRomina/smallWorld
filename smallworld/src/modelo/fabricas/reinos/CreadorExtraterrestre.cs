using smallworld.src.modelo.reinos;
using smallworld.src.interfaces.reino;

namespace smallworld.src.modelo.fabricas.reinos
{
    internal class CreadorExtraterrestre : CreadorReinos
    {
        public override IReino CrearReino()
        {
            return new Extraterrestre();
        }
    }
}
