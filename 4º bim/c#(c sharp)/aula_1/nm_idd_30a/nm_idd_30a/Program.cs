string[] nomes = new string[5];
int[] idades = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write("Nome: ");
    nomes[i] = Console.ReadLine();
    Console.Write("Idade: ");
    idades[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 5; i++)
{
    if (idades[i] > 30)
    {
        Console.WriteLine($"Nome: {nomes[i]} | Idade: {idades[i]} anos");
    }
}