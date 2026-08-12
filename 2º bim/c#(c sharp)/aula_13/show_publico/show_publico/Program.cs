float pessoas;

Console.WriteLine("digite a quantidade de pessoas no estadio");
pessoas = float.Parse(Console.ReadLine());

if (pessoas < 500)
{
    Console.WriteLine("publico baixo");
}
else if (pessoas == 500)
{
    Console.WriteLine("publico medio");
}
else if ((pessoas > 500))
{
    Console.WriteLine("publico bom");
}
else
{
    Console.WriteLine("o show esta fechado");
}