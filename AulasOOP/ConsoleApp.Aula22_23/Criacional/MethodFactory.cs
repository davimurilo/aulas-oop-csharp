namespace ConsoleApp.Aula22_23.Criacional {
    public interface IDispositivo {
        void ConfigurarDispositivo();
    }

    public interface ICriadorDispositivo {
        IDispositivo CriarDispositivo();
    }

    public class TV : IDispositivo {
        public void ConfigurarDispositivo() => Console.WriteLine("TV 60 Polegadas");
    }

    public class Celular : IDispositivo {
        public void ConfigurarDispositivo() {
            Console.WriteLine("Celular IPhone");
        }
    }

    public class CriadorCelular : ICriadorDispositivo {
        public IDispositivo CriarDispositivo() => new Celular();
    }

    public class Computador : IDispositivo {
        public void ConfigurarDispositivo() => Console.WriteLine("Computador Game");
    }

    public class CriadorTV : ICriadorDispositivo {
        public IDispositivo CriarDispositivo() => new TV();
    }

    public class CriadorComputador : ICriadorDispositivo {
        public IDispositivo CriarDispositivo() => new Computador();
    }

}
