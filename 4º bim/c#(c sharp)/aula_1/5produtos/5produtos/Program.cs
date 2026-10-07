string[] produtos = new string[5];
float[] precos = new float[5];

for (int i = 0; i < 5; i++)
{
    Console.Write("Nome do produto: ");
    produtos[i] = Console.ReadLine();
    Console.Write("Preço: R$ ");
    precos[i] = float.Parse(Console.ReadLine());
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Produto: {produtos[i]} | Preço: R$ {precos[i]}");
}