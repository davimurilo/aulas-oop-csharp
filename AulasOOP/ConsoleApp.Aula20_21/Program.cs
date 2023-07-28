

using ConsoleApp.Aula20_21.Excecao;
using ConsoleApp.Aula20_21.Imutabilidades;
using ConsoleApp.Aula20_21.ObjetoValor;
using System.Text.RegularExpressions;

Cliente cliente = new Cliente("Dniel", 
    new Endereco("Rua 10", "230B", "", "Vila Augusta", "Guarulhos", "SP"),
    new EnderecoRecord("Rua 30", "15", "Bar do Zé", "Inocoop", "Guarulhos", "SP"));

Console.WriteLine(cliente.Nome);

cliente.MudarNome("Daniel");

cliente.MudarEndereco(new Endereco("Rua 10", "231B", "", "Vila Augusta", "Guarulhos", "SP"));

var enderecoNovo1 = cliente.Endereco1;

Console.WriteLine(ReferenceEquals(enderecoNovo1, cliente.Endereco1));

cliente.MudarEndereco(new Endereco(enderecoNovo1.Rua, "232B",
    enderecoNovo1.Complemento, enderecoNovo1.Bairro, enderecoNovo1.Cidade,
    enderecoNovo1.Estado));

var enderecoNovoRecord = cliente.Endereco2 with { Numero = "20" };

Console.WriteLine(ReferenceEquals(enderecoNovoRecord, cliente.Endereco2));

cliente.MudarEndereco2(enderecoNovoRecord);

Console.WriteLine(cliente.Nome);

try {

    Pessoa pessoa = new Pessoa { Id = 1, Email = "ddd@gmail.com", NroDocumento = new Documento("12345678912") };

    Console.WriteLine(pessoa.Id);
    Console.WriteLine(pessoa.Email);
    Console.WriteLine(pessoa.NroDocumento.Valor);

    pessoa.NroDocumento = new Documento("12545465456456554");
    Console.WriteLine(pessoa.NroDocumento.Valor);

    Fornecedor fornecedor = new Fornecedor {
        CNPJ = new Documento("797"),
        Codigo = 10,
        EmailRepresentante = "dasdas@dasdas.com"
    };

}catch (DocumentoException ex) {

    Console.WriteLine($"{ex.Message } ");
    Console.WriteLine($"{ex.Source} ");
    Console.WriteLine($"{ex.StackTrace} ");
    Console.WriteLine($"{ex.Data} ");
    Console.WriteLine($"{ex.InnerException} ");
    Console.WriteLine($"{ex.HelpLink} ");

}








Console.ReadKey();


