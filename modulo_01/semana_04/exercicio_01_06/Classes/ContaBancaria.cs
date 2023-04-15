namespace exercicio_01_06.Classes
{
    public class ContaBancaria
    {
        // exercicio 2
        public int numero { get; protected set; }
        public int agencia { get; protected set; }
        public decimal saldo { get; protected set; }
        public Cliente cliente { get; protected set; }

        public ContaBancaria(int numero, int agencia, Cliente cliente)
        {
            this.numero = numero;
            this.agencia = agencia;
            this.cliente = cliente;
        }

        public virtual void Transferir(ContaBancaria conta, decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0!");
                return;
            }

            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
                return;
            }

            saldo = saldo - valor;
            conta.Depositar(valor);

            Console.WriteLine($"Valor de R$ {valor} transferido com sucesso!");
        }

        public virtual void Depositar(decimal valor)
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

        public virtual void Sacar(decimal valor)
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

        public virtual void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é de R$ {saldo}");
        }
    }
}
