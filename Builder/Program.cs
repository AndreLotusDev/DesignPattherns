using Builder.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Builder
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

            notaGerada.MostraAsInformacoes();

            ReadKey();
        }
    }
}
