string nm;
float q1, val1, valtotal;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("digite o nome do produto: ");
nm = (string)Console.ReadLine();
Console.WriteLine("digite o valor unitario do produto: ");
val1 = float.Parse(Console.ReadLine());
Console.WriteLine("digite a quantidade do produto");
q1 = float.Parse(Console.ReadLine());

valtotal = val1 * q1;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("o valor total é: " + valtotal);