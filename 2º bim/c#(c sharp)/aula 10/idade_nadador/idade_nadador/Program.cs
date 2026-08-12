int num;

Console.WriteLine("digite a sua idade: ");
num = int.Parse(Console.ReadLine());

switch (num)
{
    case 5:
    case 6:
    case 7:
        Console.WriteLine("você esta na categoria infantil A");
        break;
    case 8:
    case 9:
    case 10:
    case 11:
        Console.WriteLine("você esta na categoria infantil B");
        break;
    case 12:
    case 13:
        Console.WriteLine("você esta na categoria juvenil A");
        break;
    case 14:
    case 15:
    case 16:
    case 17:
        Console.WriteLine("você esta na categoria juvenil B");
        break;
    default:
        Console.WriteLine("voce esta na categoria para adultos");
        break;
}