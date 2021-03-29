using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Builder.Class
{
    public class Nota
    {
        public string NotaDescricaoRapida { get; set; }
        public string Descricao { get; set; }
        public string NomeDoResponsavel { get; set; }
        public double ValorTotal { get; set; }

        private List<Produto> _produtos = new List<Produto>();

        public IReadOnlyCollection<Produto> Produtos { get; private set; }

        public Nota(string notaDescricaoRapida, string descricao, string nomeDoResponsavel, List<Produto> produtos)
        {
            NotaDescricaoRapida = notaDescricaoRapida;
            Descricao = descricao;
            NomeDoResponsavel = nomeDoResponsavel;
            _produtos = produtos;
        }

        public double GetValorTotal()
        {
            foreach (var item in _produtos)
            {
                ValorTotal += item.ValorTotal;
            }

            return ValorTotal;
        }

        public void MostraAsInformacoes()
        {
            WriteLine($"Descrição breve: {NotaDescricaoRapida}");
            WriteLine($"Descricao completa {Descricao}");
            WriteLine($"Responsavel: {NomeDoResponsavel}");
            WriteLine($"Valor total da nota: {GetValorTotal()}");

            if(_produtos.Any())
            {
                WriteLine("Lista de produtos: ");
                foreach (var item in _produtos)
                {
                    WriteLine($"Nome: {item.Nome} - Valor Unitario: {item.PrecoUnitario}");
                }
            }
            
        }
    }
}
