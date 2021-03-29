namespace DesignPattherns.Class
{
    public class Icms : IImposto
    {
        private const double TRIBUTACAO_ICMS = 0.16; //Exemplo MG em certos produtos

        public double Calcular(ItemNoEstoque item)
        {
            var impostoRetido = item.Valor * TRIBUTACAO_ICMS;

            item.SetNovoPreco(item.Valor + impostoRetido); //Troca o preco atual

            return impostoRetido; 
        }
    }
}
