int qtdmult = 0;

for (int i = 1; i <= 750; i++)
{
    if (i % 4 == 0)
    {
        Console.WriteLine(i);
        qtdmult++;
    }
}

Console.WriteLine($"Quantidade total de múltiplos de 4: {qtdmult}");