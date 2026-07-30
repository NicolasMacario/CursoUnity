Animal macaco = new Animal("Georgie"){
size = "Médio",
especie = "Homo-Sapiens-cerebulus",
idade = 15
};

Animal arara = new Animal("Tu é gay man?"){
size = "Pequeno",
especie = "Tuésgays-manus",
idade = 4
};

Animal giraffa = new Animal("Sua familia não te ama não?"){
size = "Grande",
especie = "Suasfamiliasnão-teamais",
idade = 33
};

macaco.Print();
arara.Print();
giraffa.Print();

macaco.Comer();
arara.Comer();
giraffa.Comer();

int distance = macaco.Move();
Console.WriteLine($"O macaco andou {distance} M");
distance = arara.Move();
Console.WriteLine($"A Arara andou {distance} M");
distance = giraffa.Move();
Console.WriteLine($"A Giraffa andou {distance} M");

macaco.Brincar(arara);