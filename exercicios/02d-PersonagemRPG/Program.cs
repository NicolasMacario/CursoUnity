bool heroi = false;
bool vilao = false;

Console.WriteLine("Olá Querido jogador! Bem vindo ao Sword Art Online MMORPG!");
Console.WriteLine("Para começar, Digite o Nome do seu personagem: ");
string userName = Console.ReadLine();
Console.WriteLine("Agora a altura dele: ");
float userAltura = float.Parse(Console.ReadLine());
Console.WriteLine("Agora a força do seu personagem: ");
int userForca = int.Parse(Console.ReadLine());
Console.WriteLine("Agora a agilidade do seu personagem: ");
int userAgilidade = int.Parse(Console.ReadLine());
Console.WriteLine("Agora a Inteligência do seu personagem: ");
int userInteligencia = int.Parse(Console.ReadLine());
Console.WriteLine("E decida se ele será um heroi ou um vilão(h para heroi e v para vilão): ");
string userLado = Console.ReadLine();
if(userLado == "h")
{
    heroi = true;
    Console.WriteLine("Nome: " + userName);
    Console.WriteLine("Altura: " + userAltura);
    Console.WriteLine("Força: " + userForca);
    Console.WriteLine("Agilidade: " + userAgilidade);
    Console.WriteLine("Inteligência: " + userInteligencia);
    Console.WriteLine("Lado: Herói");
}
else if(userLado == "v")
{
    vilao = true;
    Console.WriteLine("Nome: " + userName);
    Console.WriteLine("Altura: " + userAltura + " metros");
    Console.WriteLine("Força: " + userForca);
    Console.WriteLine("Agilidade: " + userAgilidade);
    Console.WriteLine("Inteligência: " + userInteligencia);
    Console.WriteLine("Lado: Vilão");
}
else
{
    Console.WriteLine("Opção inválida, por favor reinicie o jogo e tente novamente.");
    return;
}
