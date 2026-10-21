float n;
int i = 0;
while (i < 22)
{
    Console.WriteLine("Digite um número: ");
    n = float.Parse(Console.ReadLine());
    if (n > 0)
    {
        Console.WriteLine("O número é maior que zero.");
    }
    else if (n == 0)
    {
        Console.WriteLine("O número é igual a zero.");
    }
    else
    {
        Console.WriteLine("O número é menor que zero.");
    }
    i++;
}