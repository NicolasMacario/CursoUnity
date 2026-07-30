Console.WriteLine("==========Criador de Homo Sapiens===========");
Personagem personagem = new Personagem(100);
Console.Write("Diga-me qual teu nome: ");
personagem.nome = Console.ReadLine();
Console.Write("Diga a sua força: ");
personagem.forca = int.Parse(Console.ReadLine());
Console.Write("Diga a tua agilidade: ");
personagem.agilidade = int.Parse(Console.ReadLine());
Console.Write("Diga a tua inteligencia: ");
personagem.inteligencia = int.Parse(Console.ReadLine());

personagem.Informacoes();

personagem.Dano(10);
personagem.Dano(90);