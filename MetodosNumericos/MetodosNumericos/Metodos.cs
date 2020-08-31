﻿using org.mariuszgromada.math.mxparser;
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
        public struct Resultado
        {
            public Resultado(int nro_iteraciones_, double tolerancia, double raiz_)
            {
                nro_iteraciones = nro_iteraciones_;
                error = tolerancia * 100;
                raiz = raiz_;
            }
            public int nro_iteraciones;
            public double error;
            public double raiz;
        }

        public static Resultado Biseccion(string funcion, double xi_, double xd_, double tole, int iter_max)
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
                    return new Resultado(0, tole, xi_);
                else
                    return new Resultado(0, tole, xd_);
            }
            else
            {
                if (calculo_inicial > 0)
                {
                    MessageBox.Show("Vuelva a ingresar los valores", "Parámetros inválidos");
                    return new Resultado(0, tole, 0); ;
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
                            return new Resultado(cont, tole, xr);
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
                    return new Resultado(cont, tole, 0);
                }
            }      
        }

        public static Resultado Regla_falsa(string funcion, double xi_, double xd_, double tole, int iter_max)
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
                    return new Resultado(0, tole, xi_);
                else
                    return new Resultado(0, tole, xd_);
            }
            else
            {
                if (calculo_inicial > 0)
                {
                    MessageBox.Show("Vuelva a ingresar los valores", "Parámetros inválidos");
                    return new Resultado(0, tole, 0);
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
                            return new Resultado(cont, tole, xr);
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
                    return new Resultado(cont, tole, 0);
                }
            }
        }
        
        public static Resultado Newton_raphson(string funcion, double xi_, double tole, int iter_max)
        {
            string xi = xi_.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            string dxi = (xi_+tole).ToString(CultureInfo.CreateSpecificCulture("en-GB")); //se usa para calcular la deriv por aproximacion
            Function f = new Function("f(x)" + "=" + funcion);
            Expression e = new Expression("f(" + xi + ")", f);
            Expression e_aprox = new Expression("f(" + dxi + ")", f);

            double calculo_inicial = e.calculate();
            if (Math.Abs(calculo_inicial) < tole)
            {
                return new Resultado(0, tole, xi_);
            }
            else
            {
                double x_ant = 0;
                int cont = 0;
                double xr;
                double error;

                while (cont < iter_max)
                {
                    if(Math.Abs(e_aprox.calculate()) < tole)
                    {
                        MessageBox.Show("El metodo no es concluyente", "Divergencia por punto min/max o de inflexion");
                        return new Resultado(0, tole, 0);
                    }
                    else
                    {
                        cont += 1;

                        xi = xi_.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
                        dxi = (xi_ + tole).ToString(CultureInfo.CreateSpecificCulture("en-GB"));
                        e = new Expression("f(" + xi + ")", f);
                        e_aprox = new Expression("f(" + dxi + ")", f);
                        xr = xi_ - (e.calculate() / ((e_aprox.calculate() - e.calculate()) / tole));

                        error = Math.Abs((xr - x_ant) / xr);

                        Expression e2 = new Expression("f(" + xr.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
                        if (Math.Abs(e2.calculate()) < tole || (error < tole))
                        {
                            return new Resultado(cont, tole, xr);
                        }
                        else
                        {
                            xi_ = xr;
                        }
                        x_ant = xr;
                    }
                }
                MessageBox.Show("Se supero el numero de iteraciones maximas permitidas", "Iteraciones maximas alcanzadas");
                return new Resultado(cont, tole, 0);
            }
        }

        public static Resultado Secante(string funcion, double xi_, double xd_, double tole, int iter_max)
        {
            string xi = xi_.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            string xd = xd_.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            Function f = new Function("f(x)" + "=" + funcion);
            Expression e = new Expression("f(" + xi + ")", f);
            Expression e2 = new Expression("f(" + xd + ")", f);

            double calculo_inicial = e.calculate();

            if (Math.Abs(calculo_inicial) < tole)
            {
                return new Resultado(0, tole, xi_);
            }
            else
            {
                double x_ant = 0;
                int cont = 0;
                double xr;
                double error;

                while (cont < iter_max)
                {
                    xi = xi_.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
                    xd = xd_.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
                    e = new Expression("f(" + xi + ")", f);
                    e2 = new Expression("f(" + xd + ")", f);
                    double denom = (e2.calculate() - e.calculate());

                    if (Math.Abs(denom) < tole) 
                    {
                        MessageBox.Show("El metodo no es concluyente", "Divergencia por punto min/max o de inflexion");
                        return new Resultado(0, tole, 0);
                    }
                    else
                    {
                        cont += 1;

                        xi = xi_.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
                        xd = xd_.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
                        e = new Expression("f(" + xi + ")", f);
                        e2 = new Expression("f(" + xd + ")", f);
                        denom = (e2.calculate() - e.calculate());

                        xr = ((e2.calculate() * xi_) - (e.calculate() * xd_)) / denom;

                        error = Math.Abs((xr - x_ant) / xr);
                    
                        Expression e3 = new Expression("f(" + xr.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
                        if (Math.Abs(e3.calculate()) < tole || (error < tole))
                        {
                            return new Resultado(cont, tole, xr);
                        }
                        else
                        {
                            xd_ = xi_;
                            xi_ = xr;
                            x_ant = xr;
                        }
                    }
                }
                MessageBox.Show("Se supero el numero de iteraciones maximas permitidas", "Iteraciones maximas alcanzadas");
                return new Resultado(cont, tole, 0);
            }
        }
    }
}
