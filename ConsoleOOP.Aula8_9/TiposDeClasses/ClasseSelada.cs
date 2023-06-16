namespace ConsoleOOP.Aula8_9.TiposDeClasses
{

    public class Endereco
    {
        public string Rua { get; set; }
    }

    public class PessoaFisica
    {
        public string Nome { get; set; }

        public List<Endereco> Enderecos { get; set; }
    }
    public sealed class ValidacaoPessoaFisica
    {
        public ValidacaoPessoaFisica(PessoaFisica pessoaFisica)
        {
            if (string.IsNullOrEmpty(pessoaFisica.Nome))
                throw new Exception("Nome é obrigatório");
        }

    }    

}
