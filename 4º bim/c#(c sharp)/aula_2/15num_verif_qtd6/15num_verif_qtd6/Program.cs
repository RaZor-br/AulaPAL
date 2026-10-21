int num, cont = 0;

for (int i = 1; i <= 15; i++)
{
    Console.WriteLine("Digite um número: ");
    num = int.Parse(Console.ReadLine());

    if (num % 6 == 0)
    {
        cont++;
    }
}
Console.WriteLine("A quantidade de múltiplos de 6: " + cont);
