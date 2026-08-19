int pos=0, neg=0, num=0;

for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite um numero: ");
    num = int.Parse(Console.ReadLine());


    if (num < 0)
    {
        neg++;
    }
    else
    {
        pos++;
    }
}

Console.WriteLine("Quantidade de valores positivos:" + pos);
Console.WriteLine("Quantidade de valores negativos:" + neg);