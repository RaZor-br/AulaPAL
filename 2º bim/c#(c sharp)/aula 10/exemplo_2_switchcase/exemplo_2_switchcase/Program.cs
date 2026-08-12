using System.ComponentModel;

string letra;

Console.WriteLine("digite uma letra(a,b,c): ");
letra = Console.ReadLine();

switch(letra.ToLower())
{
    case "a":
        Console.WriteLine("Você escolheu Refrigerante");
        break;
    case "b":
        Console.WriteLine("Você escolheu Piroca");
        break;
    case "c":
        Console.WriteLine("Você escolheu Chocolate");
        break;
    default:
        Console.WriteLine("você deve escolher as opções a,b,c");
        break;
}