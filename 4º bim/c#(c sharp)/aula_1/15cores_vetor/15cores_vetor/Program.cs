string[] cor = new string[11];
int p;
for (int i = 0; i < 15; i++)
{
    p = i + 1;
    Console.WriteLine($"Digite a {p}º cor: ");
    cor[i] = Console.ReadLine();
}
for (int i = 0; i < 15; i++)
{
    p = i + 1;
    Console.WriteLine("A cor da posição " + p + "º do vetor é: " + cor[i]);
}