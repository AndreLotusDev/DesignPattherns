namespace DesignPattherns.Class
{
    public class TaxaAlfandega : IImposto
    {
        private const double TRIBUTACAO_ALFANDEGA = 0.6; //Caso o produto custe mais de 100 reais

        public double Calcular(ItemNoEstoque item)
        {
            if(item.Valor > 100)
            {
                var impostoRetido = item.Valor * TRIBUTACAO_ALFANDEGA;

                item.SetNovoPreco(item.Valor + impostoRetido);

                return impostoRetido;
            }

            return -1;
        }
    }
}
