string[] elementos = new string[10];
string[] siglas = new string[10];

for (int i = 0; i < 10; i++)
{
    Console.Write("Nome do elemento químico: ");
    elementos[i] = Console.ReadLine();
    Console.Write("Sigla/Fórmula: ");
    siglas[i] = Console.ReadLine();
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{elementos[i]} = {siglas[i]}");
}