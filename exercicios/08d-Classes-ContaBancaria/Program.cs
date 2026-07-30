Conta conta = new Conta(10000f, 5000f);
conta.Informacoes();

float saldo = conta.Saque(1500f);

if(saldo != -1)
{
    Console.WriteLine("Saque Realizado Com Sucesso");
    Console.WriteLine($"Saldo restante: R$ {saldo}");
}
else
{
    Console.WriteLine("Não foi possivel realizar o saque.");
}
saldo = conta.Deposito(100);
Console.WriteLine("Depósito Realizado com Sucesso");
Console.WriteLine($"Saldo: R$ {saldo:0.00}");

Console.WriteLine("Realizando pagamento no débito");
if(conta.Pagar("debito", 350f))
{
    Console.WriteLine("Pagamento Realizado com sucesso");
}
else
{
    Console.WriteLine("pagamento não realizado");
}
conta.Informacoes();

Console.WriteLine("Realizando pagamento no credito");
if(conta.Pagar("credito", 2300f))
{
    Console.WriteLine("Pagamento Realizado com sucesso");
}
else
{
    Console.WriteLine("Pagamento não realizado");
}
conta.Informacoes();