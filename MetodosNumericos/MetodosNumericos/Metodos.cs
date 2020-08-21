using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodosNumericos
{
    public class Metodos
    {
        public static double Biseccion(string funcion, double xi_, double xd_, double tole, int iter_max)
        {
            string xi = xi_.ToString();
            string xd = xd_.ToString();
            Function f = new Function("f(x)" + "=" + funcion);
            Expression e = new Expression("f(" + xi + ")", f);
            Expression e2 = new Expression("f(" + xd + ")", f);
            double calculo_inicial = e.calculate() * e2.calculate();
            if (calculo_inicial < 0)
            {
                MessageBox.Show("Vuelva a ingresar los valores", "Parámetros inválidos");
                return 0;
            }
            else if (calculo_inicial == 0)
            {
                if (e.calculate() == 0)
                {
                    return Convert.ToDouble(xi);
                }
                else
                {
                    return Convert.ToDouble(xd);
                }
            }
            else
            {
                double x_ant = 0;
                int cont = 0;
                double xr = 0;
                double error = 0;
                while (cont < iter_max)
                {
                    cont += 1;
                    xr = (Convert.ToDouble(xi) + Convert.ToDouble(xd)) / 2;
                    error = Math.Abs((xr - x_ant) / xr);
                    Expression e3 = new Expression("f(" + xr.ToString() + ")", f);
                    if (Math.Abs(e3.calculate()) < tole || (error < tole))
                    {
                        return xr;
                    }
                    else
                    {
                        double calculo_sec = e.calculate() * e3.calculate();
                        if (calculo_sec < 0)
                        {
                            xd = Convert.ToString(xr);
                            x_ant = xr;
                        }
                        else
                        {
                            xi = Convert.ToString(xr);
                            x_ant = xr;
                        }
                    }
                }
                MessageBox.Show("Se supero el numero de iteraciones maximas permitidas", "Iteraciones maximas alcanzadas");
                return 0;
            }
        }
 /*       public double regla_falsa(string f, double xi, double xd, double tole, int iter_max)
        {

        }
        public double newton_raphson(string f, double xi, double xd, double tole, int iter_max)
        {

        }
        public double secante(string f, double xi, double xd, double tole, int iter_max)
        {

        }*/
    }
}
