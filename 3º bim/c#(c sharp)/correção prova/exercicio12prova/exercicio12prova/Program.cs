string nome, sexo;
int cont = 1;

while(cont <= 30)
{
    Console.WriteLine("Digite o nome do funcionario: ");
    nome = Console.ReadLine();
    Console.WriteLine("Digite o sexo do funcionario (M/F): ");
    sexo = Console.ReadLine();

    if((sexo == "M") || (sexo == "m"))
    {
        Console.WriteLine("você é do sexo masculino, precisa fazer o exame" + nome);
    }
    else if ((sexo == "F") || (sexo == "f"))
    {
        Console.WriteLine("você é do sexo feminino, não precisa fazer o exame" + nome);
    }
    else
    {
        Console.WriteLine("Sexo inválido. Por favor, digite M ou F.");
    }
    cont++;
}