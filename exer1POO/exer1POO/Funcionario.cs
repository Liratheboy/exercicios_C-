public abstract class Funcionario
{
    protected string nome;
    protected int idade;
    protected double salarioBase;

    public Funcionario(string nome, int idade, double salarioBase)
    {
        this.nome = nome;
        this.idade = idade;
        this.salarioBase = salarioBase;
    }

    public abstract double CalcularSalario();
}
