float c1, c2;
string n1, n2;

Console.WriteLine("primeiro cliente, digite seu nome: ");
n1 = Console.ReadLine();
Console.WriteLine("segundo cliente, digite seu nome: ");
n2 = Console.ReadLine();
Console.WriteLine("primeiro cliente, digite seu salario: ");
c1 = float.Parse(Console.ReadLine());
Console.WriteLine("segundo cliente, digite seu salario: ");
c2 = float.Parse(Console.ReadLine());

if (c1 > c2)
{
    Console.WriteLine("o salario de " + n1 + " é maior");
}
else if (c2 > c1)
{
    Console.WriteLine("o salario de " + n2 + " é maior");
}
else
{
    Console.WriteLine("os salarios são iguais");
}