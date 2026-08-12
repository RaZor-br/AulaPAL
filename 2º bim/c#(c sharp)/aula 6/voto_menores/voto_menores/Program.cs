float ano, idade, nascimento;

Console.WriteLine("digite o ano atual: ");
ano = float.Parse(Console.ReadLine());
Console.WriteLine("digite o seu ano de nascimento: ");
nascimento = float.Parse(Console.ReadLine());

idade = ano - nascimento;

if(idade > 16)
{
    Console.WriteLine("você tem " + idade + " anos, você pode votar");
}
else if(idade == 16)
{
    Console.WriteLine("você possui " + idade + " anos, você pode votar");
}
else
{
    Console.WriteLine("você possui " + idade + " anos você não pode votar");
}