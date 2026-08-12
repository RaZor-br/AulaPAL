float n1, n2, opc, resul=0;

Console.WriteLine("digite o primeiro numero: ");
n1 = float.Parse(Console.ReadLine());
Console.WriteLine("digite o segundo numero: ");
n2 = float.Parse(Console.ReadLine());
Console.WriteLine("escolha alguma opção: \n  1. Média entre dois números \n  2. Diferença entre dois números \n  3. Produto entre dois números. ");
opc = float.Parse(Console.ReadLine());

switch (opc)
{
    case 1:
        resul = (n1 + n2) / 2;
        break;
    case 2:
        if(n1 > n2)
        {
            resul = n1 - n2;
        }
        else
        {
            resul = n2 - n1;
        }
        break;
    case 3:
        resul = n1 * n2;
        break;
    default:
        Console.WriteLine("operação invalida");
        break;
}
Console.WriteLine("o resultado é: " + resul);