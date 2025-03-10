using System.Security.Cryptography;
using ControlEscolar.View;

namespace ControlEscolar
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Application.Run(new View.Login());


            //INCIA LA APLIACION CON LA VENTANA DE INICIO 
            Login login_form = new Login();
            if (login_form.ShowDialog()== DialogResult.OK)
            {
                Application.Run(new MDI_Cotrol_escolar());
            }
        }
    }
}