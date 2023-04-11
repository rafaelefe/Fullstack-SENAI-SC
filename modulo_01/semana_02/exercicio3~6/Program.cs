using exercicio3_6;
using exercicio3_6.Classes;

ContaBancaria conta = new ContaBancaria();

conta.numero = 1000;
conta.agencia = 1555;
conta.nomeTitular = "Rafael";
conta.tipoConta = TipoContaEnum.CORRENTE;

conta.Depositar(500);
conta.Sacar(100);
conta.ExibirSaldo();
