float num=0, total = 0, i=1;

while(i <= 5)
{
    Console.WriteLine("digite um numero: ");
    num = float.Parse(Console.ReadLine());
    total += num;
    i++;
}
Console.WriteLine("o total é: " + total);