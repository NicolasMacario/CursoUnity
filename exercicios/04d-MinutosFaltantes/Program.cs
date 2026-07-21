Console.WriteLine("Calculadora de tempo de percurso");
Console.WriteLine("Digite a distância em Km: ");
float distancia = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a velocidade(Km/h): ");
float velocidade = float.Parse(Console.ReadLine());
float time = distancia/velocidade * 60;
Console.WriteLine($"O tempo de percurso é de: {time} minutos");