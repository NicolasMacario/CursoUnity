int moedas = 0;
int recompensasRecebidas = 0; 
Console.WriteLine($"Saldo Inicial: {moedas}");
while(moedas < 1000){
    moedas = moedas + 100;
    recompensasRecebidas ++;
    Console.WriteLine($"Você recebeu a recompensa. Quantidade de vezes recebida: {recompensasRecebidas}");
    if(recompensasRecebidas == 5)
    {
        break;
    }
}
Console.WriteLine("Obrigado pela conversa. Vamos conversar mais algum dia");