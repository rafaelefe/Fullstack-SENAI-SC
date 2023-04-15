namespace exercicio_01_06.Classes
{
    public class ContaCorrente : ContaBancaria
    {
        // exercicio 3
        public ContaCorrente(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            if (cliente.tipoPessoa != TipoPessoaEnum.FISICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo física!");
            }
        }

        // exercicio 6
        public override void Sacar(decimal valor)
        {
            valor += 0.50M;
            base.Sacar(valor);
        }
        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            valor += 0.25M;
            base.Transferir(conta, valor);
        }
    }
}
