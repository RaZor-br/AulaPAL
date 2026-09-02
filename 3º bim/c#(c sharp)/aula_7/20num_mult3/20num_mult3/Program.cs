int i=1, num, total=0, r;

while(i <= 20)
{
    Console.WriteLine("digite um numero: ");
    num = int.Parse(Console.ReadLine());
    r = num % 3;
    if(r == 0)
    {
        total += num;
    }
    i++;
}
Console.WriteLine("A soma dos números múltiplos de 3 é: " + total);