using SeitonSystem.src.view;
using SeitonSystem.src.view.financas;
using SeitonSystem.src.view.Inicial;
using SeitonSystem.src.view.Pedido;
using SeitonSystem.view;
using System;
using System.Windows.Forms;

namespace SeitonSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InicialView());

        }
    }
}
