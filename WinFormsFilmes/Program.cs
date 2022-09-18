using WinFormsFilmes.Formularios;

namespace WinFormsFilmes
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {                       
            ApplicationConfiguration.Initialize();
            Application.Run(new FormularioFilmes());
        }
    }
}