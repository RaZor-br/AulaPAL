//para criar um vetor de string
string[] nome = new string[4];

//armazenar dados no vetor
for(int i = 0; i < 4; i++)
{
    Console.WriteLine("digite o nome da posição " + i + "º do vetor");
    nome[i] = Console.ReadLine();
}

//para mostrar valores vetor
for(int i = 0; i < 4; i++)
{
    Console.WriteLine("O nome da posição " + i + "º do vetor é: " + nome[i]);
}