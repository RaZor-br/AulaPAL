float anoa, nasc, idd, i=1;

while(i <= 5)
{
    Console.WriteLine("digite o ano atual: ");
    anoa = float.Parse(Console.ReadLine());
    Console.WriteLine("digite o ano de nascimento: ");
    nasc = float.Parse(Console.ReadLine());

    idd = anoa - nasc;


    Console.WriteLine($"sua idade é: {idd}");
}