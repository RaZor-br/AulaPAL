int numero = 799; // Primeiro ímpar menor que 800
float somaPares = 0; 

while (numero >= 0)
{

    if (numero % 2 != 0)
    {
        Console.WriteLine(numero);
    }
    else
    {
        somaPares += numero;
    }

    numero--;
}

Console.WriteLine($"resultado: {somaPares}");