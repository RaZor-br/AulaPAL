float num, resto;
int qt = 0;
for (int i = 1; i <= 24; i++)
{
    Console.WriteLine("Digite um número:");
    num = float.Parse(Console.ReadLine());
    resto = num % 2;
    if (resto == 0)
    {
        Console.WriteLine(num + " = Par");
        qt++;
    }
}
Console.WriteLine("A quantidade de números pares é: " + qt);
