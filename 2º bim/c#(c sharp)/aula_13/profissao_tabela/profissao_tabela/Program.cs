float num;

Console.WriteLine("digite um numero: \n 1- Programador \n 2- Professor \n 3- administrador");
num = float.Parse(Console.ReadLine());

switch (num)
{
    case 1:
        Console.WriteLine("programador");
        break;
    case 2:
        Console.WriteLine("Professor =(");
        break;
    case 3:
        Console.WriteLine("administrador");
        break;
    default:
        Console.WriteLine("opção invalida");
        break;
}