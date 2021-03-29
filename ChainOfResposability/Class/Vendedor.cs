namespace ChainOfResposability.Class
{
    public class Vendedor
    {

        public string NomeDoVendedor { get; private set; }
        public double TotalDeVendas { get; set; }
        public Vendedor(string nomeDoVendedor, double totalDeVendas)
        {
            NomeDoVendedor = nomeDoVendedor;
            TotalDeVendas = totalDeVendas;
        }

    }
}
