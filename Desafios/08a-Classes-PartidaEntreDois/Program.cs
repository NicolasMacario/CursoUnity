Placar placar = new Placar("Fulano", "Cicrano", 5);

Console.WriteLine("Iniciando");

bool Acabou = false;
while (!Acabou)
{
    Console.Write("Qual jogador pontuou?");
    int player = int.Parse(Console.ReadLine());
    Acabou = placar.AddScore(player, 1);
}

Player vencedor = placar.Vencedor();
Console.WriteLine($"Fim de jogo, {vencedor.nome} venceu");