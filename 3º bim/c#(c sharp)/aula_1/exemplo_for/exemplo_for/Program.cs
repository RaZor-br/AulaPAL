float voto, cd1=0, cd2=0, cd3=0;

Console.WriteLine("eleições etec 2026");

for/*repetição condicional*/ (int i = 1/*define o inicio, o numero/dado inicial*/; i == 10/*define o limite*/; i++/*define oque vai acontecer até alcançar o limite*/)
{
    Console.WriteLine("digite seu voto \n 1 - Rayssa \n 2 - Lorena \n 3- Alice");
    voto = float.Parse(Console.ReadLine());

    switch (voto)
    {

        case 1:
            Console.WriteLine("voce votou em Rayssa");
            cd1++;
            break;
        case 2:
            Console.WriteLine("voce votou em Lorena");
            cd2++;
            break;
        case 3:
            Console.WriteLine("voce votou em Alice");
            cd3++;
            break;
        default:
            Console.WriteLine("valor invalido");
            break;
    }
}
Console.WriteLine("votos totais: \na quantidade de votos de Rayssa é: " + cd1 + "\na quantidade de votos de Lorena é: " + cd2 + "\na quantidade de votos de Alice é: " + cd3);