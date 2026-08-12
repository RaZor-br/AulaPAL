float id, anoa, anon, tt, anoin;
Console.WriteLine("ano atual: ");
anoa = float.Parse(Console.ReadLine());
Console.WriteLine("seu ano de nascimento?: ");
anon = float.Parse(Console.ReadLine());
Console.WriteLine("qual ano você entrou na empresa?: ");
anoin = float.Parse(Console.ReadLine());
id = anoa - anon;
tt = anoa - anoin;
if (id >= 65)
{
    Console.WriteLine("Você pode se aposentar!");
}
else if (tt >= 30)
{
    Console.WriteLine("Você pode se aposentar!");
}
else if ((id >= 60) || (tt >= 25))
{
    Console.WriteLine("Você pode se aposentar!");
}
else
{
    Console.WriteLine("Você não pode se aposentar");
}
