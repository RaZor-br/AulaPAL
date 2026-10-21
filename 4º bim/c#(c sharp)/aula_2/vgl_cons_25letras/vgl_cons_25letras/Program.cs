string l;

for(int i=1; i<= 25; i++)
{
    Console.WriteLine("Digite uma letra: ");
    l = Console.ReadLine();

    switch (l)
    {
        case "a":
            Console.WriteLine("Vogal");
            break;
        case "i":
            Console.WriteLine("Vogal");
            break;
        case "u":
            Console.WriteLine("Vogal");
            break;
        case "e":
            Console.WriteLine("Vogal");
            break;
        case "o":
            Console.WriteLine("Vogal");
            break;
        default:
            Console.WriteLine("Consoante");
            break;
    }
}