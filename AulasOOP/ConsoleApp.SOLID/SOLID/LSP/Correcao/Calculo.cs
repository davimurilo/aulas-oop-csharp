namespace ConsoleApp.SOLID.SOLID.LSP.Correcao {

    internal interface ICalculo {
        int Somar(int valor1, int valor2);
    }
    
    internal class CalculoBase : ICalculo {

        public int Somar(int valor1, int valor2) {

            return valor1 + valor2;
        }
    }

    internal class Calculo  {

        private ICalculo _calculoBase;

        public Calculo(ICalculo calculoBase) {
            _calculoBase = calculoBase;
        }

        public int Somar(int valor1, int valor2) 
            => _calculoBase.Somar(valor1, valor2);  
    }
}
