float num;

Console.WriteLine("digite um numero: ");
num = float.Parse(Console.ReadLine());

switch (num)
{
    case 2:
    case 4:
    case 6:
    case 8:
    case 10:
        Console.WriteLine("o numero é par");
        break;
    case 1:
    case 3:
    case 5:
    case 7:
    case 9:
        Console.WriteLine("o numero é impar");
        break;
    default:
        Console.WriteLine("numero invalido");
        break;
}