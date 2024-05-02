using System;
using System.Data.Entity;
using System.Windows.Forms;
using RNG.Models;
using RNG.Views;

namespace RNG
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicializar el contexto de la base de datos
            using (var dbContext = new ApplicationDbContext())
            {
                // Ejecutar la aplicación pasando el contexto de la base de datos al formulario principal
                Application.Run(new FormularioPrincipal(dbContext));
            }
        }
    }
}
