using System;

using static System.Console;

namespace ChainOfResposability.Class.MetasDeVendas
{
    public class _5KDeVendas : IMeta
    {

        public IMeta ProximaMeta { get; set; }

        public double Meta => 5_000;

        public void ConsolidacaoDeMeta(EstoqueGeral estoque)
        {
            if(estoque.VendedorResponsavel != null)
            {
                var vendasTotais = estoque.ValorTotalEmEstoque;

                if (vendasTotais < Meta)
                {
                    WriteLine("===============");
                    WriteLine("Voce nao atingiu a meta");
                    WriteLine("===============");
                }
                else if (vendasTotais >= Meta && vendasTotais < ProximaMeta?.Meta)
                    MensagemParabenizacao();
                else
                    ProximaMeta?.ConsolidacaoDeMeta(estoque);
            }
        }

        public void MensagemParabenizacao()
        {
            WriteLine("===============");
            WriteLine("Parabens, você atingiu a meta de 5.000 Reais em vendas");
            WriteLine("===============");
        }
    }
}
