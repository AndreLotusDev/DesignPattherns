namespace DesignPattherns.Class
{
    public class ItemNoEstoque
    {
        public double Valor { get; private set; } //Setado no construtor
        public string Nome { get; set; }

        public string Informacoes => $"Nome do produto: {Nome} - Valor: {Valor}";

        public void SetNovoPreco(double novoPreco)
        {
            Valor = novoPreco;
        }

        public ItemNoEstoque(double valor, string nome)
        {
            Valor = valor;
            Nome = nome;
        }
    }
}
