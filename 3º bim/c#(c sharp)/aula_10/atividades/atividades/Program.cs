// 1.
int i1 = 0;
while (i1 < 22)
{
    int n = int.Parse(Console.ReadLine());
    if (n > 0) Console.WriteLine("maior");
    if (n < 0) Console.WriteLine("menor");
    if (n == 0) Console.WriteLine("igual");
    i1++;
}

// 2.
for (int i = 0; i < 25; i++)
{
    char l = char.Parse(Console.ReadLine());
    switch (l)
    {
        case 'a':
        case 'e':
        case 'i':
        case 'o':
        case 'u':
        case 'A':
        case 'E':
        case 'I':
        case 'O':
        case 'U':
            Console.WriteLine("vogal");
            break;
        default:
            Console.WriteLine("consoante");
            break;
    }
}

// 3.
int i3 = 1;
while (i3 <= 700)
{
    if (i3 % 2 != 0) Console.WriteLine(i3);
    i3++;
}

// 4.
int pares = 0, impares = 0;
for (int i = 0; i < 24; i++)
{
    int n = int.Parse(Console.ReadLine());
    if (n % 2 == 0)
    {
        Console.WriteLine("par");
        pares++;
    }
    if (n % 2 != 0)
    {
        impares++;
    }
}
Console.WriteLine(pares);
Console.WriteLine(impares);

// 5.
int m3 = 0, m4 = 0, m5 = 0;
int i5 = 0;
for (; i5 < 20; i5++)
{
    int n = int.Parse(Console.ReadLine());
    while (n % 3 == 0) { m3++; break; }
    while (n % 4 == 0) { m4++; break; }
    while (n % 5 == 0) { m5++; break; }
}
Console.WriteLine(m3);
Console.WriteLine(m4);
Console.WriteLine(m5);

// 6.
int i6 = 1, soma = 0;
while (i6 <= 300)
{
    soma += i6;
    i6++;
}
Console.WriteLine(soma);

// 7.
int i7 = 500;
while (i7 >= 1)
{
    for (int cont = 0; cont < 1; cont++)

    {
        if (i7 % 2 != 0) Console.WriteLine(i7);
    }
    i7--;
}

// 8.
int tab = int.Parse(Console.ReadLine());
int ini = int.Parse(Console.ReadLine());
int fin = int.Parse(Console.ReadLine());
while (ini <= fin)
{
    Console.WriteLine(tab * ini);
    ini++;
}

// 9.
int i9 = 0;
while (i9 < 10)
{
    int n = int.Parse(Console.ReadLine());
    if (n % 7 == 0) Console.WriteLine("multiplo de 7");
    i9++;
}

// 10.
int m6 = 0;
for (int i = 0; i < 15; i++)
{
    int n = int.Parse(Console.ReadLine());
    if (n % 6 == 0) m6++;
}
Console.WriteLine(m6);