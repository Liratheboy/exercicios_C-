using System.Reflection.Metadata.Ecma335;

public class Triangulo : FiguraGeometrica, IDesenho
{

    double lado1;
    double lado2;
    double lado3;

    public Triangulo(double lado1, double lado2, double lado3)
    {
        this.lado1 = lado1;
        this.lado2 = lado2;
        this.lado3 = lado3;
    }

    public override double CalcularArea(FiguraGeometrica figura)
    {
        double area = (lado1 * lado2) / 2 ;
        return area;
    }

    public override double CalcularPerimetro(FiguraGeometrica figura)
    {
        double perimetro = lado1 + lado2 + lado3;
        return perimetro;
    }

    public void Desenhar()
    {
        throw new NotImplementedException();
    }
}
