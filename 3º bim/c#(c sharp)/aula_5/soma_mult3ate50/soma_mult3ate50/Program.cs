int i, num=0, mult=0;

for (i = 1; i <= 50; i++)
{
    if (i % 3 == 0)
    {
        mult = mult + i;
    }
}
Console.WriteLine("o resultado é: " + mult);