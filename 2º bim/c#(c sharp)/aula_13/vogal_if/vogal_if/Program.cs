string letra;

Console.WriteLine("digite uma letra: ");
letra = Console.ReadLine();

if ((letra.ToLower() == "a") || (letra.ToLower() == "e") || (letra.ToLower() == "i") || (letra.ToLower() == "o") || (letra.ToLower() == "u"))
{
    Console.WriteLine("a letra é uma vogal");
}
else
{
    Console.WriteLine("a letra não é uma vogal");
}