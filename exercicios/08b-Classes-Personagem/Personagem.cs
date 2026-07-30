using System.Reflection.PortableExecutable;

public class Personagem
{
    public string nome;
    public int forca;
    public int agilidade;
    public int inteligencia;
    private int PV;

    public Personagem(int hp)
    {
        PV = hp; 
    }

    public void Dano(int Amount)
    {
        PV = PV - Amount;
        Console.WriteLine($"Tomou {Amount} de dano e está com {PV} pontos de vida");
        if(PV <= 0)
        {
            Console.WriteLine($"Você morreu, seu but ruim");
        }    
    }
    public void Informacoes()
    {
        Console.WriteLine($"""
        ============Tu Personaje===========
        Nome: {nome}
        Pontos de força: {forca}
        Pontos de agilidade: {agilidade}
        Pontos de inteligência: {inteligencia}
        """);
    }
}