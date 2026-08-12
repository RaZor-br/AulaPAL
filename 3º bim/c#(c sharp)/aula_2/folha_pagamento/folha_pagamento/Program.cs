using System;
using System.Globalization;

CultureInfo culturaPt = new CultureInfo("pt-BR");

float salbase=0, salmin=0, hrsextra=0, insalub=0, opcinsalub, valinss = 0,salliq=0, percperic=0, salbruto=0, percnoturno=0;
bool peric=false, noturno=false;
string nome="null", data="null", pericsn="null", noturnosn="null", datareal = DateTime.Now.ToString("D"), insal="null";

Console.WriteLine("digite o nome do funcionario: ");
nome = Console.ReadLine();
Console.WriteLine("digite o salario base do funcionario: ");
salbase = float.Parse(Console.ReadLine());
Console.WriteLine("digite o salario minimo do funcionario: ");
salmin = float.Parse(Console.ReadLine());
Console.WriteLine("digite a data do pagamento: ");
data = Console.ReadLine();
Console.WriteLine("digite a quantidade de horas extras: ");
hrsextra = float.Parse(Console.ReadLine());
Console.WriteLine("contem periculosidade? (S/N): ");
string temp = Console.ReadLine().ToLower();

if (temp == "s" || temp == "sim" || temp == "sin" || temp == "si")
{
    peric = true;
}
else
{
    peric = false;
}

Console.WriteLine(" digite o nivel de insalubridade: \n minimo = 1 \n medio = 2 \n maximo = 3 \n não tem = 4");
opcinsalub = float.Parse(Console.ReadLine());
Console.WriteLine("é valido o adicional noturno? (S/N): ");
temp = Console.ReadLine().ToLower();

if (temp == "s" || temp == "sim" || temp == "sin" || temp == "si")
{
    noturno = true;
}
else
{
    noturno = false;
}

Console.WriteLine("digite o valor atual no INSS(2026: 5 a 20): ");
valinss = float.Parse(Console.ReadLine());

switch (opcinsalub)
{
    case 1:
        insalub = (salmin * 10) / 100;
        break;
    case 2:
        insalub = (salmin * 20) / 100;
        break;
    case 3:
        insalub = (salmin * 20) / 100;
        break;
    case 4:
        insalub = 0;
        break;
    default:
        Console.WriteLine("Valor invalido!");
        break;
}

if (peric)
{
    percperic = (salbase * 30) / 100;
}
else
{
    percperic = 0;
}

float perchrsextra = ((salbase + insalub + percperic) / 220f) * 1.5f * hrsextra;

switch (noturno)
{
    case true:
        percnoturno = (salbase * 20) / 100;
        break;
    case false:
        percnoturno = 0;
        break;
    default:
        Console.WriteLine("ERRO!");
        break;
}

salbruto = salbase + perchrsextra + insalub + percperic + percnoturno;

if (salbruto <= 1174.86)
{
    valinss = (salbruto * 8) / 100;
}
else if(salbruto >= 1174.87 && salbruto <= 1958.10)
{
    valinss = (salbruto * 9) / 100;
}
else if(salbruto > 1958.10 && salbruto < 3916.20)
{
    valinss = (salbruto * 11) / 100;
}
else if(salbruto >= 3916.20)
{
    valinss = (3916.20f * 11) / 100;
}

salliq = salbruto - valinss;

if (peric)
{
    pericsn = "Sim";
}
else
{
    pericsn = "Não";
}

if (noturno == true)
{
    noturnosn = "Sim";
}
else
{
    noturnosn = "Não";
}
switch (opcinsalub)
{
    case 1:
        insal = "Mínimo";
        break;
    case 2:
        insal = "Médio";
        break;
    case 3:
        insal = "Máximo";
        break;
    case 4:
        insal = "Não Tem";
        break;
    default:
        Console.WriteLine("Erro!");
        break;
}
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(" ===========$$$$$============ FOLHA DE PAGAMENTO======$$$$$================== \n ");
Console.WriteLine("\n ===DADOS INFORMADOS==== \n   ");
Console.WriteLine("\n Nome do Funcionário : " + nome);
Console.WriteLine("\n Mês de Referência : " + data);
Console.WriteLine("\n Data atual: " + datareal);
Console.WriteLine("\n Salário Base: R$ " + salbase);
Console.WriteLine("\n Salário Mínimo: R$ " + salmin);
Console.WriteLine("\n Horas Extras: " + hrsextra + " horas");
Console.WriteLine("\n Periculosidade: " + pericsn);
Console.WriteLine("\n Insalubridade: " + insal);
Console.WriteLine("\n Adicional Noturno: " + noturnosn);
Console.WriteLine("\n ===CÁLCULOS DO FUNCIONÁRIO===\n");
Console.WriteLine("\n Valor da Insalubridade: R$ " + insalub);
Console.WriteLine("\n Valor da Periculosidade: R$ " + percperic);
Console.WriteLine("\n Valor Hora Extra: R$ " + perchrsextra);
Console.WriteLine("\n Adicional Noturno: R$ " + percnoturno);
Console.WriteLine("\n Salário Bruto: R$ " + salbruto);
Console.WriteLine("\n Desconto INSS: R$ " + valinss);
Console.WriteLine("\n Salário Líquido: R$ " + salliq);
Console.WriteLine("\n ==========================FIM DA FOLHA DE PAGAMENTO=========================");