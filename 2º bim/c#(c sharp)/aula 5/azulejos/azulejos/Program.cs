float ArP, ArA, QtA, AP, LP, AA, LA;
Console.WriteLine("digite a altura da parede: ");
AP = float.Parse(Console.ReadLine());
Console.WriteLine("digite a largura da parede: ");
LP = float.Parse(Console.ReadLine());
Console.WriteLine("digite a altura do azulejo: ");
AA = float.Parse(Console.ReadLine());
Console.WriteLine("digite a largura do azulejo");
LA = float.Parse(Console.ReadLine());

ArP = AP * LP;
ArA = AA * LA;
QtA = ArP / ArA;

Console.WriteLine("a area da parede é: " + ArP);
Console.WriteLine("a area do azulejo é: " + ArA);
Console.WriteLine("a quantidade de azulejos necessaria é: " + QtA);