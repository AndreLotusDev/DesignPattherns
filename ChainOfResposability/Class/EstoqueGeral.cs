using ChainOfResposability.Class.MetasDeVendas;
using System;
using System.Collections;
using System.Collections.Generic;

using static System.Console;

namespace ChainOfResposability.Class
{
    public class EstoqueGeral
    {
        public string NomeDoEstoque { get; private set; }
        public Vendedor VendedorResponsavel { get; private set; }

        public IReadOnlyCollection<ItemNoEstoque> ListaDeItems { get => listaDeItems.AsReadOnly(); }
        private List<ItemNoEstoque> listaDeItems = new List<ItemNoEstoque>();

        public double ValorTotalEmEstoque => LeituraDoValorTotalEmEstoque();

        public IMeta MetaInicial { get; private set; }

        public EstoqueGeral(string nomeDoEstoque)
        {
            NomeDoEstoque = nomeDoEstoque;
        }

        public void SetVendedorResponsavel(Vendedor vendedor)
        {
            VendedorResponsavel = vendedor;
        }

        public void SetMetaInicial(IMeta meta)
        {
            MetaInicial = meta;
        }

        public void AdicionaNovoItemNoEstoque(ItemNoEstoque item)
        {
            listaDeItems.Add(item);
        }

        public void LeituraDosProdutos()
        {
            foreach (var item in listaDeItems)
            {
                WriteLine();
                WriteLine($"Informações sobre o produto"); 
                WriteLine($"Nome: {item.NomeDoItem} - Valor Unitario: {item.ValorUnitario}");
                var valorTotal = item.ValorTotal;
            }
        }

        public double LeituraDoValorTotalEmEstoque()
        {
            var valorTotal = 0.00;

            foreach (var item in listaDeItems)
            {
                valorTotal += item.ValorUnitario * item.Quantidade;
            }

            WriteLine();
            WriteLine();
            WriteLine();
            WriteLine($"Valor total em estoque: {valorTotal} R$");

            return valorTotal;
        }

        public void LeituraMensalDeMeta()
        {
            if (MetaInicial != null)
                MetaInicial.ConsolidacaoDeMeta(this);
            else
                WriteLine("Meta não instanciada");
        }
    }
}
