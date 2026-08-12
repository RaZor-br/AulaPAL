float hm_peso, mu_peso, alt;
string gen="F";
Console.WriteLine("digite a sua altura: ");
alt = float.Parse(Console.ReadLine());
Console.WriteLine("digite o seu sexo(M/F): ");
gen = Console.ReadLine();

if ((gen == "F") || (gen == "f"))
{
    mu_peso = (float)(72.7 * alt) - 58;
    Console.WriteLine("o seu peso ideal é: " + mu_peso + "KG");
}
else if((gen != "M") || (gen != "m"))
{
    hm_peso = (float)((62.1 * alt) - 44.7);
    Console.WriteLine("o seu peso ideal é: " + hm_peso + "KG");
}
else
{
    Console.WriteLine("Valor Invalido, tente novamente");
}