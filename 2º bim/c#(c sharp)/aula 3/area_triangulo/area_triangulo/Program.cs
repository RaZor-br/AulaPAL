float area, bse, alt;
Console.WriteLine("digite o valor da base");
bse = float.Parse(Console.ReadLine());
Console.WriteLine("digite a altura");
alt = float.Parse(Console.ReadLine());
area = (bse * alt) / 2;
Console.WriteLine("a area do triangulo é: " + area);