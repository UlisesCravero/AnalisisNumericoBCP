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
        public struct Resultado
        {
            public Resultado(int nro_iteraciones_, double error_, double raiz_)
            {
                nro_iteraciones = nro_iteraciones_;
                error = error_;
                raiz = raiz_;
            }
            public int nro_iteraciones;
            public double error;
            public double raiz;
        }

        public struct ResultadoGauss
        {
            public ResultadoGauss(int nro_iteraciones_, double[] resultados_)
            {
                nro_iteraciones = nro_iteraciones_;
                resultados = resultados_;
            }
            public int nro_iteraciones;
            public double[] resultados;
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
                    return new Resultado(0, 0, xi_);
                else
                    return new Resultado(0, 0, xd_);
            }
            else
            {
                if (calculo_inicial > 0)
                {
                    MessageBox.Show("Vuelva a ingresar los valores", "Parámetros inválidos");
                    return new Resultado(0, 0, 0); ;
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
                            return new Resultado(cont, error, xr);
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
                    return new Resultado(cont, 0, 0);
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
                    return new Resultado(0, 0, xi_);
                else
                    return new Resultado(0, 0, xd_);
            }
            else
            {
                if (calculo_inicial > 0)
                {
                    MessageBox.Show("Vuelva a ingresar los valores", "Parámetros inválidos");
                    return new Resultado(0, 0, 0);
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
                            return new Resultado(cont, error, xr);
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
                    return new Resultado(cont, 0, 0);
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
                return new Resultado(0, 0, xi_);
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
                        return new Resultado(0, 0, 0);
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
                            return new Resultado(cont, error, xr);
                        }
                        else
                        {
                            xi_ = xr;
                        }
                        x_ant = xr;
                    }
                }
                MessageBox.Show("Se supero el numero de iteraciones maximas permitidas", "Iteraciones maximas alcanzadas");
                return new Resultado(cont, 0, 0);
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
                return new Resultado(0, 0, xi_);
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
                        return new Resultado(0, 0, 0);
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
                            return new Resultado(cont, error, xr);
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
                return new Resultado(cont, 0, 0);
            }
        }

        // unidad 2

        public static ResultadoGauss MetodoGaussJordan(int dim, double[,] matriz)
        {
            ResultadoGauss resp;
            for (int i = 0; i <= dim - 1; i++)
            {
                double coeficiente = matriz[i, i];
                for (int j = 0; j <= dim; j++)
                {
                    matriz[i, j] = matriz[i, j] / coeficiente;
                }
                for (int j = 0; j <= dim - 1; j++)
                {
                    if (i != j)
                    {
                        coeficiente = matriz[j, i];
                        for (int k = 0; k <= dim; k++)
                        {
                            matriz[j, k] = matriz[j, k] - (coeficiente * matriz[i, k]);
                        }
                    }
                }
            }

            double[] resultado = new double[dim];
            for (int i = 0; i < dim; i++)
            {
                resultado[i] = matriz[i, dim];
            }

            resp.resultados = resultado;
            return resp;
        }

        public static ResultadoGauss MetodoGaussSeidel(int dim, double[,] M, int iteraciones, double tolerancia)
        {
            ResultadoGauss resp;
            bool bandera = false;
            double[] VectorResultados = new double[dim];
            double[] VectorAnterior = new double[dim];
            int contador = 0;

            while (iteraciones >= contador && bandera == false)
            {
                contador++;
                if (contador > 1)
                {
                    VectorResultados.CopyTo(VectorAnterior, 0);
                }

                for (int i = 0; i < dim; i++)
                {
                    double resultado = M[i, dim];
                    double x = M[i, i];

                    for (int j = 0; j < dim; j++)
                    {
                        if (i != j)
                        {                            
                            resultado = resultado - (M[i, j] * VectorResultados[j]);
                        }
                    }
                    x = resultado / x;
                    VectorResultados[i] = x;
                }

                int cont_aux = 0;
                for (int i = 0; i < dim; i++)
                {                   
                    if(Math.Abs(VectorResultados[i] - VectorAnterior[i]) < tolerancia)
                    {
                        cont_aux++;
                    }
                }
                if (cont_aux == dim)
                {
                    bandera = true;
                }
            }
            if (iteraciones >= contador)
            {
                resp.resultados = null;
            } else
            {
                resp.resultados = VectorResultados;
            }
            resp.nro_iteraciones = contador;

            return resp;
        }
    }
}
