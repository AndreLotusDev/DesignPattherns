using static System.Console;

namespace DesignPattherns.Class
{
    static public class CalculadoraDeImposto
    {
        static public void MostraInformações(ItemNoEstoque item, IImposto imposto)
        {
            WriteLine("================================");

            WriteLine($"O valor do item sem impostos: ${item.Valor}");
            var valorDoCalculo = imposto.Calcular(item);

            if (valorDoCalculo != -1)
            {
                WriteLine($"Imposto a se pagar: {valorDoCalculo}");
                WriteLine($"O valor do item com impostos: ${item.Valor}");
            }
            else
                WriteLine($"Este produto esta issento de tributação");

            WriteLine("================================");
        }

    }
}
