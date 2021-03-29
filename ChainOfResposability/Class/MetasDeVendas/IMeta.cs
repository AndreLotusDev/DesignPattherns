namespace ChainOfResposability.Class.MetasDeVendas
{
    public interface IMeta
    {
        IMeta ProximaMeta { get; set; }
        double Meta { get; }
        void MensagemParabenizacao();
        void ConsolidacaoDeMeta(EstoqueGeral estoque);

    }
}
