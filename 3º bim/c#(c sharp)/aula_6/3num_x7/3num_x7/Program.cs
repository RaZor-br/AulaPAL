int num1, mult, cont=1;

while(cont <= 3)
{
    Console.WriteLine("digite um numero: ");
    num1 = int.Parse(Console.ReadLine());

    mult = num1 * 7;

    cont++;

    Console.WriteLine($"o resultado é: {mult}");
}

//Console.WriteLine("digite o 1º numero: ");
//num1 = int.Parse(Console.ReadLine());
//Console.WriteLine("digite o 2º numero: ");
//num2 = int.Parse(Console.ReadLine());
//Console.WriteLine("digite o 3º numero: ");
//num3 = int.Parse(Console.ReadLine());

//num1 = num1 * 7;
//num2 = num2 * 7;
//num3 = num3 * 7;

//Console.WriteLine($"1º numero: {num1}");
//Console.WriteLine($"2º numero: {num2}");
//Console.WriteLine($"3º numero: {num3}");

