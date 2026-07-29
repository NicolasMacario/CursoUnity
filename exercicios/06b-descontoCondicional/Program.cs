Console.WriteLine("Qual o nome do produto?");
string nome_produto = Console.ReadLine();
Console.WriteLine("Qual o preço do produto?");
float preco_produto = float.Parse(Console.ReadLine());
Console.WriteLine("Quantos desse produto tem em estoque?");
int qtd_produto = int.Parse(Console.ReadLine());
if(qtd_produto < 10)
{
    Console.WriteLine($"O desconto aplicado é de 5% e o preço do produto será {preco_produto * 0.95}");
}
if(qtd_produto >= 10 && qtd_produto < 50)
{
    Console.WriteLine($"O desconto aplicado é de 10% e o preço do produto será {preco_produto * 0.90}");
}
if(qtd_produto >= 50 && qtd_produto < 1000)
{
    Console.WriteLine($"O desconto aplicado é de 12% e o preço do produto será {preco_produto * 0.88}");
}
if(qtd_produto >= 1000)
{
    Console.WriteLine($"O desconto aplicado é de 15% e o preço do produto será {preco_produto * 0.85}");
}