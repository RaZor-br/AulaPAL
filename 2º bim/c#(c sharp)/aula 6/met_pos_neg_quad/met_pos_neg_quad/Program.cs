float resul = 0, num;
Console.WriteLine("digite um numero: ");
num = float.Parse(Console.ReadLine());

if(num > 0)
{
    resul = num / 2;
}
else if (num == 0)
{
    Console.WriteLine("esse numero é invalido");
}
else
{
    resul = (float)Math.Pow(num, 2);
}
Console.WriteLine("o resultado é: " + resul);