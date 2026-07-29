int num = 6;
int numPulado = 5;
for(int i = 1; i <= 10; i++)
{
    if(i == numPulado)
    {
        continue;
    }
    Console.WriteLine($"{num}x{i} = {num * i}");
}