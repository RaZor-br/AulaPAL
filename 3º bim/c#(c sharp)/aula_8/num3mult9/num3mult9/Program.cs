int i = 1, n, resul;
while (i <= 3)
{
    Console.Write($"digite um numero: ");
    n = int.Parse(Console.ReadLine());
    resul = n * 9;
    Console.WriteLine($"{n} x 9 = {resul}");
    i++;
}