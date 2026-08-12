float numlit, valor=0;
string tipocomb="null";

Console.WriteLine("digite o numero de litros: ");
numlit = float.Parse(Console.ReadLine());
Console.WriteLine("digite o tipo de combustivel (A/G): ");
tipocomb = Console.ReadLine();

switch (tipocomb.ToUpper())
{
	case "A":
		valor = (float)5.89 * numlit;
		tipocomb = "Alcool";
		break;
	case "G":
		valor = (float)7.39 * numlit;
		tipocomb = "Gasolina";
		break;
	default:
		Console.WriteLine("valor invalido!");
		break;
}
Console.WriteLine("O valor total é: " + valor + "R$, o tipo de combustivel é: " + tipocomb);