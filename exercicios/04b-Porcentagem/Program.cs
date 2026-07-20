Console.WriteLine("Digite o valor: ");
float valor = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a porcentagem: ");
float porcentagem = float.Parse(Console.ReadLine());
float resultado = valor * (porcentagem / 100);
Console.WriteLine($"O valor de {porcentagem}% de {valor} é: {resultado}");