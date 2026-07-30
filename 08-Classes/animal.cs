public class Animal
{
    public string size;
    public string especie;
    public string nome;
    public int idade;

    public Animal(string animalName)
    {
        nome = animalName;
        Console.WriteLine($"Criando um objeto Animal com o nome de {animalName}");
    }

    public void Comer()
    {
        Console.WriteLine($"O animal {nome} está comendo");
    }
    public int Move()
    {
        Console.WriteLine($"O animal {nome} está se movendo");

        if(size == "Pequeno")
        {
            return 2;
        }
        else if(size == "Médio")
        {
            return 4;
        }
        else if(size == "Grande")
        {
            return 8;
        }
        else
        {
            return 0;
        }
    }
    public void Brincar(Animal other)
    {
        Console.WriteLine($"O animal {nome} está brincando com {other.nome}");
    }
    public void Print()
    {
        Console.WriteLine($"""
        Animal:
        Nome: {nome}
        espécie: {especie}
        Idade: {idade}
        Porte: {size}

        """);
    }
}