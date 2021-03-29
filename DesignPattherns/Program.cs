using DesignPattherns.Class;

using static System.Console;

namespace DesignPattherns
{
    class Program
    {
        static void Main(string[] args)
        {
            //O padrão estrategy é um design patthern que permite que multiplas estrátegias possam ser utilizadas no mesmo objetivo
            //Ele permite um menor desacoplamento entre as classes, permitindo por consequinte uma maior escalabilidade do código

            ItemNoEstoque itemN1 = new ItemNoEstoque(100_000.00, "Lancer");
            ItemNoEstoque itemN2 = new ItemNoEstoque(680.00, "Zenfone 7");
            ItemNoEstoque itemN3 = new ItemNoEstoque(90.00, "Xiaomi Airdots");

            WriteLine(itemN1.Informacoes);
            WriteLine(itemN2.Informacoes);
            WriteLine(itemN3.Informacoes);

            IImposto icms = new Icms();
            IImposto alfandega = new TaxaAlfandega();

            CalculadoraDeImposto.MostraInformações(itemN1, icms);
            CalculadoraDeImposto.MostraInformações(itemN2, alfandega);
            CalculadoraDeImposto.MostraInformações(itemN3, alfandega);

            ReadKey();
        }
    }
}
