int idade;

Console.WriteLine("digite uma idade acima de 10 anos: ");
idade = int.Parse(Console.ReadLine());

switch (idade)
{
	case 0:
	case 1:
	case 2:
	case 3:
	case 4:
	case 5:
	case 6:
	case 7:
	case 8:
	case 9:
		Console.WriteLine("voce possui " + idade + " anos, não pode entrar");
		break;

	case 10:
		Console.WriteLine("voce possui 10 anos, não pode entrar");
		break;

	case 11:
		Console.WriteLine("voce possui 11 anos, não pode entrar");
		break;

	case 12:
		Console.WriteLine("voce possui 12 anos, não pode entrar");
		break;

	case 13:
		Console.WriteLine("voce possui 13 anos, não pode entrar");
		break;

	default:
		Console.WriteLine("voce tem " + idade + " anos, voce pode entrar");
		break;
}