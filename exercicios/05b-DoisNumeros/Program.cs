Console.WriteLine("Digite o primeiro número: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
int num2 = int.Parse(Console.ReadLine());
if(num1 > num2)
{
    Console.WriteLine($"O número {num1} é maior que {num2}");
}else if(num1 < num2){
    Console.WriteLine($"O número {num1} é menor que {num2}");
}else if(num1 == num2)
{
    Console.WriteLine($"{num1} e {num2} são iguais");
}
