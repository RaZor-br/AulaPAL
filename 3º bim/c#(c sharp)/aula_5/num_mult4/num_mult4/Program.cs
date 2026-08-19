int num=0, mult=0, i;

for (i = 0; i <= 10; i++)
{
    Console.WriteLine("digite um numero: ");
    num = int.Parse(Console.ReadLine());

    num = num % 4;

    if(num == 0)
    {
        Console.WriteLine("este numero é multiplo de 4");
    }
    else
    {
        Console.WriteLine("este numero não é multiplo de 4");
    }
}