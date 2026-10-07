int n, i = 0, a;

while (i < 10) {
    Console.WriteLine("Digite um numero: ");
    n = int.Parse(Console.ReadLine());
    a = n;
    n/=3;
    Console.WriteLine($"{a} / 3 = {n}");
    i++;
}