int i = 1, num;

while(i <= 7)
{
    Console.Write("Digite um número: ");
    num = int.Parse(Console.ReadLine());

    if(num % 2 == 0)
    {
        num = (int)Math.Pow(num, 2);
    }
    else
    {
        num = (int)Math.Pow(num, 3);
    }

    Console.WriteLine(num);
    i++;
}