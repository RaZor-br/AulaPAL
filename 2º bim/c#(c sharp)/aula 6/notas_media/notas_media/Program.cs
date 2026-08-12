float nota1al1, nota2al1, nota3al1, nota1al2, nota2al2, nota3al2, nota1, nota2;
string nm1, nm2;

Console.WriteLine("digite o nome do primeiro aluno: ");
nm1 = (Console.ReadLine());
Console.WriteLine("digite a primeira nota do aluno " + nm1 + ":");
nota1al1 = float.Parse(Console.ReadLine());
Console.WriteLine("digite a segunda nota do aluno " + nm1 + ":");
nota2al1 = float.Parse(Console.ReadLine());
Console.WriteLine("digite a terceira nota do aluno " + nm1 + ":");
nota3al1 = float.Parse(Console.ReadLine());

Console.WriteLine("digite o nome do segundo aluno: ");
nm2 = (Console.ReadLine());
Console.WriteLine("digite a primeira nota do aluno " + nm2 + ":");
nota1al2 = float.Parse(Console.ReadLine());
Console.WriteLine("digite a segunda nota do aluno " + nm2 + ":");
nota2al2 = float.Parse(Console.ReadLine());
Console.WriteLine("digite a terceira nota do aluno " + nm2 + ":");
nota3al2 = float.Parse(Console.ReadLine());

nota1 = (nota1al1 + nota2al1 + nota3al1) / 3;
nota2 = (nota1al2 + nota2al2 + nota3al2) / 3;


if (nota1 > nota2)
{
    Console.WriteLine("o aluno " + nm1 + " tirou a nota maior, com " + nota1 + " pontos");
}
else if (nota1 == nota2)
{
    Console.WriteLine("ambos tiraram a mesma nota, com " + nota1 + " pontos");
}
else
{
    Console.WriteLine("o aluno " + nm2 + " tirou a nota maior, com " + nota2 + " pontos");
}