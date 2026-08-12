float voto, total, c1 = 0, c2 = 0, c3 = 0, branco = 0, nulo = 0;

Console.Write("quantidade de votos: ");
total = float.Parse(Console.ReadLine());

    Console.Write("digite o voto: ");
    voto = float.Parse(Console.ReadLine());

    switch (voto)
    {
        case 1:
            c1++;
            break;
        case 2:
            c2++;
            break;
        case 3:
            c3++;
            break;
        case 0:
            branco++;
            break;
        default:
            nulo = nulo + 1;
            break;
    }

Console.WriteLine("candidato 1: " + c1);
Console.WriteLine("candidato 2: " + c2);
Console.WriteLine("candidato 3: " + c3);
Console.WriteLine("brancos: " + branco);
Console.WriteLine("nulos: " + nulo);