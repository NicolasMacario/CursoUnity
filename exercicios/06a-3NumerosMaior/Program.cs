Console.WriteLine("Insira o primeiro Número: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira o segundo Número: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira o terceiro Número: ");
int num3 = int.Parse(Console.ReadLine());
if(num1 > num2 && num1 > num3)
{
    Console.WriteLine($"O número {num1} é maior do que {num2} e que {num3}");
}else if(num2 > num1 && num2 > num3)
{
    Console.WriteLine($"O número {num2} é maior do que {num1} e que {num3}");
}else if(num3 > num1 && num3 > num2)
{
    Console.WriteLine($"O número {num3} é maior do que {num1} e que {num2}");
}