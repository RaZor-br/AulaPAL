int i, n, a=0;

Console.WriteLine("Digite um número inteiro positivo: ");
n = int.Parse(Console.ReadLine());
i = 1;

while (i <= n)
{

    Console.WriteLine($"numero: {n} contagem: {i} total: {a}");
    a+=i;
    i++;
}