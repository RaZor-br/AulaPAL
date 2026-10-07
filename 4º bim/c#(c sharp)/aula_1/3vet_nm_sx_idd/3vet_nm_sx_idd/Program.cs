string[] nomes = new string[4];
int[] idades = new int[4];
string[] sexos = new string[4];

for (int i = 0; i < 4; i++)
{
    Console.Write("Nome: ");
    nomes[i] = Console.ReadLine();
    Console.Write("Idade: ");
    idades[i] = int.Parse(Console.ReadLine());
    Console.Write("Sexo (M/F): ");
    sexos[i] = Console.ReadLine();
}

for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"Nome: {nomes[i]} | Idade: {idades[i]} | Sexo: {sexos[i]}");
}