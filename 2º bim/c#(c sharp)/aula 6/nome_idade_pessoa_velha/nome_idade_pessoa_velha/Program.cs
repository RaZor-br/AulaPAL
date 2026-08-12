float idd1, idd2, resul;
string nm1, nm2;
Console.WriteLine("digite o nome da primeira pessoa: ");
nm1 = Console.ReadLine();
Console.WriteLine("digite a idade da primeira pessoa: ");
idd1 = float.Parse(Console.ReadLine());
Console.WriteLine("digite o nome da segunda pessoa: ");
nm2 = Console.ReadLine();
Console.WriteLine("digite a idade da segunda pessoa: ");
idd2 = float.Parse(Console.ReadLine());

if (idd1 > idd2)
{
    Console.WriteLine(nm1 + " é mais velho(a)");
}
else if(idd2 == idd1)
{
    Console.WriteLine("ambas tem a mesma idade");
}
else
{
    Console.WriteLine(nm2 + " é mais velho(a)");
}