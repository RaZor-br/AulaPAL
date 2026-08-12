float saldo, saque;
saldo = 3000;
Console.WriteLine("digite o valor do saque: ");
saque = float.Parse(Console.ReadLine());
saldo = saldo - saque;
Console.WriteLine("o seu saldo atualmente é de: " + saldo);