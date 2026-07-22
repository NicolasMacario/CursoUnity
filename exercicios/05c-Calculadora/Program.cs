Console.WriteLine($"Digite o primeiro número: ");
float num1 = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite o segundo número: ");
float num2 = float.Parse(Console.ReadLine());
Console.WriteLine($"Qual operação você quer que seja feita?");
Console.WriteLine($"As opções são Soma(Som), Subtração(Sub), Multiplicação(Mul) e Divisão(Div)");
string op = Console.ReadLine();
if(op == "Som")
{
    Console.WriteLine($"O resultado da Soma de {num1} + {num2} = {num1 + num2}");
}
else if(op == "Sub")
{
    Console.WriteLine($"O resultado da Subtração de {num1} - {num2} = {num1 - num2}");
}
else if(op == "Mul")
{
    Console.WriteLine($"O resultado da Multiplicação de {num1} * {num2} = {num1 * num2}");
}
else if(op == "Div")
{
    Console.WriteLine($"O resultado da Divisão de {num1} / {num2} = {num1 / num2}");
}
else
{
    Console.WriteLine($"Digite uma Operação valida");
}