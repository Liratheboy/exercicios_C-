public class FuncionarioRegular : Funcionario, IAumentarSalario
{

    public FuncionarioRegular(string nome, int idade, double salarioBase) :base(nome, idade, salarioBase){}

    public double AumentarSalario(double porcentagem)
    {
        throw new NotImplementedException();
    }

    public override double CalcularSalario()
    {
        throw new NotImplementedException();
    }
}