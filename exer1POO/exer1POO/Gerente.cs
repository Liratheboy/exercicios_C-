public class Gerente : Funcionario, IAumentarSalario
{

    public Gerente(string nome, int idade, double salarioBase) : base(nome, idade, salarioBase) { }

    /*
    public double AumentarSalario(double porcentagem)
    {
        double aumento = salario * 0.80;
        return salario + aumento;
    }
    */
    public override double CalcularSalario()
    {
        throw new NotImplementedException();
    }
}