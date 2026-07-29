Console.WriteLine("Digite o numero a ser calculado: ");
int num = int.Parse(Console.ReadLine());
for(int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{num}x{i} = {num * i}");
}
