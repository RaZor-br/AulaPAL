float ab, v, l1, l2, a;
Console.WriteLine("digite o valor do lado 1: ");
l1 = float.Parse(Console.ReadLine());
Console.WriteLine("digite o valor do lado 2: ");
l2 = float.Parse(Console.ReadLine());
v = (float)Math.Pow(l1, 3);
a = l1 * l2;
Console.WriteLine("o volume do cubo é: " + v);
Console.WriteLine("a area é: " + a);