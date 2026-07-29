bool gest = false;
bool pcd = false;
Console.WriteLine("Quantos anos você tem? ");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine("Você é gestante?");
string resp = Console.ReadLine();
if(resp == "sim")
{
    gest = true;
}
Console.WriteLine("Você é PCD?");
string resp2 = Console.ReadLine();
if(resp2 == "sim")
{
    pcd = true;
}
if(idade >= 60 || pcd || gest)
{
    Console.WriteLine($"""
    Você recebera atendimento prioritario pois se encaixa em algum dos criterios que são:
    ter 60 anos ou mais(Você tem {idade})
    Ser gestante({gest})
    Ser PCD({pcd})
    """);
}
else
{
    Console.WriteLine("Você recebera o atendimento comum");
}