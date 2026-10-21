int num, cont = 0, qtd = 0;
float resto;
while (cont <= 10)
{
    Console.WriteLine("Digite um número: ");
    num = int.Parse(Console.ReadLine());

    resto = cont % 7;
    if (resto == 0)
    {
        Console.WriteLine(cont + " É múltiplo de 7");
        qtd++;
    }
    cont++;
}
Console.WriteLine("A quantidade de múltiplos de 7 é: " + qtd);
