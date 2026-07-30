Retangulo ret = new Retangulo(10, 5);
float area = ret.area();
Console.WriteLine($"Área do Retangulo: {area}");
float perimetro = ret.perimetro();
Console.WriteLine($"Perimetro do retangulo: {perimetro}");

Console.WriteLine("-----------------------------------------");
Circulo circ = new Circulo(5);
area = circ.area();
Console.WriteLine($"Área do Circulo: {area}");
perimetro = circ.perimetro();
Console.WriteLine($"Perimetro do Círculo: {perimetro}");

Console.WriteLine("-----------------------------------------");
Triangulo tri = new Triangulo(10, 10, 10);
perimetro = tri.perimetro();
Console.WriteLine($"Perimetro do Triângulo: {perimetro}");
string tipo = tri.tipo();
Console.WriteLine($"O tipo do triângulo é: {tipo}");