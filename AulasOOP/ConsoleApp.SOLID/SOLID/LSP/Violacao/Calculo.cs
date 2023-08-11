namespace ConsoleApp.SOLID.SOLID.LSP.Violacao {
    internal class CalculoBase {
        
        public virtual int Somar(int valor1, int valor2) {

            return valor1 + valor2;
        }
    }
    
    internal class Calculo : CalculoBase {

        public override int Somar(int valor1, int valor2) {
            return valor1 + valor2;
        }
    }
}
