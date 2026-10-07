int numero;
Console.Write("Digite o número da tabuada desejada: ");
numero = int.Parse(Console.ReadLine());

int i = 1;
while (i <= 30)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
    i++;
}