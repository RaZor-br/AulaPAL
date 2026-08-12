Console.BackgroundColor = ConsoleColor.White;

//comando repetição crescente
for (int i = 0; i <= 68; i++)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("N:" + i);
}

//comando repetição decrescente
for (int i = 68; i>=1; i--)
{
    Console.ForegroundColor= ConsoleColor.Blue;
    Console.WriteLine("N:" + i);
}