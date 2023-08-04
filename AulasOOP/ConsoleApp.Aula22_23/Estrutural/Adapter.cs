namespace ConsoleApp.Aula22_23.Estrutural {
    public class ImpostoSaoPauloICMS {
        public virtual double CalcularImposto(double valor) => valor * 0.18;
    }

    public class ImpostoISSAdapter : ImpostoSaoPauloICMS {
        private readonly ImpostoSaoPauloISS impostoSaoPauloISS = new();

        public override double CalcularImposto(double valor)
        => impostoSaoPauloISS.CalcularImpostoISS(valor);
    }

    public class ImpostoSaoPauloISS {
        public double CalcularImpostoISS(double valor)
        => valor * 0.05;
    }

}
