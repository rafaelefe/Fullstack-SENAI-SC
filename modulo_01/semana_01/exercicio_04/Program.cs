// [M1S01] Ex 4 - Cálculo de média de aprovação
// Faça um programa que receba o nome e média final de cinco alunos. Armazene em um array ou list os nomes e em outra as médias. Ao final, exiba o nome de cada aluno e a mensagem “APROVADO” para quem tiver média acima de 6 e “REPROVADO” para quem não.

string[] nomeAluno = new string[5];
decimal[] mediaAluno = new decimal[5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite o nome do {i + 1}º aluno: ");
    nomeAluno[i] = Console.ReadLine();

    Console.Write($"Digite a média do {i + 1}º aluno: ");
    mediaAluno[i] = decimal.Parse(Console.ReadLine());
}

for (int i = 0; i < 5; i++)
{
    if (mediaAluno[i] >= 6)
    {
        Console.WriteLine($"O aluno {nomeAluno[i]} está APROVADO");
    }
    else
    {
        Console.WriteLine($"O aluno {nomeAluno[i]} está REPROVADO");
    }
}