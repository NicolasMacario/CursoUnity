Console.WriteLine("Digite seu peso(kg): ");
float peso = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a altura(M): ");
float altura = float.Parse(Console.ReadLine());
float imc = peso/(altura*altura);
if(imc < 18.5)
{
    Console.WriteLine($"Você está abaixo do peso com imc de {imc}");
}else if(imc >= 18.5 && imc <= 24.9)
{
    Console.WriteLine($"Você está com peso normal com imc de {imc}");
}else if(imc >= 25 && imc <= 29.9)
{
    Console.WriteLine($"Você está com sobrepeso com imc de {imc}");
}else if(imc >= 30 && imc <= 34.9)
{
    Console.WriteLine($"Você está com Obesidade grau I com imc de {imc}");
}else if(imc >= 35 && imc <= 39.9)
{
    Console.WriteLine($"Você está com Obesidade grau II com imc de {imc}");
}else if(imc >= 40 && imc <= 49.9)
{
    Console.WriteLine($"Você está com Obesidade grau III com imc de {imc}");
}else if(imc >= 50 && imc <= 59.9)
{
    Console.WriteLine($"Você está com Obesidade grau IV com imc de {imc}");
}else if(imc > 60)
{
    Console.WriteLine($"Você está com Obesidade grau V com imc de {imc}");
}