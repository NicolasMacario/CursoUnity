Console.WriteLine("Digite o seu número de corridas oficiais: ");
int vit = int.Parse(Console.ReadLine());
Console.WriteLine("quantos campeões regionais você derrotou? ");
int camp = int.Parse(Console.ReadLine());
Console.WriteLine("Você tem o bilhete especial?");
string bil = Console.ReadLine();
if(vit >= 50 && camp >= 3 || bil == "sim")
{
    Console.WriteLine($"""
    Parabens sua inscrição para o torneio foi realizada, você atingiu algum dos criterios
    Vitorias em corridas oficias de 50 ou mais, seu número é: {vit}
    Derrotar 3 campeões regionais ou mais, sua qtd derrotada: {camp}
    Você tem o bilhete especial, você tem: {bil}
    """);
}