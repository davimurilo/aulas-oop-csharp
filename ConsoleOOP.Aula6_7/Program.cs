// See https://aka.ms/new-console-template for more information

using ClassLibraryExemploClasse.Entidades;

Funcionario funcionario = new(nome: "Felipe", cargo: "Operacional", salario: 3500.50M, acao: "Contratar");



//funcionario.Salario = (decimal)((double)funcionario.Salario * 1.1);

Console.WriteLine(funcionario.ExibirSalario());

funcionario.AumentarSalario(salarioValor:100M);

Console.WriteLine(funcionario.ExibirSalario());

funcionario.AumentarSalario(salarioPercentual:10D);

Console.WriteLine(funcionario.ExibirSalario());

funcionario.DiminuirSalario(300M);

Console.WriteLine(funcionario.ExibirSalario());


funcionario.DiminuirSalario(5000M);

Console.WriteLine(funcionario.ExibirSalario());







Console.ReadKey();
