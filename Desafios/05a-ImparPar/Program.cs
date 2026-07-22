Console.WriteLine("Digite um número: ");
int num = int.Parse(Console.ReadLine());
if(num % 2 == 0){
    Console.WriteLine($"{num} é par");
}
else
{
    Console.WriteLine($"{num} é ímpar");
}