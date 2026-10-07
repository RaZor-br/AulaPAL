string[] times = new string[7];

for (int i = 0; i < 7; i++)
{
    int p = i + 1;
    Console.Write($"Digite o nome do{p}º time: ");
    times[i] = Console.ReadLine();
}

for (int i = 0; i < 7; i++)
{
    int p = i + 1;
    Console.WriteLine($"{p}. {times[i]}");
}