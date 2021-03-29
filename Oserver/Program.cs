using Observer.Class;
using static System.Console;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            NotaBuilder notaBuilder = new NotaBuilder();

            var notaGerada = notaBuilder
                .AdicionaResponsavel("Andre Soares Gomes")
                .DescricaoDaNota("Produtos de importação, pegos na alfandega as 01:00 Hrs")
                .DescricaoRapidaDaNota("Alfandega")
                .AdicionaNovoProduto(new Produto("Barbeador", 20, 10.50))
                .AdicionaMaisDeUmProduto(new Produto("Unha em gel", 5, 7.39), new Produto("Bola Jabulani", 3, 78.67))
                .GeraNota();

            WriteLine("========================");
            WriteLine("========================");

            notaGerada.MostraAsInformacoes();

            ReadKey();
        }
    }
}
