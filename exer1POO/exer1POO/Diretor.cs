public class Diretor : Funcionario, IAumentarSalario
{

    public Diretor(string nome, int idade, double salarioBase) : base(nome, idade, salarioBase) { }

    public double Salario { get { return salarioBase; } }

    public double AumentarSalario(double porcentagem)
    {
        porcentagem = porcentagem / 100;
        return salarioBase * porcentagem;
    }

    public override double CalcularSalario()
    {
        throw new NotImplementedException();
    }

    
}