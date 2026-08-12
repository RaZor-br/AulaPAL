string nome;
float qtdcompr, valunit, preco, dscnt, total;
Console.WriteLine("digite o nome do produto: ");
nome = Console.ReadLine();
Console.WriteLine("digite a quantidade comprada de " + nome + ": ");
qtdcompr = float.Parse(Console.ReadLine());
Console.WriteLine("digite o preço unitario do produto: ");
valunit = float.Parse(Console.ReadLine());

total = valunit * qtdcompr;
preco = total - (total * 3) / 100;
Console.WriteLine("o valor total do produto " + nome + " é: " + preco);