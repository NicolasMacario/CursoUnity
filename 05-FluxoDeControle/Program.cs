int carteira = 500;
if (carteira >= 1000)
{
    carteira = carteira - 1000;
    Console.WriteLine($"Comprou a espada, agora você tem {carteira}");
}
else
{
    Console.WriteLine($"Você não tem dinheiro suficiente, você tem {carteira}");
}