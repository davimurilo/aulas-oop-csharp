using Microsoft.VisualBasic;
using System.IO.Pipes;
using System.Net.Http.Headers;

namespace ConsoleOOP.Aula10_11.Entidades
{


    public abstract class DadosPessoaBase
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string NroDocumento { get; set; }

        protected DadosPessoaBase()
        {
        }
        protected DadosPessoaBase(int id, string nome, string nroDocumento)
        {
            Id = id;
            Nome = nome;
            NroDocumento = nroDocumento;
        }

        public virtual string ExibirDadosCompletos() => $"{Id} - {Nome} - {NroDocumento}";

        public abstract void FormatarDocumento();

        public abstract string Mensagem(string saudacao);

        public void Saudacao()
        {

            Console.WriteLine("Boa aula a todos");
        }
    }

    public class PessoaFisica : DadosPessoaBase
    {

        public string RG { get; set; }

        public PessoaFisica(int id, string nome, string nroDocumento, string rg)
            : base(id, nome, nroDocumento)
        {
            this.RG = rg;
        }


        public override string ToString()
            => $"{this.Id} - {this.Nome} - {this.NroDocumento} - {this.RG}";

        public override string ExibirDadosCompletos()
        {
            return $"{base.ExibirDadosCompletos()} - {this.RG}";
        }

        public override void FormatarDocumento()
        {
            NroDocumento = Convert.ToUInt64(NroDocumento).ToString(@"###\.###\.###-##");
        }


        public override string Mensagem(string saudacao)
        {
            return $"Seja bem vindo, {saudacao}";
        }
    }



    public class PessoaJuridica : DadosPessoaBase
    {
        public string InscricaoEstadual { get; set; }

        public override void FormatarDocumento()
        {
            NroDocumento = Convert.ToUInt64(NroDocumento).ToString(@"##\.###\.###/####-##");
        }

        public override string Mensagem(string saudacao)
        {
            return $"";
        }
    }

    public class PessoaFornecedor : DadosPessoaBase
    {
        public string Segmento { get; set; }
        public override void FormatarDocumento()
        {
            NroDocumento = Convert.ToUInt64(NroDocumento).ToString(@"##\.###\.###/####-##");
        }

        public override string Mensagem(string saudacao)
        {
            return $"Sem regras";
        }
    }


    public class PessoaMarketing: DadosPessoaBase
    { 

        public string Propaganda { get; set; }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public override void FormatarDocumento()
        {
            throw new NotImplementedException();
        }

        public override string Mensagem(string saudacao)
        {
            throw new NotImplementedException();
        }
    }


}
