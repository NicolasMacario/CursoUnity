int vidaInimigo = 100;
do
{
    vidaInimigo = vidaInimigo - 10;
    Console.WriteLine($"Atacou o inimigo. Vida do inimigo: {vidaInimigo}");
}while (vidaInimigo > 0);
Console.WriteLine("Inimigo derrotado");