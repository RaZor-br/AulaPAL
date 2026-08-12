// See https://aka.ms/new-console-template for more information
float adi, sub, mult, divi, num1, num2;
Console.WriteLine("digite o numero 1: ");
num1 = float.Parse(Console.ReadLine());
Console.WriteLine("digite o numero 2: ");
num2 = float.Parse(Console.ReadLine());
adi = num1 + num2;
sub = num1 - num2;
divi = num1 / num2;
mult = num1 * num2;
Console.WriteLine("o resultado da adição é: " + adi);
Console.WriteLine("o resultado da subtração é: " + sub);
Console.WriteLine("o resultado da multiplicação é: " + mult);
Console.WriteLine("o resultado da divisão é: " + divi);

