float num, met;

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine("digite um numero: ");
    num = float.Parse(Console.ReadLine());
    met = num / 2;
    Console.WriteLine("metade: " +  met + " inteiro: " + num);
}