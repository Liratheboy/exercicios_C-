public class Diretor : Funcionario, IAumentarSalario
{

    double salarioLiquido;
    double lucro;
    public Diretor(string nome, int idade, double salarioBase, double bonificacao)
        : base(nome, idade, salarioBase)
    { 
        this.lucro = bonificacao;
    }

    public double Salario { get { return salarioLiquido; } }

    public double AumentarSalario(double porcentagem)
    {
        porcentagem = porcentagem / 100;
        double aumento = salarioBase * porcentagem;
        salarioLiquido += aumento;
        return salarioLiquido;
    }
    
    public override double CalcularSalario(Funcionario funcionario)
    {
        salarioLiquido = salarioBase + lucro;
        return salarioLiquido;
    }

}