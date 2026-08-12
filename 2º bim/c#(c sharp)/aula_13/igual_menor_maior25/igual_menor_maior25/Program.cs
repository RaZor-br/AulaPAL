float num;

Console.WriteLine("digite um numero: ");
num = float.Parse(Console.ReadLine());

if (num > 25)
{
    Console.WriteLine("o numero digitado é maior que 25");
}
else if (num == 25)
{
    Console.WriteLine("o numero digitado é igual a 25");
}
else
{
    Console.WriteLine("o numero digitado é menor que 25");
}
