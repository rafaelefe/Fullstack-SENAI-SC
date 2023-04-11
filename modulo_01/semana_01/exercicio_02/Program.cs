// [M1S01] Ex 2 - Organizador de lista de frutas
// Crie um programa que receba do usuário uma lista de frutas com no máximo 15 itens. Organize as frutas em ordem alfabética e exiba a lista.

List<string> listaFrutas = new List<string>();

bool continuar = true;
while (continuar)
{
    if (listaFrutas.Count() == 15)
    {
        continuar = false;
    }
    Console.Write("Digite uma fruta: ");
    listaFrutas.Add(Console.ReadLine());
    Console.Write("Deseja continuar? Responda [s] para sim ou [n] para não: ");

    string resposta = Console.ReadLine();
    if (resposta == "n" || resposta == "nao")
    {
        continuar = false;
    }
}

listaFrutas.Sort();

foreach (string fruta in listaFrutas)
{
    Console.WriteLine(fruta);
}

