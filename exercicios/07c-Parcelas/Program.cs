Console.WriteLine("Digite o valor do produto: ");
float valor = float.Parse(Console.ReadLine());
Console.WriteLine("Tabela de parcelas: ");
for(int i = 2; i <= 12; i++)
{
    Console.WriteLine($"{i}x de R${valor / i:0.00}");
}