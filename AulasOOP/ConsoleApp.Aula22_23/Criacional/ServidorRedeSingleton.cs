namespace ConsoleApp.Aula22_23.Criacional {
    public class ServidorRedeSingleton {
        public static Lazy<ServidorRedeSingleton> Instance { get; set; } = new Lazy<ServidorRedeSingleton>(() => new ServidorRedeSingleton());

        private ServidorRedeSingleton() { }

        public void IniciarServidor() {
            Console.WriteLine("Servidor de Rede Iniciado");
        }
    }

}
