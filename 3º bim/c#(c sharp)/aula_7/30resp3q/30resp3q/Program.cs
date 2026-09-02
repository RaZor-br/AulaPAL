int pt = 0, cont = 1,totalp=30;

while (cont <= totalp)
{
    Console.WriteLine($"Resposta da pessoa {cont} de {totalp}");

    Console.Write("questao 1 (A/B/C/D): ");
    string q1 = Console.ReadLine().ToUpper();
    if (q1 == "A")
    {
        pt++;
    }

    Console.Write("questao 2 (A/B/C/D): ");
    string q2 = Console.ReadLine().ToUpper();
    if (q2 == "C")
    {
        pt++;
    }

    Console.Write("questao 3 (A/B/C/D): ");
    string q3 = Console.ReadLine().ToUpper();
    if (q3 == "D")
    {
        pt++;
    }
    cont++;
}

Console.WriteLine($"pontuaçao total acumulada: {pt} ponto(s)");