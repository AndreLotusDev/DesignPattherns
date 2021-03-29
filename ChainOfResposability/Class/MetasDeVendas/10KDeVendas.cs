using System;

using static System.Console;

namespace ChainOfResposability.Class.MetasDeVendas
{
    public class _10KDeVendas : IMeta
    {

        public IMeta ProximaMeta { get; set; }

        public double Meta => 10_000;

        public void ConsolidacaoDeMeta(EstoqueGeral estoque)
        {
            if (estoque.VendedorResponsavel != null)
            {
                var vendasTotais = estoque.ValorTotalEmEstoque;

                if (vendasTotais >= Meta && vendasTotais < ProximaMeta?.Meta)
                    MensagemParabenizacao();
                else
                    ProximaMeta?.ConsolidacaoDeMeta(estoque);
            }
        }

        public void MensagemParabenizacao()
        {
            WriteLine("===============");
            WriteLine("Parabens, você atingiu a meta de 10.000 Reais em vendas");
            WriteLine("Você sera promovido");
            WriteLine("===============");
        }
    }
}
