using smallworld.src.interfaces.reino;
using smallworld.src.modelo.fabricas.reinos;
using smallworld.src.modelo.reinos;


namespace smallworld.modelo.fabricas.reinos
{
    internal class CreadorMaquina : CreadorReinos
    {
        public override IReino CrearReino()
        {
            return new Maquina();
        }
    }
}
