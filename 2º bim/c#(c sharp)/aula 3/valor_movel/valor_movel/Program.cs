// See https://aka.ms/new-console-template for more information
float valtotal, val, taxa, parc;
Console.WriteLine("digite o valor da prestação: ");
val = float.Parse(Console.ReadLine());
Console.WriteLine("digite o valor das taxas: ");
taxa = float.Parse(Console.ReadLine());
Console.WriteLine("digite a quantidade de parcelas: ");
parc = float.Parse(Console.ReadLine());
valtotal = val + (val * (taxa / 100) * parc);
Console.WriteLine("o valor total é: " + valtotal);  