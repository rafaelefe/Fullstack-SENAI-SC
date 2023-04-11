namespace exercicio2_5.Classes
{
    public class ContaBancaria
    {
        // exercicio 3
        private int _numero;
        private int _agencia;
        private string _nomeTitular;
        private decimal _saldo = 0;
        private TipoContaEnum _tipoConta;

        // exercicio 2
        public ContaBancaria(int numero, int agencia, string nomeDoTitular, TipoContaEnum tipoConta)
        {
            _numero = numero;
            _agencia = agencia;
            _nomeTitular = nomeDoTitular;
            _tipoConta = tipoConta;
        }

        // exercicio 4
        public ContaBancaria(string nomeTitular, TipoContaEnum tipoConta)
        {
            Random random = new Random();

            _numero = random.Next(0000, 9999);
            _agencia = random.Next(0000, 9999);

            _nomeTitular = nomeTitular;
            _tipoConta = tipoConta;
        }

        // exercicio 5
        public void Transferir(ContaBancaria conta, decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0!");
                return;
            }

            if (valor > _saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
                return;
            }

            _saldo = _saldo - valor;
            conta.Depositar(valor);

            Console.WriteLine($"Valor de R$ {valor} transferido com sucesso!");
        }

        // exercicio anteriores
        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
            }
            else
            {
                _saldo = _saldo + valor;
            }
        }

        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");

            }
            else if (valor > _saldo)
            {
                Console.WriteLine("O valor é maior do que o saldo atual!");

            }
            else
            {
                _saldo = _saldo - valor;
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é de R$ {_saldo}");
        }
    }
}
