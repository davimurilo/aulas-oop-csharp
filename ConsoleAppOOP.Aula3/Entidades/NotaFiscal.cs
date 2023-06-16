namespace ConsoleAppOOP.Aula3.Entidades
{
    public class NotaFiscal
    {
        public string TipoDocumento = "NFe";

		private string msgSucesso = "Até 100 Emissões Sua nota foi a ";
		private string msgErro = "Não houve Nota Emitida";

		private int _numero;

		public int Numero
		{
			get { 
				return _numero += 2; 
			}

			set { 
			
				if(value == 100 )
				{
					throw new Exception("Erro não pode nota 100");
				}

				_numero = value; 
			}
		}

		public string Limite { 
			
			get {

				if (_numero > 0)
				{
					return $"Até 100 Emissões Sua nota foi a {this._numero}";
				}

				return "Não houve Nota Emitida";
			} 
		}


		public string Limite2 => (_numero > 0) ? $"{msgSucesso}{this._numero}" : msgErro;
       

		public decimal Valor => 10M;

		public string Serie { get; set; } = "001";

    }
}
