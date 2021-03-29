using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Class
{
    public interface IImposto
    {
        double TaxaPadrao { get; }
        void Calcula(Item item);
        void EhTaxavel(Item item);
    }
}
