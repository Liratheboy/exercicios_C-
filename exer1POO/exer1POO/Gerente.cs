public class Gerente : Funcionario
{
    double bonificacao;
    double salarioLiquido;

    public Gerente(string nome, int idade, double salarioBase, double bonificacao)
        : base(nome, idade, salarioBase)
    { 
        this.bonificacao = bonificacao; 
    }

    public double AumentarSalario(double porcentagem)
    {
        porcentagem = porcentagem / 100;
        double aumento = salarioBase * porcentagem;
        salarioLiquido += aumento;
        return salarioLiquido;
    }

    public override double CalcularSalario(Funcionario funcionario)
    {
        salarioLiquido = salarioBase + bonificacao;
        return salarioLiquido;
    }
}