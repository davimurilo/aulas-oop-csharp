

using ConsoleApp.Aula12_13.Entidades;


//FuncionarioExterno funcionarioExterno = 

ISalario funcionario = new FuncionarioExterno
{
    Cargo = "T.I",
    Nome = "João",
    Salario = 3000M
};

funcionario.AumentarSalario(10);

Console.WriteLine(funcionario.ExibirSalario());

ISalario funcionarioInterno = new FuncionarioInterno
{
    Cargo = "T.I",
    Nome = "João",
    Salario = 3000M
};


funcionarioInterno.AumentarSalario(10);

Console.WriteLine(funcionarioInterno.ExibirSalario());

IMensageria mensagemEmail = new EnviaMensagemEmail("Vendas", "teste@teste.com", "mensagem teste");

mensagemEmail.EnviaMensagem();


ICalculadora calculoFinanceiroSimples = new CalculoFinanceiroSimples();
CalculadoraAvancada calculoFinanceiro = new CalculoFinanceiro();
CalculadoraAvancada calculoCientifico = new CalculoCientifico();


Mensageiro mensageiro = new Mensageiro();

//mensageiro.EnviarMensagem(new EnviaMensagemEmail("","",""));
mensageiro.EnviarMensagem(new EnviaMensagemSimples());

Console.ReadKey();


Console.ReadLine();
