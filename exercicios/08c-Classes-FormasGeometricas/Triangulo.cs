public class Triangulo
{
    public float a;
    public float b;
    public float c;

    public Triangulo(float a, float b, float c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public float perimetro()
    {
        return a + b + c;
    }
    public string tipo()
    {
        if(a != b && a != c && b != c)
        {
            return "Escaleno";
        }
        else if(a == b && a == c)
        {
            return "Equilatero";
        }
        else
        {
            return "Isosceles";
        }
    }
}