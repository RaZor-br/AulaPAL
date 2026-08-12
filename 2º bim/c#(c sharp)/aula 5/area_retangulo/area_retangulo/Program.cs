float area, perim, ladoa, ladob;
Console.WriteLine("digite o lado A do retangulo: ");
ladoa = float.Parse(Console.ReadLine());
Console.WriteLine("digite o lado B do retangulo: ");
ladob = float.Parse(Console.ReadLine());

area = ladoa * ladob;
perim = 2 * ladoa + 2 * ladob;

Console.WriteLine("a area do retangulo é: " + area);
Console.WriteLine("o perimetro do retangulo é: " + perim);