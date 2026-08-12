float num1, num2, num3;
Console.WriteLine("digite o primeiro numero: ");
num1 = float.Parse(Console.ReadLine());
Console.WriteLine("digite o segundo numero: ");
num2 = float.Parse(Console.ReadLine());

num3 = num1 + num2;

if(num3 > 30)
{
    Console.WriteLine("a soma dos numeros é maior que 30");
}
else if(num3 == 30)
{
    Console.WriteLine("a soma dos numeros é 30");
}
else
{
    Console.WriteLine("a soma dos numeros é menor que 30");
}