using static System.Console;

namespace ChainOfResposability.Class
{
    public class ItemNoEstoque
    {
        public string NomeDoItem { get; private set; }
        public double ValorUnitario { get; private set; }
        public int Quantidade { get; private set; }
        public double ValorTotal => CalculaValorDoItemEmEstoque();
        public ItemNoEstoque(string nomeDoItem, double valorUnitario, int quantidade)
        {
            NomeDoItem = nomeDoItem;
            ValorUnitario = valorUnitario;
            Quantidade = quantidade;
        }

        public double CalculaValorDoItemEmEstoque()
        {
            var valorTotal = ValorUnitario * Quantidade;
            WriteLine($"O valor do item em estoque: {valorTotal}");
            return valorTotal;
        }

        public void AlteraQuantidade(int novaQuantidade)
        {
            Quantidade = novaQuantidade;
        }
    }
}
