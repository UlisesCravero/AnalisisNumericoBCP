using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
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

        public struct ResultadoAjuste
        {
            public ResultadoAjuste(string funcion_, double correlacion_, string ajuste_)
            {
                funcion = funcion_;
                correlacion = correlacion_;
                ajuste = ajuste_;
            }
            public string funcion;
            public double correlacion;
            public string ajuste;
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
            string dxi = (xi_ + tole).ToString(CultureInfo.CreateSpecificCulture("en-GB")); //se usa para calcular la deriv por aproximacion
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
                    if (Math.Abs(e_aprox.calculate()) < tole)
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
            ResultadoGauss resp = new ResultadoGauss();
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
            ResultadoGauss resp = new ResultadoGauss();
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
                    if (Math.Abs(VectorResultados[i] - VectorAnterior[i]) <= tolerancia)
                    {
                        cont_aux++;
                    }
                }
                if (cont_aux == dim)
                {
                    bandera = true;
                }
            }
            if (contador >= iteraciones)
            {
                resp.resultados = null;
            }
            else
            {
                resp.resultados = VectorResultados;
            }
            resp.nro_iteraciones = contador;

            return resp;
        }

        //unidad 3 

        public static ResultadoAjuste Regresion_lineal(double tolerancia, double[,] matriz)
        {
            ResultadoAjuste res = new ResultadoAjuste();
            double sumx = 0;
            double sumy = 0;
            double sumxy = 0;
            double sumx2 = 0;
            int contador = matriz.GetLength(1);

            for (int i = 0; i < contador; i++)
            {
                sumx += matriz[0, i];
                sumy += matriz[1, i];
                sumxy += matriz[0, i] * matriz[1, i];
                sumx2 += matriz[0, i] * matriz[0, i];
            }

            double a1 = (contador * sumxy - sumx * sumy) / (contador * sumx2 - Math.Pow(sumx, 2));
            double a0 = (sumy / contador) - (a1 * (sumx / contador));

            double sr = 0;
            double st = 0;

            for (int i = 0; i < contador; i++)
            {
                sr += Math.Pow((a1 * matriz[0, i]) + a0 - matriz[1, i], 2);
                st += Math.Pow((sumy / contador) - matriz[1, i], 2);
            }

            double r = Math.Sqrt((st - sr) / st) * 100;

            if (r <= tolerancia)
            {
                res.ajuste = "El ajuste no es aceptable";
            }
            else
            {
                res.ajuste = "El ajuste es aceptable";
            }
            res.correlacion = (Math.Round(r, 5));
            res.funcion = $"y = {(Math.Round(a1, 5)).ToString("0." + new string('#', 339))}x + {(Math.Round(a0, 5)).ToString("0." + new string('#', 339))}";

            return res;
        }

        public static ResultadoAjuste Regresion_polinomial(double tolerancia, double[,] matriz, int grado)
        {
            ResultadoAjuste res = new ResultadoAjuste();
            double sumx = 0;
            double sumy = 0;
            double[,] matriz_gauss = new double[grado + 1, grado + 2];
            int contador = matriz.GetLength(1);

            for (int i = 0; i < contador; i++)
            {
                sumx += matriz[0, i];
                sumy += matriz[1, i];

                for (int j = 0; j < grado + 1; j++)
                {
                    for (int k = 0; k < grado + 1; k++)
                    {
                        matriz_gauss[j, k] += Math.Pow(matriz[0, i], k + j);
                    }
                    matriz_gauss[j, grado + 1] += matriz[1, i] * Math.Pow(matriz[0, i], j);
                }
            }

            ResultadoGauss res_aux = MetodoGaussJordan(grado + 1, matriz_gauss);

            double sr = 0;
            double st = 0;

            for (int i = 0; i < contador - 1; i++)
            {
                st += Math.Pow((sumy / contador) - matriz[1, i], 2);
                double s = 0;
                for (int j = 0; j < grado + 1; j++)
                {
                    s += (res_aux.resultados[j] * Math.Pow(matriz[0, i], j));
                }
                sr += Math.Pow(s - matriz[1, i], 2);
            }

            double r = Math.Sqrt((st - sr) / st) * 100;

            if (r <= tolerancia)
            {
                res.ajuste = "El ajuste no es aceptable";
            }
            else
            {
                res.ajuste = "El ajuste es aceptable";
            }

            res.correlacion = (Math.Round(r, 5));
            
            res.funcion += "y = ";
            for (int i = 0; i < res_aux.resultados.Length; i++)
            {
                if (res_aux.resultados[i] >= 0)
                {
                    res.funcion += $"+ {(Math.Round(res_aux.resultados[i], 3)).ToString("0." + new string('#', 339))}x^{i} ";
                }
                else
                {
                    res.funcion += $"{(Math.Round(res_aux.resultados[i], 3)).ToString("0." + new string('#', 339))}x^{i} ";
                }
                
            }

            return res;
        }
    
        //unidad 4

        public static double Trapecio_simple(string funcion, double int_min, double int_max)
        {
            string int_min_ = int_min.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            string int_max_ = int_max.ToString(CultureInfo.CreateSpecificCulture("en-GB"));

            Function f = new Function("f(x)" + "=" + funcion);
            Expression fmin = new Expression("f(" + int_min_ + ")", f);
            Expression fmax = new Expression("f(" + int_max_ + ")", f);

            return Math.Round((((fmin.calculate() + fmax.calculate()) * (int_max - int_min)) / 2),5);
        }

        public static double Trapecios_multiples(string funcion, double int_min, double int_max, int intervalos)
        {
            string int_min_ = int_min.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            string int_max_ = int_max.ToString(CultureInfo.CreateSpecificCulture("en-GB"));

            Function f = new Function("f(x)" + "=" + funcion);
            Expression fmin = new Expression("f(" + int_min_ + ")", f);
            Expression fmax = new Expression("f(" + int_max_ + ")", f);

            double h = (int_max - int_min) / intervalos;
            double suma = 0;
            for(int i=1; i<=intervalos-1; i++)
            {
                double aux = (i*h)+int_min;
                string aux_ = aux.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
                Expression f_aux = new Expression("f(" + aux_ + ")", f);
                suma += f_aux.calculate();
            }

            return Math.Round(((h / 2) * (fmin.calculate() + (suma * 2) + fmax.calculate())), 5);
        }

        public static double Simpson_untercio_simple(string funcion, double int_min, double int_max)
        {
            string int_min_ = int_min.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            string int_max_ = int_max.ToString(CultureInfo.CreateSpecificCulture("en-GB"));

            Function f = new Function("f(x)" + "=" + funcion);
            Expression fmin = new Expression("f(" + int_min_ + ")", f);
            Expression fmax = new Expression("f(" + int_max_ + ")", f);
            
            double h = (int_max - int_min) / 2;
            double aux = h + int_min;
            string aux_ = aux.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            Expression f_aux = new Expression("f(" + aux_ + ")", f);

            return Math.Round((h / 3) * (fmin.calculate() + (4 * f_aux.calculate()) + fmax.calculate()),5);
        }

        public static double Simpson_untercio_multiple(string funcion, double int_min, double int_max, int intervalos)
        {
            string int_min_ = int_min.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            string int_max_ = int_max.ToString(CultureInfo.CreateSpecificCulture("en-GB"));

            Function f = new Function("f(x)" + "=" + funcion);
            Expression fmin = new Expression("f(" + int_min_ + ")", f);
            Expression fmax = new Expression("f(" + int_max_ + ")", f);

            double h = (int_max - int_min) / intervalos;
            
            double pares = 0;
            double impares = 0;

            for (int i = 1; i <= intervalos-1; i++)
            {
                double aux = int_min + (i * h);
                string aux_ = aux.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
                Expression f_aux = new Expression("f(" + aux_ + ")", f);
                if (i%2 == 0)
                {
                    pares += f_aux.calculate();
                }
                else
                {
                    impares += f_aux.calculate();
                }
            }

            return Math.Round((h / 3) * (fmin.calculate() + (4 * impares) + (2 * pares) + fmax.calculate()), 5);
        }

        public static double Simpson_tresoctavos_simple(string funcion, double int_min, double int_max)
        {
            string int_min_ = int_min.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            string int_max_ = int_max.ToString(CultureInfo.CreateSpecificCulture("en-GB"));

            Function f = new Function("f(x)" + "=" + funcion);
            Expression fmin = new Expression("f(" + int_min_ + ")", f);
            Expression fmax = new Expression("f(" + int_max_ + ")", f);

            double h = (int_max - int_min) / 3;

            double aux1 = h + int_min;
            string aux1_ = aux1.ToString(CultureInfo.CreateSpecificCulture("en-GB"));

            double aux2 = (2*h) + int_min;
            string aux2_ = aux2.ToString(CultureInfo.CreateSpecificCulture("en-GB"));

            Expression f_aux1 = new Expression("f(" + aux1_ + ")", f);
            Expression f_aux2 = new Expression("f(" + aux2_ + ")", f);

            return Math.Round(((3 * h) / 8) * (fmin.calculate() + (3 * f_aux1.calculate()) + (3 * f_aux2.calculate()) + fmax.calculate()), 5);
        }


    }
}
