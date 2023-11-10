
namespace smallworld.src.modelo.dado
{
    internal static class Dado
    {
        public static int TirarDado(int minCaras, int maxCaras)
        {
            var random = new Random();
            return random.Next(minCaras, maxCaras+1);
        }


    }
}
