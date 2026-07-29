int num = 7;
int resp = -1;
while(resp != num)
{
    Console.WriteLine("Advinhe o número de 0 a 10: ");
    resp = int.Parse(Console.ReadLine());
}
Console.WriteLine("Você acertou");