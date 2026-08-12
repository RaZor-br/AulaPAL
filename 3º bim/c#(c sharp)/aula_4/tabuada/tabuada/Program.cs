Console.Write("Digite o número da tabuada: ");
float tabuada = float.Parse(Console.ReadLine());
float num = tabuada;
for (int i = 1; i <= 10; i++)
{
    tabuada = num * i;
    Console.WriteLine(i + " * " + num + " = " + tabuada);
}