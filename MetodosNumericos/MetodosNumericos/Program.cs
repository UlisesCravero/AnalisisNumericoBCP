using System;
using System.Windows.Forms;
using MetodosNumericos;
using org.mariuszgromada.math.mxparser;
using static MetodosNumericos.Metodos;

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

            //Resultado nuevo = new Resultado();
            //nuevo = Metodos.Biseccion("(abs(x^2-4))+2*x", -4, -2, 0.0001, 100);
            //Console.WriteLine(nuevo.raiz + " " + nuevo.nro_iteraciones + " " + nuevo.error);

            

        }

    }
}
