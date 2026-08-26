Console.Write("Digite um número: ");
int num2 = int.Parse(Console.ReadLine());

int num = 1;

Console.WriteLine($"Quadrados dos números de 1 até {num2}:");

while (num <= num2)
{
    int quad = (int)Math.Pow(num, 2);
    Console.WriteLine($"{num}² = {quad}");
    num++;
}