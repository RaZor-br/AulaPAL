float idade, maior=0;

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("digite a sua idade :");
    idade = float.Parse(Console.ReadLine());
    if (idade >= 18)
    {
        maior++;
    }
}
Console.WriteLine("existem " + maior + " pessoas maiores de idade");