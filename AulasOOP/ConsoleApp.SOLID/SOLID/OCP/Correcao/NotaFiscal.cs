namespace ConsoleApp.SOLID.SOLID.OCP.Correcao {
    internal class NotaFiscal {
        public decimal CalcularImposto(decimal valor, IImposto imposto) {
            return valor * imposto.Aliquota;
        }
    }

    internal interface IImposto {
        decimal Aliquota { get; }
    }

    internal class ICMS : IImposto {
        public decimal Aliquota => 1.18M;
    }

    internal class IPI : IImposto {
        public decimal Aliquota => 1.10M;
    }

    internal class ISS : IImposto {
        public decimal Aliquota => 1.05M;
    }
}
