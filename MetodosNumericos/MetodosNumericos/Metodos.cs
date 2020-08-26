using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodosNumericos
{
    public class Metodos
    {
        public static double Biseccion(string funcion, double xi_, double xd_, double tole, int iter_max)
        {
            string xi = xi_.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            string xd = xd_.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            Function f = new Function("f(x)" + "=" + funcion);
            Expression e = new Expression("f(" + xi + ")", f);
            Expression e2 = new Expression("f(" + xd + ")", f);
            double calculo_inicial = e.calculate() * e2.calculate();

            if (calculo_inicial == 0)
            {
                if (e.calculate() == 0)
                    return xi_;
                else
                    return xd_;
            }
            else
            {
                if (calculo_inicial > 0)
                {
                    MessageBox.Show("Vuelva a ingresar los valores", "Parámetros inválidos");
                    return 0;
                }
                else
                {
                    double x_ant = 0;
                    int cont = 0;
                    double xr;
                    double error;
                    while (cont < iter_max)
                    {
                        cont += 1;
                        xr = (xi_ + xd_) / 2;
                        error = Math.Abs((xr - x_ant) / xr);
                        Expression e3 = new Expression("f(" + xr.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
                        if (Math.Abs(e3.calculate()) < tole || (error < tole) || cont >= iter_max)
                        {
                            return xr;
                        }
                        else
                        {
                            double calculo_sec = e.calculate() * e3.calculate();
                            if (calculo_sec < 0)
                            {
                                xd_ = xr;
                            }
                            else
                            {
                                xi_ = xr;                               
                            }
                            x_ant = xr;
                        }
                    }
                    MessageBox.Show("Se supero el numero de iteraciones maximas permitidas", "Iteraciones maximas alcanzadas");
                    return 0;
                }
            }      
        }

        public static double Regla_falsa(string funcion, double xi_, double xd_, double tole, int iter_max)
        {
            string xi = xi_.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            string xd = xd_.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            Function f = new Function("f(x)" + "=" + funcion);
            Expression e = new Expression("f(" + xi + ")", f);
            Expression e2 = new Expression("f(" + xd + ")", f);
            double calculo_inicial = e.calculate() * e2.calculate();

            if (calculo_inicial == 0)
            {
                if (e.calculate() == 0)
                    return xi_;
                else
                    return xd_;
            }
            else
            {
                if (calculo_inicial > 0)
                {
                    MessageBox.Show("Vuelva a ingresar los valores", "Parámetros inválidos");
                    return 0;
                }
                else
                {
                    double x_ant = 0;
                    int cont = 0;
                    double xr;
                    double error;
                    while (cont < iter_max)
                    {
                        cont += 1;

                        xi = xi_.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
                        xd = xd_.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
                        e = new Expression("f(" + xi + ")", f);
                        e2 = new Expression("f(" + xd + ")", f);
                        double fxi = e.calculate();
                        double fxd = e2.calculate();
                        xr = ((fxd * xi_) - (fxi * xd_)) / (fxd - fxi);

                        error = Math.Abs((xr - x_ant) / xr);
                        Expression e3 = new Expression("f(" + xr.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
                        if (Math.Abs(e3.calculate()) < tole || (error < tole) || cont >= iter_max)
                        {
                            return xr;
                        }
                        else
                        {
                            double calculo_sec = e.calculate() * e3.calculate();
                            if (calculo_sec < 0)
                            {
                                xd_ = xr;
                            }
                            else
                            {
                                xi_ = xr;
                            }
                            x_ant = xr;
                        }
                    }
                    MessageBox.Show("Se supero el numero de iteraciones maximas permitidas", "Iteraciones maximas alcanzadas");
                    return 0;
                }
            }
        }
        
        public static double Newton_raphson(string funcion, double xi_, double tole, int iter_max)
        {
            string xi = xi_.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            string dxi = (xi_+tole).ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            Function f = new Function("f(x)" + "=" + funcion);
            Expression e = new Expression("f(" + xi + ")", f);
            Expression e_aprox = new Expression("f(" + dxi + ")", f);

            double calculo_inicial = e.calculate();

            if (Math.Abs(calculo_inicial) < tole)
            {
                return xi_;
            }
            else
            {
                double x_ant = 0;
                int cont = 0;
                double xr;
                double error;
                while (cont < iter_max)
                {
                    cont += 1;

                    xi = xi_.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
                    dxi = (xi_+tole).ToString(CultureInfo.CreateSpecificCulture("en-GB"));
                    e = new Expression("f(" + xi + ")", f);
                    e_aprox = new Expression("f(" + dxi + ")", f);
                    xr = xi_ - (e.calculate() / ((e_aprox.calculate()-e.calculate())/tole));

                    error = Math.Abs((xr - x_ant) / xr);

                    Expression e2 = new Expression("f(" + xr.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
                    if (Math.Abs(e2.calculate()) < tole || (error < tole) || cont >= iter_max)
                    {
                        return xr;
                    }
                    else
                    {
                        xi_ = xr;
                    }
                    x_ant = xr;
                }
                MessageBox.Show("Se supero el numero de iteraciones maximas permitidas", "Iteraciones maximas alcanzadas");
                return 0;
            }
        }
        public static double secante(string funcion, double xi_, double tole, int iter_max)
        {
            double xd_ = xi_+1;
            string xi = xi_.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            string xd = xd_.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            Function f = new Function("f(x)" + "=" + funcion);
            Expression e = new Expression("f(" + xi + ")", f);
            Expression e2 = new Expression("f(" + xd + ")", f);

            double calculo_inicial = e.calculate();

            if (Math.Abs(calculo_inicial) < tole)
            {
                return xi_;
            }
            else
            {
                double x_ant = 0;
                int cont = 0;
                double xr;
                double error;

                double denom = (e2.calculate() - e.calculate());
                Console.WriteLine(denom);
                if (denom < 0)
                {
                    MessageBox.Show("Metodo no concluyente", "Division por cero");
                    return 0;
                }
                else
                {
                    while (cont < iter_max)
                    {

                        cont += 1;

                        xi = xi_.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
                        xd = xd_.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
                        e = new Expression("f(" + xi + ")", f);
                        e2 = new Expression("f(" + xd + ")", f);

                        denom = (e2.calculate() - e.calculate());
                        Console.WriteLine(denom);
                        if (denom < 0)
                        {
                            MessageBox.Show("Metodo no concluyente", "Division por cero");
                            return 0;
                        }
                        else 
                        {
                            xr = ((e2.calculate() * xi_) - (e.calculate() * e2.calculate()) / (e2.calculate() - e.calculate()));
                           // Console.WriteLine(xr);
                            error = Math.Abs((xr - x_ant) / xr);

                            Expression e3 = new Expression("f(" + xr.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
                            if (Math.Abs(e3.calculate()) < tole || (error < tole) || cont >= iter_max)
                            {
                                return xr;
                            }
                            else
                            {
                                xi_ = xr;
                            }
                            x_ant = xr;
                        }
                        
                    }
                }
                
                MessageBox.Show("Se supero el numero de iteraciones maximas permitidas", "Iteraciones maximas alcanzadas");
                return 0;
            }
        }
    }
}
