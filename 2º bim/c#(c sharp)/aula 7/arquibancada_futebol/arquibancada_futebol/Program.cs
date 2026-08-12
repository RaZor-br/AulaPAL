float pessoas;

Console.WriteLine("digite a quantidade de pessoas no estadio");
pessoas = float.Parse(Console.ReadLine());

if ((pessoas >= 100) && (pessoas <= 1000))  
{
    Console.WriteLine("a arquibancada esta vazia");
}
else if ((pessoas >= 1001) && (pessoas <= 15000))
{
    Console.WriteLine("a arquibancada esta meio cheia");
}
else if ((pessoas > 15000))
{
    Console.WriteLine("a arquibancada esta lotada");
}
else
{
    Console.WriteLine("a arquibancada esta fechada");
}