float num1, num2, resul;

Console.WriteLine("digite o primeiro numero: ");
num1 = float.Parse(Console.ReadLine());
Console.WriteLine("digite o segundo numero: ");
num2 = float.Parse(Console.ReadLine());

resul = num1 * num2;

if  (resul >= 10)
{
    resul = (float)Math.Pow(resul, 2);
    Console.WriteLine("o resultado é: " + resul);
}
else
{
    Console.WriteLine("o numero é menor que 10");
}