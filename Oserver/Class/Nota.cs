using Oserver.Class.NotaGeradaServices;
using Oserver.Observer;
using System.Collections.Generic;
using System.Linq;

using static System.Console;

namespace Observer.Class
{
    public class Nota
    {
        public string NotaDescricaoRapida { get; set; }
        public string Descricao { get; set; }
        public string NomeDoResponsavel { get; set; }
        public double ValorTotal { get; set; }

        private List<Produto> _produtos = new List<Produto>();

        public IReadOnlyCollection<Produto> Produtos { get; private set; }

        private List<IAposCriacaoNotaFiscal> _acoes = new List<IAposCriacaoNotaFiscal>();

        public Nota(string notaDescricaoRapida, string descricao, string nomeDoResponsavel, List<Produto> produtos)
        {
            NotaDescricaoRapida = notaDescricaoRapida;
            Descricao = descricao;
            NomeDoResponsavel = nomeDoResponsavel;
            _produtos = produtos;

            if(!_acoes.Any())
            {
                _acoes.Add(new BackupNota());
                _acoes.Add(new DbNotaService());
                _acoes.Add(new NotificacaoProCliente());
            }

            ExecutaTodasAcoes();
        }

        public void AdicionaNovaAcaoObserver(IAposCriacaoNotaFiscal acao)
        {
            _acoes.Add(acao);
        }

        public void ExecutaTodasAcoes()
        {
            if(_acoes.Any())
            {
                foreach (var acao in _acoes)
                {
                    acao.Executa(this);
                }
            }
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
