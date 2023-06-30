using System.Text.RegularExpressions;

namespace ConsoleApp.Aula16_17.Extensions
{

    public static class StringExtensions
    {

        public static string Maiusculo(this string str)
        {
            return str.ToUpper();
        }

        public static string Minusculo(this string str)
        {
            return str.ToLower();
        }


        public static string RemoverEspaco(this string str)
        {
            return Regex.Replace(str, @"\s", "");
        }
    }
}
