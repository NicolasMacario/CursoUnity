float media = 0;
for(int i = 1; i <= 10; i++)
{
    Console.WriteLine($"aluno {i}");
    Console.WriteLine("Qual o nome do serzinho: ");
    string name = Console.ReadLine();
    Console.WriteLine("Qual a nota dele: ");
    float nota = float.Parse(Console.ReadLine());
    media = media + nota;
    Console.WriteLine($"Aluno \"{name}\" - nota {nota}");
    Console.WriteLine("------------------------------------");
}
Console.WriteLine($"A média ficou de {media / 10}");