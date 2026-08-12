// See https://aka.ms/new-console-template for more information
float vel, dist, temp;
Console.WriteLine("digite o tempo(em minutos): ");
temp = float.Parse(Console.ReadLine());
Console.WriteLine("digite a distancia(em quilometros: ");
dist = float.Parse(Console.ReadLine());
vel = (dist * 1000) / (temp * 60);
Console.WriteLine("a velocidade é :" + vel);