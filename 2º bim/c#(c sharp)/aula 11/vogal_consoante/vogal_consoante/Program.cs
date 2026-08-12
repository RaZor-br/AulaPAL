string letra;

Console.WriteLine("Digite uma letra");
letra = Console.ReadLine();

switch (letra.ToLower())
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("A letra digitada é uma vogal");
        break;

    default:
        Console.WriteLine("A letra digitada é uma consoante");
        break;
}