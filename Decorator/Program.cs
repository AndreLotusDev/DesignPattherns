using Decorator.Class;

using static System.Console;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Item itemN1 = new Item("Caderno hot wells", 20, 10);
            Item itemN2 = new Item("Lapiseira", 30, 2);
            Item itemN3 = new Item("Lapiseira", 0, 2.50);

            IImposto icmsComAlfandega = new Alfandega(new Icms());

            icmsComAlfandega.Calcula(itemN1);

            ReadKey();

        }
    }
}
