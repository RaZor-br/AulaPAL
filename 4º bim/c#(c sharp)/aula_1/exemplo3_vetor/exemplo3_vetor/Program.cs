//para criar um vetor de string
string[] nome = new string[4];
//para criar um vetor de int
int[] idade = new int[4];

//armazenar dados no vetor
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("digite o nome da posição " + i + "º do vetor");
    nome[i] = Console.ReadLine();
    Console.WriteLine("digite a idade da posição " + i + "º do vetor");
    idade[i] = int.Parse(Console.ReadLine());
}

//para mostrar valores vetor
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("O nome da posição " + i + "º do vetor é: " + nome[i]);
    Console.WriteLine("A idade armazenada na posição " + i + "º do vetor é: " + idade[i]);
}