namespace ConsoleApp.Aula22_23.Comportamental {
    internal class Strategy {

        public interface IMensageria {
            public void EnvioMensagem();
        }

        public class MensagemEmail : IMensageria {
            public void EnvioMensagem() => Console.WriteLine("Mensagem Por Email");
        }

        public class MensagemSMS : IMensageria {
            public void EnvioMensagem() => Console.WriteLine("Mensagem Por SMS");
        }

        public class MensagemWhatsApp : IMensageria {
            public void EnvioMensagem() => Console.WriteLine("Mensagem Por WhatsApp");
        }

        public class ContextoMensagem {
            private IMensageria Mensageria { get; set; }

            public ContextoMensagem Configurar(IMensageria mensageria) {
                this.Mensageria = mensageria;
                return this;
            }
            public ContextoMensagem Disparar() {
                Mensageria.EnvioMensagem();
                return this;
            }
        }

    }
}
