public class Retangulo
{
    public float altura;
    public float largura;

    public Retangulo(float altura, float largura)
    {
        this.altura = altura;
        this.largura = largura;
    }
    public float area()
    {
        return altura * largura;
    }
    public float perimetro()
    {
        return (altura + largura) * 2;
    }
}