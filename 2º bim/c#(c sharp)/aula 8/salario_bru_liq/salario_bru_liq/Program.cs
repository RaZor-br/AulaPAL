float hrstrab, valhr, salliq = 0, salbru, sal;

Console.WriteLine("quanto você ganha por hora?: ");
valhr = float.Parse(Console.ReadLine());
Console.WriteLine("quantas horas você trabalhou no mes?: ");
hrstrab = float.Parse(Console.ReadLine());

salbru = valhr * hrstrab;
if ((salbru > 1) && (salbru <= 1000))
{
    salliq = salbru - (salbru * 5) / 100;
}
else if ((salbru > 1000) && (salbru <= 4000))
{
    salliq = salbru - (salbru * 7) / 100;
}
else if (salbru > 4000)
{
    salliq = salbru - (salbru * 10) / 100;
}
else
{
    Console.WriteLine("valor invalido!");
}
Console.WriteLine("o seu salario bruto é de: " + salbru + " Reais");
Console.WriteLine("o seu salario liquido é de: " + salliq + " Reais");