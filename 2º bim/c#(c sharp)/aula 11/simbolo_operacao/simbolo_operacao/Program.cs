float resul=0, n1, n2;
string op="null";

Console.WriteLine("Digite a operação desejada(+, -, /, *): ");
op = Console.ReadLine();
Console.WriteLine("digite o primeiro numero: ");
n1 = float.Parse(Console.ReadLine());
Console.WriteLine("digite o segundo numero: ");
n2 = float.Parse(Console.ReadLine());


switch (op)
{
    case "+":
        resul = n1 + n2;

        break;
    case "-":
        resul = n1 - n2;
        break;
    case "*":
        resul = n1 * n2;
        break;
    case "/":
        resul = n1 / n2;
        break;
    default:
        Console.WriteLine("Operação Invalida");
        break;
}
Console.WriteLine("o resultado da operação é: " + resul);