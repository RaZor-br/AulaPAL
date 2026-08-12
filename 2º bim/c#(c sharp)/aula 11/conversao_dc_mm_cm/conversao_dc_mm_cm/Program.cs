float conv, metros, val;

Console.WriteLine("digite a opção: ");
Console.WriteLine("1 - Decímetros");
Console.WriteLine("2 - Centímetros");
Console.WriteLine("3 - Milimetros");
conv = float.Parse(Console.ReadLine());
Console.WriteLine("digite o valor desejado em metros: ");
metros = float.Parse(Console.ReadLine());

switch (conv)
{
    case 1:
        val = (float)(metros * 10.0);
        Console.WriteLine("a conversão de metros para Decímetros é: " + val + " Decímetros");
        break;
    case 2:
        val = (float)(metros * 100.0);
        Console.WriteLine("a conversão de metros para Centímetros é: " + val + " Centímetros");
        break;
    case 3:
        val = (float)(metros * 1000.0);
        Console.WriteLine("a conversão de metros para Centimetros é: " + val + " Milimetros");
        break;
    default:
        Console.WriteLine("Numero Invalido");
        break;
}