int num2, db, num = 1;

Console.Write("Digite um número: ");
num2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Dobros que são menores ou iguais a {num2}:");

while (num * 2 <= num2)
{
    db = num * 2;
    Console.WriteLine($"{num} * 2 = {db}");
    num++;
}