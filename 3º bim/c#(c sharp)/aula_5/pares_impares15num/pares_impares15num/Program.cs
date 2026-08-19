int i, num, par=0;

for (i = 0; i < 15; i++)
{
    Console.WriteLine("digite um numero: ");
    num = int.Parse(Console.ReadLine());

    num = num % 2;

    if(num == 0)
    {
        par++;
    }
}
Console.WriteLine("a quantidade de numeros pares é: " + par);
