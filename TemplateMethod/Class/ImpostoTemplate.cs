using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Class
{
    abstract public class ImpostoTemplate : IImposto
    {
        public double TaxaPadrao { get; set; }

        public void Calcula(Item item)
        {
            if (PassaPelaTaxacao(item))
                CalculaOValorFinal(item);
        }

        public void EhTaxavel(Item item)
        {
            throw new NotImplementedException();
        }

        public abstract bool PassaPelaTaxacao(Item item);
        public abstract double CalculaOValorFinal(Item item);
    }
}
