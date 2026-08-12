float imc, peso, alt;

Console.WriteLine("digite o seu peso");
peso = float.Parse(Console.ReadLine());
Console.WriteLine("digite a sua altura: ");
alt = float.Parse(Console.ReadLine());

imc = (float)(peso / Math.Pow(alt, 2));

Console.WriteLine("o seu IMC é: " +  imc);