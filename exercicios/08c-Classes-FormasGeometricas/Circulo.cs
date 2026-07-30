public class Circulo
{
    public float raio;
    public Circulo(float raio)
    {
        this.raio = raio;
    }
    public float area()
    {
        return 3.14f * (raio * raio);
    }
    public float perimetro()
    {
        return 2 * 3.14f *raio;
    }
}