float sal, novosal=0;
string cat;

Console.WriteLine("digite a sua categoria(a,b,c)");
cat = Console.ReadLine();
Console.WriteLine("digite o seu salario");
sal = float.Parse(Console.ReadLine());

switch (cat.ToLower())
{
    case "c":
        novosal = sal + (sal * 10) / 100;
        break;
    case "b":
        novosal = sal + (sal * 15) / 100;
        break;
    case "a":
        novosal = sal + (sal * 25) / 100;
        break;
}
Console.WriteLine("seu salario antigo era R$" + sal + " e ficou R$" + novosal + " apos o reajuste");
