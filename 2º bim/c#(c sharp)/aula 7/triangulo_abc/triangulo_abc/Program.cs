float a, b, c;

Console.WriteLine("digite o valor do lado A: ");
a = float.Parse(Console.ReadLine());
Console.WriteLine("digite o valor do lado B: ");
b = float.Parse(Console.ReadLine());
Console.WriteLine("digite o valor do lado C: ");
c = float.Parse(Console.ReadLine());

if ((a == b) && (a == c) && (b == c))
{
    Console.WriteLine("o triangulo é equilatero");
}
else if ((a != b) && (a != c) && (b != c))
{
    Console.WriteLine("o triangulo é escaleno");
}
else
{
    Console.WriteLine("o triangulo é isósceles");
}