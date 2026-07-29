Console.WriteLine("Você é um detetive e está encarregado do caso do Conde Leblanc, em que o Conde morreu no meio de uma festa em familia após ser atingido pelo lustre que caiu do teto, cabe a você descobrir se foi um assassinato ou uma morte acidental, Boa sorte");
Console.WriteLine("Você chega na mansão um dia antes do velório, oque você fará?");
Console.WriteLine("""
a. Falar com os Familiares
b. Falar com os funcionarios
c. Examinar o local da morte
d. checar o corpo
""");
string PrimeiraEsc = Console.ReadLine();
if(PrimeiraEsc == "a")
{
    Console.WriteLine("""
    Você chega ao meio dos familiares do conde, são 3(A mulher e os dois filhos).
    Eles estão reunidos na sala e ao entrar na sala você percebe que os dois filhos estão normais enquanto a esposa está chorando muito
    O filho mais velho chamado Everett te aborda e diz:
    """);
    Console.WriteLine("-Everett: \"Boa tarde Detetive, Obrigado por vir, acredito que nossa mãe não esteja em condições de te falar algo, mas eu e meu irmão Lay estamos a sua disposição\"");
    Console.WriteLine("""
    O que você deseja perguntar a ele?
    a. Como você está quanto a isso tudo?
    b. Onde você estava quando isso tudo aconteceu?
    c. Você acha que foi um assassinato?
    d. Você diria que alguem tinha algo contra ele?
    """);
}else if(PrimeiraEsc == "b")
{
    Console.WriteLine("");
}else if(PrimeiraEsc == "c")
{
    Console.WriteLine("");
}else if(PrimeiraEsc == "d")
{
    Console.WriteLine("");
}else
{
    Console.WriteLine("opção invalida");
    return;
}