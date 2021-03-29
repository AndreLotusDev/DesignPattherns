namespace Observer.Class
{
    public class Produto
    {
        public Produto(string nome, int quantidade, double precoUnitario)
        {
            Nome = nome;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
        }

        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }
        public double ValorTotal => Quantidade * PrecoUnitario;

    }
}
