namespace exercicio_01_06.Classes
{
    public class ContaEmpresarial : ContaBancaria
    {
        // exercicio 4
        public decimal limiteEmprestimo { get; private set; }
        public decimal taxaJuros { get; private set; }
        public bool possuiEmprestimo { get; private set; }
        public decimal valorUsado { get; private set; }
        public string CNPJ { get; private set; }

        // exercicio 3
        public ContaEmpresarial(int numero, int agencia, Cliente cliente, decimal limiteEmprestimo, decimal taxaJuros, string CNPJ) : base(numero, agencia, cliente)
        {
            if (cliente.tipoPessoa != TipoPessoaEnum.JURIDICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo Jurídico!");
            }
            // exercicio 4
            this.limiteEmprestimo = limiteEmprestimo;
            this.taxaJuros = taxaJuros;
            this.CNPJ = CNPJ;
        }

        // exercicio 5
        public void FazerEmprestimo(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0!");
                return;
            }

            if (possuiEmprestimo)
            {
                Console.WriteLine("Você já possui um empréstimo ativo!");
                return;
            }

            if (valor > limiteEmprestimo)
            {
                Console.WriteLine("O valor ultrapassa seu limite de empréstimo disponível!");
                return;
            }

            possuiEmprestimo = true;
            base.Depositar(valor);
            valorUsado = valor;
            Console.WriteLine($"Empréstimo no valor de R$ {valor} realizado com sucesso!");
        }

        public void PagarEmprestimo()
        {
            decimal total = valorUsado + (valorUsado * taxaJuros / 100);
            if (total > saldo)
            {
                Console.WriteLine("Você não tem saldo suficiente para realizar o pagamento!");
                return;
            }

            Sacar(total);
            possuiEmprestimo = false;
            valorUsado = 0;
            Console.WriteLine($"Empréstimo no valor total de R$ {total} pago com sucesso!");
        }

        // exercicio 6
        public override void Sacar(decimal valor)
        {
            valor += 1;
            base.Sacar(valor);
        }
        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            valor += 0.50M;
            base.Transferir(conta, valor);
        }
    }
}
