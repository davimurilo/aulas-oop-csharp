namespace ConsoleApp.SOLID.SOLID.OCP.Violacao
{
    internal class NotaFiscal
    {
        public decimal CalcularImposto(decimal valor, TipoImpostoEnum tipoImposto)
        {

            return tipoImposto switch
            {
                TipoImpostoEnum.ICMS => valor * 1.18M,
                TipoImpostoEnum.IPI => valor * 1.10M,
                TipoImpostoEnum.ISS => valor * 1.05M,
                _ => valor
            };
        }
    }

    internal enum TipoImpostoEnum
    {
        ICMS,
        IPI,
        ISS
    }
}
