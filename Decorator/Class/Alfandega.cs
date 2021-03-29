using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Decorator.Class
{
    public class Alfandega : ImpostoTemplate
    {
        private const double _TAXA = 0.6;

        public Alfandega(IImposto outroImposto) : base(outroImposto)
        {
            TaxaPadrao += _TAXA;
        }

        public Alfandega() : base()
        {
            TaxaPadrao += _TAXA;
        }


        public override double CalculaOValorFinal(Item item)
        {
            var valorFinal = item.ValorEmEstoque + (item.ValorEmEstoque * TaxaPadrao);
            WriteLine($"O valor final fica em: {valorFinal} com a taxação");
            return valorFinal;
        }

        public override bool PassaPelaTaxacao(Item item)
        {
            if(item.ValorEmEstoque > 100)
            {
                WriteLine("Passou pela taxação da alfandega");
                return true;
            }
            else if(item.ValorEmEstoque == 0)
            {
                throw new Exception("Voce nao possui itens em estoque");
            }
            else
            {
                WriteLine("Seu produto nao sera taxado pela alfandega");
                return false;
            }
        }
    }
}
