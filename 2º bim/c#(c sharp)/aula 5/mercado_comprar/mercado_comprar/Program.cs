string nm;
float qtmax, qtestq, qtcompr;
Console.WriteLine("digite o nome do produto: ");
nm = Console.ReadLine();
Console.WriteLine("qual a quantidade em estoque?: ");
qtestq = float.Parse(Console.ReadLine());
Console.WriteLine("digite a quantidade maxima do produto: ");
qtmax  = float.Parse(Console.ReadLine());

qtcompr = qtmax - qtestq;

Console.WriteLine("a quantidade que precisa comprar de " +  nm + " é: " + qtcompr);