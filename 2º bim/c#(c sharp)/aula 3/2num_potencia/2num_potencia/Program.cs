// See https://aka.ms/new-console-template for more information
float pot, num1, num2;
Console.WriteLine("digite o numero 1: ");
num1 = float.Parse(Console.ReadLine());
Console.WriteLine("digite o numero 2: ");
num2 = float.Parse(Console.ReadLine());
pot = (float)Math.Pow(num1, num2);
Console.WriteLine("o resultado é: " + pot);