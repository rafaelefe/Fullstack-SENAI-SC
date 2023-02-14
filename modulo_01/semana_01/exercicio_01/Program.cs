/* 
[M1S01] Ex 1 Buscador de números primos
Faça um programa que receba do usuário dez números inteiros, e ao final, exiba os números primos e suas respectivas posições.
*/

int[] numeros = new int[10];

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Digite o {i + 1} número: ");
    numeros[i] = int.Parse(Console.ReadLine());

}

for (int i = 0; i < numeros.Length; i++)
{
    int contador = 1;

    for (int j = 1; j < numeros[i]; j++)
    {
        if (numeros[i] % j == 0)
        {
            contador++;
        }
    }

    if (contador == 2)
    {
        Console.WriteLine($"O número {numeros[i]} é um número primo e está na posição {i}");
    }
}