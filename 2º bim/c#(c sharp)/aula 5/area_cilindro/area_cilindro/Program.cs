float vol, alt, raio;
Console.WriteLine("digite o valor do raio: ");
raio = float.Parse(Console.ReadLine());
Console.WriteLine("digite a altura do cilindro: ");
alt = float.Parse(Console.ReadLine());

vol = (float)(3.14 * Math.Pow(raio, 2) * alt);

Console.WriteLine("o volume do cilindro é: " +  vol);