public class Placar
{
    public Player player1;
    public Player player2;
    public int maxScore;
    public Placar(string nomePlayer1, string nomePlayer2, int maxScore)
    {
        player1 = new Player(nomePlayer1);
        player2 = new Player(nomePlayer2);
        this.maxScore = maxScore;
    }

    public bool AddScore(int player, int score)
    {
        if(player == 1)
        {
            player1.score += score;
        }
        else if(player == 2)
        {
            player2.score += score;
        }
        Console.WriteLine($"Placar: {player1.nome} {player1.score} X {player2.nome} {player2.score}");
        return player1.score >= maxScore || player2.score >= maxScore;
    }
    public Player Vencedor()
    {
        if(player1.score > player2.score)
        {
            return player1;
        }else if(player2.score > player1.score)
        {
            return player2;
        }
        else
        {
            return null;
        }
    }
}