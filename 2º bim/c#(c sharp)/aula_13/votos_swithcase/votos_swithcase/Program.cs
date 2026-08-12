float votos, quantvt;
Console.WriteLine("Digite 0-votobranco 1-candidato1 2-candidato2 3-candidato");
votos = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de votos do que você escolheu");
quantvt = float.Parse(Console.ReadLine());
switch (votos)
{
    case 0:
        Console.WriteLine("O voto branco teve a quantidade de votos de " + quantvt);
        break;
    case 1:
        Console.WriteLine("O primeiro candidato teve " + quantvt + " votos ");
        break;
    case 2:
        Console.WriteLine("O segundo candidato teve " + quantvt + " votos ");
        break;
    case 3:
        Console.WriteLine("O terceiro candidato teve " + quantvt + " votos ");
        break;
    default:
        Console.WriteLine("A quantidade de votos nulos foram " + quantvt);
        break;
}