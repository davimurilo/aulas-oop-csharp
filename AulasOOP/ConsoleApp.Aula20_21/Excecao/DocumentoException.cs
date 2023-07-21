using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Aula20_21.Excecao {
    public class DocumentoException  : Exception {


        public string Origem { get; set; }
 

        public DocumentoException(string mensagem,string origem):base(mensagem) {
            Origem = origem;
        }
    }
}
