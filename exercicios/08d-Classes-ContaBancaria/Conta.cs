public class Conta
{
    private float Saldo;
    private float Limite;
    private float Fatura;

    public Conta(float SaldoInicial, float LimiteInicial)
    {
        Saldo = SaldoInicial;
        Limite = LimiteInicial;        
    }
    public float Saque(float Amount)
    {
        if(Amount > Saldo)
        {
            return -1;
        }
        else
        {
            Saldo = Saldo - Amount;
            return Saldo;
        }
    }
    public float Deposito(float Amount)
    {
        Saldo = Saldo + Amount;
        return Saldo;
    }
    public bool Pagar(string MetPagamento, float valor)
    {
        if(MetPagamento == "debito" && valor < Saldo)
        {
            Saldo = Saldo - valor;
            return true;
        }else if(MetPagamento == "credito" && (Limite - Fatura) > valor){
            Fatura = Fatura + valor;
            return true;
        }
        else
        {
            return false;
        }
    }
    public void Informacoes()
    {
        Console.WriteLine($"""
        ==========================Conta==========================
        Saldo: R$ {Saldo:0.00}
        Limite de Crédito: R$ {Limite:0.00}
        Fatura do Cartão: R$ {Fatura:0.00}
        """);
    }
}