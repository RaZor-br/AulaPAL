float hrstrab, salbruto, salliq, valaula, perinss;
Console.WriteLine("digite o valor ganho por hora de aula");
valaula = float.Parse(Console.ReadLine());;
Console.WriteLine("digite o percentual do INSS");
perinss = float.Parse(Console.ReadLine());
Console.WriteLine("digite o numero de horas trabalhadas no mês");
hrstrab  = float.Parse(Console.ReadLine());

salbruto = (float)hrstrab * valaula;
salliq = (float)salbruto - (salbruto * perinss / 100);
Console.WriteLine("o seu salario é de: " +  salliq);