string[] nome = new string[11];
int p;
for(int i = 0; i < 11; i++)
{
    p = i + 1;
    Console.WriteLine($"Digite o {p}º nome: ");
    nome[i] = Console.ReadLine();
}
for (int i = 0; i < 11; i++)
{
    p = i + 1;
    Console.WriteLine("O nome da posição " + p + "º do vetor é: " + nome[i]);
}