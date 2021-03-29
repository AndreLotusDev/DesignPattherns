using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Class
{
    public class Item
    {

        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public double ValorEmEstoque => Valor * Quantidade;
        public Item(string nome, int quantidade, double valor)
        {
            Nome = nome;
            Quantidade = quantidade;
            Valor = valor;
        }
    }
}
