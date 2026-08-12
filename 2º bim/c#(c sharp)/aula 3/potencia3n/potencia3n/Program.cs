// See https://aka.ms/new-console-template for more information
float num1, num2, num3, soma, pot;
Console.WriteLine("digite o numero 1: ");
num1 = float.Parse(Console.ReadLine());
Console.WriteLine("digite o numero 2: ");
num2 = float.Parse(Console.ReadLine());
Console.WriteLine("digite o numero 3: ");
num3 = float.Parse(Console.ReadLine());
soma = num1 + num2 + num3;
pot = (float)Math.Pow(soma, 2);
Console.WriteLine("o resultado é: " + pot);