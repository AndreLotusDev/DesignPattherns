using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace TemplateMethod.Class
{
    public class Icms : ImpostoTemplate
    {
        private const double _TAXA = 0.1;

        public Icms()
        {
            TaxaPadrao = _TAXA;
        }

        public override double CalculaOValorFinal(Item item)
        {
            var valorFinal = item.ValorEmEstoque + (item.ValorEmEstoque * TaxaPadrao);
            WriteLine($"O valor final fica em: {valorFinal} com a taxação");
            return valorFinal;
        }

        public override bool PassaPelaTaxacao(Item item)
        {
            if (item.ValorEmEstoque > 0)
            {
                WriteLine("Passou pela taxação do ICMS");
                return true;
            }
            throw new Exception("O estoque nao tem valor calculavel");
        }
    }
}
