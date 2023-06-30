using System.Text.RegularExpressions;

namespace ConsoleApp.Aula16_17.Extensions
{

    public static class NumeroExtensions
    {

        public static decimal ConverterParaDecimal(this string str)
        { 
            if(string.IsNullOrEmpty(str)) return 0;

            return decimal.TryParse(str.Replace(".", ","), out decimal valor) ? valor : 0;
        }
    }
}
