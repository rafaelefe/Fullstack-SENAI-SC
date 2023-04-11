// [M1S01] Ex 5 - Sequência de Fibonacci
// Faça um algoritmo que receba um número inteiro que será a quantidade de números calculados pela sequência de Fibonacci. Em seguida, exiba a sequência no terminal. 

int n;
int x = 1, y = 0, z = 0;

string number = Console.ReadLine();

n = int.Parse(number);

for (int i = 0; i < n; i++)
{
    z = x + y;
    Console.WriteLine(z);
    y = x;
    x = z;
}
Console.ReadLine();

