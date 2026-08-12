float n;
Console.WriteLine("Você é Idoso=1, Gestante=2, Cadeirante=3 outro=4");
Console.WriteLine("Digite o numero referente a você: ");
n = float.Parse(Console.ReadLine());
if (n == 1)
{
    Console.WriteLine("Você é preferencial pois você é idoso");
}
else if (n == 2)
{
    Console.WriteLine("Você é preferencial pois você é gestante");
}
else if (n == 3)
{
    Console.WriteLine("Você é preferencial pois você é cadeirante");
}
else
{
    Console.WriteLine("Você não é preferencial");
}