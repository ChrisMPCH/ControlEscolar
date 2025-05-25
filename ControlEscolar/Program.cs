using System.Security.Cryptography;
using ControlEscolar.View;
using NLog;
using ControlEscolarCore.Utilities;

namespace ControlEscolar
{
    internal static class Program
    {
        private static Logger? _Logger;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Inicializa la configuracion del sistema de log
            _Logger = LoggingManager.GetLogger("ControlEscolar.program");
            _Logger.Info("Starting application");

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