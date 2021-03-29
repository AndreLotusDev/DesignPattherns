using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace ChainOfResposability.Class.MetasDeVendas
{
    class _20KDeVendas : IMeta
    {

        public IMeta ProximaMeta { get; set; }

        public double Meta => 20_000;

        public void ConsolidacaoDeMeta(EstoqueGeral estoque)
        {
            if (estoque.VendedorResponsavel != null)
            {
                var vendasTotais = estoque.ValorTotalEmEstoque;

                if (vendasTotais >= Meta)
                    MensagemParabenizacao();
                else
                    ProximaMeta?.ConsolidacaoDeMeta(estoque);
            }
        }

        public void MensagemParabenizacao()
        {
            WriteLine("===============");
            WriteLine("Parabens, você atingiu a meta de 20.000 Reais em vendas");
            WriteLine("Você sera promovido");
            WriteLine("===============");
        }
    }
}
