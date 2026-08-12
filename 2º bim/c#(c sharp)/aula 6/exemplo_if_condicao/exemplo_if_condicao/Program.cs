using System.ComponentModel.Design;

int num;

Console.WriteLine("digite um numero: ");
num = int.Parse(Console.ReadLine());

if (num > 80)
{
    Console.WriteLine("o numero digitado é maior que 80");
}
else if (num == 80)
{
    Console.WriteLine("o numero digitado é igual a 80");
}
else
{
    Console.WriteLine("o numero digitado é menor que 80");
}
