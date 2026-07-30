Console.Write("Digite o primeiro número");
float num1 = float.Parse(Console.ReadLine());
Console.Write("Digite o primeiro número");
float num2 = float.Parse(Console.ReadLine());

Operacoes calc = new Operacoes();
float sum = calc.soma(num1, num2);
Console.WriteLine($"Soma: {sum}");

float sub = calc.sub(num1, num2);
Console.WriteLine($"Subtração: {sub}");

float mult = calc.mult(num1, num2);
Console.WriteLine($"Multiplicação: {mult}");

float div = calc.div(num1, num2);
Console.WriteLine($"Divisão: {div}");