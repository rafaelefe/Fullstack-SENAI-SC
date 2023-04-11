namespace exercicio_02.Entidades
{
    public class Produto
    {
        public string nome;
        protected string cor;
        private double peso, preco;

        public Produto(string nome, string cor)
        {
            this.nome = nome;
            this.cor = cor;
        }

        public Produto()
        {
        }

        public void verificarEstoque()
        {
            Console.WriteLine("Verificando estoque, acessando método da classe produto");
        }

        protected void vender()
        {
            Console.WriteLine("Vendendo produto, acessando método vender da classe produto");
        }

        private void descartar()
        {
            Console.WriteLine("Descartando produto, acessando método da classe produto");
        }
        protected void alterarAtributosPrivados(double peso, double preco)
        {
            Console.WriteLine("Alterando atributos, acessando médtodo da classe produto");
            
            this.peso = peso;
            this.preco = preco;
            Console.WriteLine($"Variável peso de escopo da classe: {peso} \n" +
                $"Variável preço de escopo da classe: {preco}");
        }


    }
}
