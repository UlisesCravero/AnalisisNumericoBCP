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
            Argument xi = new Argument("x = -10");
            Argument xd = new Argument("x = 2");
            Expression e = new Expression("2*x + a - f(10)", x, a, f);
            double v = e.calculate();

            double xi = xi_;
            double xd = xd_;
            Expression e = new Expression(funcion, x);
            double calculo_inicial = e.calculate(xi) * e.calculate(xd);
            if (calculo_inicial < 0)
            {
                MessageBox.Show("Vuelva a ingresar los valores", "Parámetros inválidos");
                return 0;
            } else if (calculo_inicial == 0)
                    {
                        if (f.calculate(xi) == 0)
                        {
                            return xi;
                        } else
                        {
                            return xd;
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
                    xr = (xi + xd) / 2;
                    error = Math.Abs((xr - x_ant) / xr);
                    if (Math.Abs(f.calculate(xr)) < tole || (error < tole))
                    {
                        return xr;
                    }
                    else
                    {
                        double calculo_sec = f.calculate(xi) * f.calculate(xr);
                        if (calculo_sec < 0)
                        {
                            xd = xr;
                            x_ant = xr;
                        }
                        else
                        {
                            xi = xr;
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
