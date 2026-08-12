// See https://aka.ms/new-console-template for more information
float area, raio;
Console.WriteLine("digite o raio");
raio = float.Parse(Console.ReadLine());
area = (float)(3.14 * Math.Pow(raio, 2));
Console.WriteLine("a area é " +  area);