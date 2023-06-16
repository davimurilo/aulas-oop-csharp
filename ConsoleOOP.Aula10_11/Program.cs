
using ConsoleOOP.Aula10_11.Entidades;




PessoaJuridica pessoaJuridica = new PessoaJuridica();
pessoaJuridica.Id = 1;
pessoaJuridica.Nome = "UX";
pessoaJuridica.NroDocumento = "12345678900112";
pessoaJuridica.InscricaoEstadual = "12356892235656";
pessoaJuridica.FormatarDocumento();



PessoaFisica pessoaFisica = new(id: 1, nome: "José", nroDocumento: "12345678915", rg: "132123132");
pessoaFisica.FormatarDocumento();

Console.WriteLine(pessoaFisica.ToString());

pessoaFisica.Saudacao();

Console.WriteLine(pessoaFisica.ExibirDadosCompletos());
Console.WriteLine(pessoaJuridica.ExibirDadosCompletos());

DadosPessoaBase dadosPessoaBase = new PessoaFornecedor();

dadosPessoaBase.Id = 1;
dadosPessoaBase.Nome = "IBM";
dadosPessoaBase.NroDocumento = "12345678978954";
dadosPessoaBase.FormatarDocumento();

Console.WriteLine(dadosPessoaBase.ExibirDadosCompletos());

SaudacaoPessoa(pessoaFisica);
SaudacaoPessoa(pessoaJuridica);
SaudacaoPessoa(new PessoaFornecedor() { Nome = "Microsoft" });
SaudacaoPessoa(new PessoaMarketing() { Nome = "Facebook" });


QuemSouEu(new PessoaFornecedor { Nome = "DELL" });
QuemSouEu(new PessoaMarketing { Nome = "Instagram" });
QuemSouEu(pessoaFisica);
QuemSouEu(pessoaJuridica);

Console.ReadKey();


void SaudacaoPessoa(DadosPessoaBase pessoa)
{
    Console.WriteLine($"Bem vindo {pessoa.Nome}");
}

void QuemSouEu(DadosPessoaBase pessoa)
{

    if(pessoa is PessoaFisica fisica)
    {
        Console.WriteLine($"Sou pessoa Física : {fisica.Nome}");
        return;
    }

    if (pessoa is PessoaFornecedor fornecedor)
    {
        Console.WriteLine($"Sou pessoa Fornecedor : {fornecedor.Nome}");
        return;
    }

    if (pessoa is PessoaJuridica juridica)
    {
        Console.WriteLine($"Sou pessoa Juridica: : {juridica.Nome}");
        return;
    }


    if (pessoa is PessoaMarketing marketing)
    {
        Console.WriteLine($"Sou pessoa Marketing : {marketing.Nome}");
        return;
    }
}
