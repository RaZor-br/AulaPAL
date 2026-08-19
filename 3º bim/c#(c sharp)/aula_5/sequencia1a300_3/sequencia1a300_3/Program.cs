int num=0, mult=0, i;

for (i = 0; i < 300; i++)
{
    num = i;
    num = num % 3;
    if (num == 0)
    {
        mult++;
  
    }
    Console.WriteLine(i);
}
Console.WriteLine("a quantidade de numeros multiplos de 3 é: " +  mult);