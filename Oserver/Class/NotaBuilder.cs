using System.Collections.Generic;

namespace Observer.Class
{
    public class NotaBuilder
    {
        public string NotaDescricaoRapida { get; set; }
        public string Descricao { get; set; }
        public string NomeDoResponsavel { get; set; }
        public double ValorTotal { get; set; }

        private List<Produto> _produtos = new List<Produto>();

        public NotaBuilder DescricaoRapidaDaNota(string descricao)
        {
            this.NotaDescricaoRapida = descricao;
            return this;
        }

        public NotaBuilder DescricaoDaNota(string descricao)
        {
            this.Descricao = descricao;
            return this;
        }

        public NotaBuilder AdicionaResponsavel(string responsavel)
        {
            this.NomeDoResponsavel = responsavel;
            return this;
        }

        public NotaBuilder AdicionaNovoProduto(Produto produto)
        {
            _produtos.Add(produto);
            return this;
        }

        public NotaBuilder AdicionaMaisDeUmProduto(params Produto[] produtos)
        {
            _produtos.AddRange(produtos);
            return this;
        }

        public Nota GeraNota()
        {
            Nota novaNota = new Nota(NotaDescricaoRapida, Descricao, NomeDoResponsavel, _produtos);

            return novaNota;
        }
    }
}
