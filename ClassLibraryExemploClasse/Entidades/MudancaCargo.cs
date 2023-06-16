namespace ClassLibraryExemploClasse.Entidades
{
    internal class MudancaCargo
    {
        void MudarCargo(string cargo, Funcionario funcionario)
        {
            funcionario.Cargo = cargo;
        }
    }
}
