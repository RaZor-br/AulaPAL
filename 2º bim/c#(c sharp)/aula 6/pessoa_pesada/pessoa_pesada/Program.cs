float ps1, ps2;
string nm1, nm2;

Console.WriteLine("digite o nome da primeira pessoa: ");
nm1 = Console.ReadLine();
Console.WriteLine("digite o nome da segunda pessoa: ");
nm2 = Console.ReadLine();
Console.WriteLine("digite o peso da primeira pessoa(em Kilos): ");
ps1 = float.Parse(Console.ReadLine());
Console.WriteLine("digite o peso da segunda pessoa(em Kilos): ");
ps2 = float.Parse(Console.ReadLine());

if (ps1 > ps2)
{
    Console.WriteLine(nm1 + " é mais pesado(a), com " + ps1 + "kg");
}
else if (ps2 == ps1)
{
    Console.WriteLine("ambos tem o mesmo peso, com " + ps1 + "kg.");
}
else
{
    Console.WriteLine(nm2 + " é mais pesado(a), com " + ps2 + "kg");
}