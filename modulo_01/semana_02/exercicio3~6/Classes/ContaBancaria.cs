namespace exercicio3_6.Classes
{
    public class ContaBancaria
    {
        // exercicio 3
        public int numero;
        public int agencia;
        public string nomeTitular;
        public decimal saldo = 0;
        public TipoContaEnum tipoConta;

        // exercicio 4
        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
            }
            else
            {
                saldo = saldo + valor;
            }
        }

        // exercicio 5
        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");

            }
            else if (valor > saldo)
            {
                Console.WriteLine("O valor é maior do que o saldo atual!");

            }
            else
            {
                saldo = saldo - valor;
            }
        }

        // exercicio 6
        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é de R$ {saldo}");
        }
    }
}
