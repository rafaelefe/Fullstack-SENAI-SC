/* 
1) Crie uma classe "Produto" que possui as seguintes propriedades:

Nome (string)
Preço (double)
Quantidade (int)
    
    1.1) Crie um construtor que inicializa as propriedades "Nome", "Preço" e "Quantidade". Crie um construtor padrão que inicializa o nome como "Sem Nome", o preço como 0 e a quantidade como 0.

2) Em seguida, crie uma classe "Program":
2.1)dentro dela crie um método Main()
2.2) instancia dois objetos da classe "Produto":
2.2.1) Um usando o construtor com argumentos e...
2.2.2) Outro usando o construtor padrão.
2.3) Imprima os valores das propriedades de cada objeto no terminal.
*/

using exercicio_01;

Produto produto1 = new Produto("Biscoito", 6.92, 4);
Produto produto2 = new Produto();

Console.WriteLine($"Primeiro produto - Nome: {produto1.nome}, Valor: {produto1.preco}, Quantidade: {produto1.quantidade}.");

Console.WriteLine($"Segundo produto - Nome: {produto2.nome}, Valor: {produto2.preco}, Quantidade: {produto2.quantidade}.");