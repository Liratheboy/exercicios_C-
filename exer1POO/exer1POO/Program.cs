Funcionario func1 = new Diretor("Jorge", 34, 4000.0);

Diretor funci1 = (Diretor)func1;
funci1.AumentarSalario(10);

Console.WriteLine(funci1.Salario);