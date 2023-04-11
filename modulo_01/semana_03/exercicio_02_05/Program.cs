using exercicio2_5;
using exercicio2_5.Classes;

ContaBancaria conta1 = new ContaBancaria(1212, 1555, "Rafael", TipoContaEnum.CORRENTE);
ContaBancaria conta2 = new ContaBancaria(1313, 1555, "Rafael", TipoContaEnum.CORRENTE);

// exemplo de teste de transferencia e exibição de saldo
conta1.Depositar(500);
conta1.Transferir(conta2, 50);
conta1.ExibirSaldo();
conta2.ExibirSaldo();