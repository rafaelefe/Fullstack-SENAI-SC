using exercicio_02.Entidades;

Produto produto1 = new Produto();

produto1.nome = "Calculadora";
produto1.verificarEstoque();
Console.WriteLine("Nome do produto: " + produto1.nome);

Console.WriteLine("----------------------------------------------------- \n" +
    "Abaixo apresenta valores e ações de uma classe filha \n" +
    "-----------------------------------------------------");

ProdutoFinanceiro classeFilha = new ProdutoFinanceiro();
classeFilha.acesso();
