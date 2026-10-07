int[] numeros = new int[10];

Console.WriteLine("Digite 10 números inteiros:");
for (int i = 0; i < 10; i++)
{
    int p = i + 1;
    Console.Write($"Número {p}: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 10; i++)
{
    if (numeros[i] % 2 == 0)
    {
        Console.WriteLine(numeros[i]);
    }
}