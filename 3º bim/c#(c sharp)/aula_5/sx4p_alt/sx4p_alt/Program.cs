int h = 0;

for (int i = 1; i <= 4; i++)
{
    Console.Write("Altura: ");
    float alt = float.Parse(Console.ReadLine());

    Console.Write("Sexo (M/F): ");
    string s = Console.ReadLine().ToUpper();

    if (s == "F")
    {
        Console.WriteLine("Altura da mulher: " + alt);
    }
    if (s == "M")
    {
        h++;
    }
}

Console.WriteLine("Quantidade de homens: " + h);