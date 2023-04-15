using exercicio_01_06.Classes;

Cliente pessoaFisica = new Cliente("Rafael", DateTime.Parse("1993-07-20"), "Desenvolvedor", "Solteiro", TipoPessoaEnum.FISICA);

ContaCorrente contaCorrente = new ContaCorrente(1212, 1555, pessoaFisica);

contaCorrente.Depositar(500);
contaCorrente.Sacar(100);
contaCorrente.ExibirSaldo();

ContaPoupanca contaPoupanca = new ContaPoupanca(1313, 1555, pessoaFisica);

contaPoupanca.Depositar(500);
contaPoupanca.Transferir(contaCorrente, 100);
contaPoupanca.ExibirSaldo();

Cliente pessoaJuridica = new Cliente("Rafael", DateTime.Parse("1993-07-20"), "Desenvolvedor", "Solteiro", TipoPessoaEnum.JURIDICA);

ContaEmpresarial contaJuridica = new ContaEmpresarial(1414, 1555, pessoaJuridica, 2000, 10, "9999999999");

contaJuridica.FazerEmprestimo(1000);
contaJuridica.Depositar(100);
contaJuridica.ExibirSaldo();
contaJuridica.PagarEmprestimo();
contaJuridica.ExibirSaldo();