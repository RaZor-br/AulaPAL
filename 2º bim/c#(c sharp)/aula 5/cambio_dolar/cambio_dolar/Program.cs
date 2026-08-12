float dolar, real;

Console.WriteLine("digite o valor em dolar: ");
dolar = float.Parse(Console.ReadLine());

real = (float)(dolar * 5.29);

Console.WriteLine("o valor em real é: " + real);