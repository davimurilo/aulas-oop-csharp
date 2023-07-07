namespace ConsoleApp.Aula18_19.Structs
{
    public struct FiltrosStruct
    {
        public FiltrosStruct(string nome, string endereco, DateTime dataInicio, DateTime dataFim, bool status, int idade)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.dataInicio = dataInicio;
            this.dataFim = dataFim;
            this.status = status;
            this.idade = idade;
        }

        public string nome { get; set; }
        public string endereco { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataFim { get; set; }
        public  bool status { get; set; }
        public int idade { get; set; }




        public void VerCampos()
        {
            dataInicio = DateTime.Now;
        }
    }
}
