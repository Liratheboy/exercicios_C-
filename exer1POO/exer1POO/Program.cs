Funcionario func1 = new Diretor("Jorge", 34, 4000.0, 200);
Funcionario func2 = new Diretor("Jorge", 34, 4000.0, 200);
Funcionario func3 = new Gerente("Jorge", 34, 4000.0, 200);
Funcionario func4 = new Gerente("Jorge", 34, 4000.0, 200);
Funcionario func5 = new Diretor("Jorge", 34, 4000.0, 200);


Diretor funci1 = (Diretor)func1;

Console.WriteLine(funci1.CalcularSalario(funci1));
Console.WriteLine(funci1.AumentarSalario(10));

Console.WriteLine(funci1.Salario);

