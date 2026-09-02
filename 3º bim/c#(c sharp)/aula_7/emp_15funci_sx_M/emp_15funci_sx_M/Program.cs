string nm, sx;
int i=1;
while(i <= 15) {
    Console.Write("Digite o nome: ");
    nm = Console.ReadLine();

    Console.Write("Digite o genero (M/F): ");

    sx = Console.ReadLine().ToUpper();

    if (sx == "M")
    {
        Console.WriteLine($"Nome: {nm}");
        Console.WriteLine("precisa fazer exame");
    }
    else if (sx == "F")
    {
        Console.WriteLine($"Nome: {nm}");
        Console.WriteLine("não precisa fazer exame.");
    }
    else
    {
        Console.WriteLine("ERRO!!");
    }
    i++;
}