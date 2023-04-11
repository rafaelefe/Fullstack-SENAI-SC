// [M1S01] Ex 3 - Separador de números ímpares e pares
// Faça um programa que receba do usuário dez números inteiros e execute os seguintes passos:
// a) Separe em duas listas sendo um somente números ímpares e o outro números pares.
// b) Coloque os números de cada lista em ordem crescente.
// c) Exiba como resultado o número de elementos em cada lista e a soma dos valores de cada um. Ex: “A lista de números ímpares possui 5 números e a soma deles é igual a 47”

List<int> numerosPares = new List<int>();
List<int> numerosImpares = new List<int>();

for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite o {i + 1}º número: ");
    int num = int.Parse(Console.ReadLine());

    if (num % 2 == 0)
    {
        numerosPares.Add(num);
    }
    else
    {
        numerosImpares.Add(num);
    }
}

// ordem crescente
numerosImpares.Sort();
numerosPares.Sort();

// soma dos números de uma lista
Console.WriteLine($"A lista de números ímpares possui {numerosImpares.Count()} números e a soma deles é igual a {numerosImpares.Sum()}");
Console.WriteLine($"A lista de números pares possui {numerosPares.Count()} números e a soma deles é igual a {numerosPares.Sum()}");