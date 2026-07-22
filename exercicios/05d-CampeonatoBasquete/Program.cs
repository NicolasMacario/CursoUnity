Console.WriteLine("Classificatórias");
Console.WriteLine("Digite o nome do time: ");
string nome_time =Console.ReadLine();
int vitorias = 0;
int pontTotal = 0;
Console.WriteLine("Placar do jogo 1: ");
Console.WriteLine("Pontos do seu time: ");
int pontTime = int.Parse(Console.ReadLine());
Console.WriteLine("Pontos do time adversário");
int pontTimeAd = int.Parse(Console.ReadLine());
if(pontTime > pontTimeAd)
{
    vitorias = vitorias + 1;
}
pontTotal = pontTime - pontTimeAd;
Console.WriteLine("Placar do jogo 2: ");
Console.WriteLine("Pontos do seu time: ");
int pontTime2 = int.Parse(Console.ReadLine());
Console.WriteLine("Pontos do time adversário");
int pontTimeAd2 = int.Parse(Console.ReadLine());
if(pontTime2 > pontTimeAd2)
{
    vitorias = vitorias + 1;
}
pontTotal = pontTotal + (pontTime2 - pontTimeAd2);
Console.WriteLine("Placar do jogo 3: ");
Console.WriteLine("Pontos do seu time: ");
int pontTime3 = int.Parse(Console.ReadLine());
Console.WriteLine("Pontos do time adversário");
int pontTimeAd3 = int.Parse(Console.ReadLine());
if(pontTime3 > pontTimeAd3)
{
    vitorias = vitorias + 1;
}
pontTotal = pontTotal + (pontTime3 - pontTimeAd3);
if(vitorias >= 2)
{
    Console.WriteLine($"Com saldo de {pontTotal} e número de vitórias de {vitorias}, por conta disso você está classificado para o torneio");
}
else
{
    Console.WriteLine($"Com saldo de {pontTotal} e número de vitórias de {vitorias}, por isso você não conseguiu se classificar pro torneio");
}