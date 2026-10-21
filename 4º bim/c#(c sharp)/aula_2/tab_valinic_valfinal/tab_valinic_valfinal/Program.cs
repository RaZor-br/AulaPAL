int tab, ini, fnl;

Console.WriteLine("Digite o número da tabuada: ");
tab = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor inicial: ");
ini = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor final: ");
fnl = int.Parse(Console.ReadLine());

while (ini <= fnl)
{
    Console.WriteLine(tab + " x " + ini + " = " + (tab * ini));
    ini++;
}