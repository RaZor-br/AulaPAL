//com for

float resto;
for (int i = 1; i <= 400; i++)
{
    resto = i % 2;
    if (resto == 0)
    {
        Console.WriteLine(i + " é par");
    }
}

//com while
float resto2;
int cont = 1;
while (cont <= 400)
{
    resto2 = cont % 2;
    if (resto2 == 0)
    {
        Console.WriteLine(cont + " é par");
    }
    cont++;
}
