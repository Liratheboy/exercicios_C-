public class FuncionarioRegular : Funcionario
{

    public FuncionarioRegular(string nome, int idade, double salarioBase)
        :base(nome, idade, salarioBase){}

    public override double CalcularSalario(Funcionario funcionario)
    {
        throw new NotImplementedException();
    }
}