string[] nomes = new string[6];
string[] cargos = new string[6];
int[] idades = new int[6];

for (int i = 0; i < 6; i++)
{
    Console.Write("Nome: ");
    nomes[i] = Console.ReadLine();
    Console.Write("Cargo: ");
    cargos[i] = Console.ReadLine();
    Console.Write("Idade: ");
    idades[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 6; i++)
{
    Console.WriteLine($"Nome: {nomes[i]} | Cargo: {cargos[i]} | Idade: {idades[i]} anos");
}