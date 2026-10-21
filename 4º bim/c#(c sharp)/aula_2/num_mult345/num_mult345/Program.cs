int cont3 = 0, cont4 = 0, cont5 = 0, n;
for (int i = 1; i <= 20; i++)
{
    Console.WriteLine("Digite um número: ");
    n = int.Parse(Console.ReadLine());

    if (n % 3 == 0)
        cont3++;

    if (n % 4 == 0)
        cont4++;

    if (n % 5 == 0)
        cont5++;
}
Console.WriteLine("Múltiplos de 3: " + cont3);
Console.WriteLine("Múltiplos de 4: " + cont4);
Console.WriteLine("Mútiplos de 5: " + cont5);
