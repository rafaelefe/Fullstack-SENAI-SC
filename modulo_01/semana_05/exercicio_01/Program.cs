decimal numero1;
decimal numero2;
decimal resultado;

try
{
    Console.Write("Digite o primeiro número: ");
    numero1 = decimal.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    numero2 = decimal.Parse(Console.ReadLine());

    resultado = numero1 / numero2;

    Console.WriteLine($"O resultado da divisão de {numero1} por {numero2} é {resultado}.");
}

catch (DivideByZeroException ex)
{
    Console.WriteLine($"Erro! Não é possível dividir por zero. {ex.Message}.");
}

catch (FormatException ex)
{
    Console.WriteLine($"Erro! Não é possível digitar letras. {ex.Message}");
}

catch (Exception ex)
{
    Console.WriteLine($"Erro encontrado: {ex.Message}");
}

finally
{
    numero1 = 0;
    numero2 = 0;
}