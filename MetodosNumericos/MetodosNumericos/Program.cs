using System;
using System.Windows.Forms;
using MetodosNumericos;
using org.mariuszgromada.math.mxparser;

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
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Form1());

            Console.WriteLine(Metodos.Secante("x^2", -10, 20, 0.0001, 150));


        }

    }
}
