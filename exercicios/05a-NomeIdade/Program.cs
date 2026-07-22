Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine();
Console.WriteLine("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());
if (idade >= 18)
{
    Console.WriteLine($"Você é maior de idade, sr. {nome}");
}
else
{
    Console.WriteLine($"Você é menor de idade, sr. {nome}");
}