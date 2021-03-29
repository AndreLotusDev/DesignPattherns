using System;
using TemplateMethod.Class;

using static System.Console;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Item itemN1 = new Item("Caderno hot wells", 20, 10);
            Item itemN2 = new Item("Lapiseira", 30, 2);
            Item itemN3 = new Item("Lapiseira", 0, 2.50);

            IImposto icms = new Icms();
            IImposto alfandega = new Alfandega();

            try
            {
                icms.Calcula(itemN1); //Caso fosse taxação em territorio
                alfandega.Calcula(itemN1); //Caso fosse alfandega
                WriteLine();
                icms.Calcula(itemN2);
                alfandega.Calcula(itemN2);
                WriteLine();
                //icms.Calcula(itemN3);
                alfandega.Calcula(itemN3);
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }

            ReadKey();

        }
    }
}
