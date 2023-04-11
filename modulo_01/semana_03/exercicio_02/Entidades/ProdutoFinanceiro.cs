namespace exercicio_02.Entidades
{
    internal class ProdutoFinanceiro : Produto
    {
        public void acesso()
        {
            ProdutoFinanceiro PF1 = new ProdutoFinanceiro();
            PF1.nome = "Produto dentro da classe ProdutoFinanceiro";
            PF1.cor = "Verde";
            Console.WriteLine($"Nome: {PF1.nome} \nCor: {PF1.cor}");
            PF1.verificarEstoque();
            PF1.vender();
            PF1.alterarAtributosPrivados(99, 100.0);
        }
    }
}
