using System.Reflection.Metadata.Ecma335;

public class Circulo : FiguraGeometrica, IDesenho
{
    double raio;
    public Circulo(double raio) 
    { 
        this.raio = raio; 
    }

    public override double CalcularArea(FiguraGeometrica figura)
    {
        double area = Math.PI * Math.Pow(raio, 2);
        return area;
    }

    public override double CalcularPerimetro(FiguraGeometrica figura)
    {
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }

    public void Desenhar()
    {
        throw new NotImplementedException();
    }
}
