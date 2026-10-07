float ntA, ntB, media;
string nm;
int i = 0;
while (i <= 5)
{
    Console.WriteLine("Digite o nome do aluno: ");
    nm = Console.ReadLine();
    Console.WriteLine("Digite a primeira nota do aluno: ");
    ntA = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite a segunda nota do aluno: ");
    ntB = float.Parse(Console.ReadLine());

    media = (ntA + ntB) / 2;

    Console.WriteLine($"Média do aluno {nm}: {media}");
    i++;
}