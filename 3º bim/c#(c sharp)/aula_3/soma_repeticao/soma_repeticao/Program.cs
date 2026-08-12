float num, total=0;

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine("digite um numero: ");
    num = float.Parse(Console.ReadLine());
    total += num;
}
Console.WriteLine("o total é: " + total);