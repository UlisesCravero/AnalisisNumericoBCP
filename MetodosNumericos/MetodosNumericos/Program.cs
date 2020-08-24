using System;
using System.Windows.Forms;
using MetodosNumericos;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Console.WriteLine(Metodos.Biseccion("x^2", -2, 4, 0.0001, 150));


        }

    }
}
