namespace ConsoleApp.Aula18_19.Enumeradores
{
    public enum ClienteStatusEnum : byte
    {
        AGUARDANDO_PROCESSO = 1,
        EM_PROCESSO = 2,
        APROVADO = 3,
        REPROVADO = 255
    }
}
