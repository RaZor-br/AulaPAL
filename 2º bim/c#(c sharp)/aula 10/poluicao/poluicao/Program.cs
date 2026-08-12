int pol;

Console.WriteLine("digite o indice de poluição: ");
pol = int.Parse(Console.ReadLine());

switch (pol)
{
    case 0:
    case 1:
    case 2:
        Console.WriteLine("o indice de poluição esta aceitavel");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("suspenda as atividades do grupo 1");
        break;
    case 6:
    case 7:
        Console.WriteLine("suspenda as atividades dos grupos 1 e 2");
        break;
    default:
        Console.WriteLine("suspenda as atividades de todos os grupos");
        break;
}