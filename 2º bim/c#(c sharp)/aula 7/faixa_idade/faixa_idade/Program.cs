float idade;

Console.WriteLine("digite a sua idade: ");
idade = float.Parse(Console.ReadLine());

if ((idade < 1) && (idade <= 5))
{
    Console.WriteLine("você é uma criança, vá brincar!");
}
else if ((idade >= 6) && (idade <= 10))
{
    Console.WriteLine("você é um garotinho");
}
else if ((idade >= 11) && (idade <= 15))
{
    Console.WriteLine("você é um pré-adolescente");
}
else if ((idade >= 16) && (idade <= 25))
{
    Console.WriteLine("você é um jovem");
}
else if ((idade >= 26) && (idade <= 45))
{
    Console.WriteLine("você é um adulto");
}
else if ((idade >= 46) && (idade <= 60))
{
    Console.WriteLine("você é um adulto experiente");
}
else if ((idade >= 61) && (idade <= 120))
{
    Console.WriteLine("Deus fez o arrebatamento e te esqueceu");
}
else if ((idade > 120))
{
    Console.WriteLine("mortos escrevem em teclados?");
}
else
{
    Console.WriteLine("idade invalida");
}