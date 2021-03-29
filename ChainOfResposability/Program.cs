using ChainOfResposability.Class;
using ChainOfResposability.Class.MetasDeVendas;
using static System.Console;

namespace ChainOfResposability
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cadeia de responsabilidade permite q outras classes conheçam suas antecedentes
            //Ele liga cada classe com uma proxima, permitindo que tenha um maior desacoplamento no códido
            //Nota: que esse codigo pode ser reescrito utilizando o template method

            ItemNoEstoque itemN1 = new ItemNoEstoque("Bic", 3.90, 10);
            ItemNoEstoque itemN2 = new ItemNoEstoque("Castel", 3.90, 10);
            ItemNoEstoque itemN3 = new ItemNoEstoque("Bic Vermelha", 3.90, 10);
            ItemNoEstoque itemN4 = new ItemNoEstoque("Lapiseira", 3.90, 2_000);
            ItemNoEstoque itemN5 = new ItemNoEstoque("XBOX", 3_900, 10);
            ItemNoEstoque itemN6 = new ItemNoEstoque("PS4", 4_800, 10);

            EstoqueGeral estoque = new EstoqueGeral("Papelaria");

            Vendedor vendedorAndre = new Vendedor("Andre Soares Gomes", 10_000.00);

            IMeta meta5K = new _5KDeVendas();
            IMeta meta10K = new _10KDeVendas();
            IMeta meta20K = new _20KDeVendas();

            meta5K.ProximaMeta = meta10K;
            meta10K.ProximaMeta = meta20K;

            estoque.SetVendedorResponsavel(vendedorAndre);
            estoque.SetMetaInicial(meta5K);

            estoque.AdicionaNovoItemNoEstoque(itemN1);
            estoque.AdicionaNovoItemNoEstoque(itemN2);
            estoque.AdicionaNovoItemNoEstoque(itemN3);
            estoque.AdicionaNovoItemNoEstoque(itemN4);
            estoque.AdicionaNovoItemNoEstoque(itemN5);
            estoque.AdicionaNovoItemNoEstoque(itemN6);

            estoque.LeituraMensalDeMeta();
            
            //estoque.LeituraDosProdutos();
            //estoque.LeituraDoValorTotalEmEstoque();


            ReadKey();

        }
    }
}
