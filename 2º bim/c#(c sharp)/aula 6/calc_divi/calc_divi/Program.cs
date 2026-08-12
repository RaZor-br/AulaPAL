float divi = 1, num1, num2;

Console.WriteLine("digite o primeiro numero: ");
num1 = float.Parse(Console.ReadLine());
Console.WriteLine("digite o segundo numero: ");
num2  = float.Parse(Console.ReadLine());

if (num1 > num2)
{
    divi = num1 / num2;
}
else if (num1 == num2)
{
    Console.WriteLine("os numeros são iguais");
}
else
{
    divi = num2 / num1;
}
Console.WriteLine("o resultado é: " + divi);