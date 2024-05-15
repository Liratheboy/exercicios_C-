public class Quadrado : FiguraGeometrica, IDesenho
{

    double lado;
    public Quadrado(double lado)
    {
        this.lado = lado;
    }

    public override double CalcularArea(FiguraGeometrica figura)
    {
        double area = Math.Pow(lado, 2);
        return area;
    }

    public override double CalcularPerimetro(FiguraGeometrica figura)
    {
        double perimetro = 4 * lado;
        return perimetro;
    }

    public void Desenhar()
    {
        throw new NotImplementedException();
    }
}
