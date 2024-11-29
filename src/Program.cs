using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ta_liberado
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configurar o DI
            var serviceProvider = ServiceConfigurator.ConfigureServices();

            // Forms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Aqui, o DI vai resolver o LoginForm e injetar as dependências
            var loginForm = serviceProvider.GetService<LoginForm>();
            Application.Run(loginForm);
        }
    }
}
