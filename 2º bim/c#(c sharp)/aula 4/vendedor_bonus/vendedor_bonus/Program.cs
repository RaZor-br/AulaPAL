float bonus, qtdvend, saltotal;
Console.WriteLine("digite a quantidade de softwares vendidos: ");
qtdvend = float.Parse(Console.ReadLine());
bonus = qtdvend * 50;
saltotal = 500 + bonus;
Console.WriteLine("seu salario é: " + saltotal);