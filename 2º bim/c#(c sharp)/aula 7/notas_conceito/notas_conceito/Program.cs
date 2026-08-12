float nota1, nota2;
string al1, al2,nota1conc="null", nota2conc="null", aoup="null";

Console.WriteLine("digite o nome do primeiro aluno: ");
al1 = Console.ReadLine();
Console.WriteLine("digite a nota do primeiro aluno: ");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("digite o nome do segundo aluno: ");
al2 = Console.ReadLine();
Console.WriteLine("digite a nota do segundo aluno: ");
nota2 = float.Parse(Console.ReadLine());

if (nota1 >= 9.0)
{
    nota1conc = "A";
}
else if ((nota1 >= 7.5) && (nota1 < 9.0))
{
    nota1conc = "B";
}
else if ((nota1 >= 6.0) && (nota1 < 7.5))
{
    nota1conc = "C";
}
else if ((nota1 >= 4.0) && (nota1 < 6.0))
{
    nota1conc = "D";
}
else if ((nota1 < 4))
{
    nota1conc = "E";
}
else
{
    Console.WriteLine("Valor Invalido");
}

if (nota2 >= 9.0)
{
    nota2conc = "A";
}
else if ((nota2 >= 7.5) && (nota2 < 9.0))
{
    nota2conc = "B";
}
else if ((nota2 >= 6.0) && (nota2 < 7.5))
{
    nota2conc = "C";
}
else if ((nota2 >= 4.0) && (nota2 < 6.0))
{
    nota2conc = "D";
}
else if ((nota2 < 4))
{
    nota2conc = "E";
}
else
{
    Console.WriteLine("Valor Invalido");
}

if ((nota1conc == "A") || (nota1conc == "B") || (nota1conc == "C"))
{
    aoup = "APROVADO";
}
else
{
    aoup = "REPROVADO";
}

if ((nota2conc == "A") || (nota2conc == "B") || (nota2conc == "C"))
{
    aoup = "APROVADO";
}
else
{
    aoup = "REPROVADO";
}

Console.WriteLine("o aluno foi " + aoup + " nota conceitual do aluno " + al1 + " é: " + nota1conc);
Console.WriteLine("o aluno foi " + aoup + " nota conceitual do aluno " + al2 + " é: " + nota2conc);