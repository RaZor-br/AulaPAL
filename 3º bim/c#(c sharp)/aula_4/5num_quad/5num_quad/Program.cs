for (int i = 1; i <= 5; i++)
{
    Console.Write($"Digite o " + i +"º número: ");
    float num = float.Parse(Console.ReadLine());
    num = num * num;
    Console.WriteLine("Resultado: " + num );
}