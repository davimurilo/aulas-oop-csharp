namespace ConsoleApp.Aula12_13.Entidades
{
    public interface ICalculadora
    {
        double Somar(double valor1, double valor2);
        double Subtrair(double valor1, double valor2);
        double Dividir(double valor1, double valor2);
        double Multiplicar(double valor1, double valor2);
    }

    public abstract class CalculoSimples : ICalculadora
    {
        public double Dividir(double valor1, double valor2) => valor1 / valor2;
        public double Multiplicar(double valor1, double valor2) => valor1 * valor2;
        public double Somar(double valor1, double valor2) => valor1 + valor2;
        public double Subtrair(double valor1, double valor2) => valor1 - valor2;
    }
    public abstract class CalculadoraAvancada : CalculoSimples
    {
        public double Potencia(double @base, double potencia) => Math.Pow(@base, potencia);
        public double RaizQuadrada(double valor) => Math.Sqrt(valor);
     
    }

    public class CalculoFinanceiro : CalculadoraAvancada
    {

    }

    public class CalculoCientifico : CalculadoraAvancada
    {

    }

    public class CalculoFinanceiroSimples : CalculoSimples  {

    }

}
