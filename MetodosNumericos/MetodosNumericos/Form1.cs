using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetodosNumericos;
using static MetodosNumericos.Metodos;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Metodos metodos = new Metodos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 formPrincipal = new Form1();
            formPrincipal.Owner = this;
        }

        private void ObtenerClick(object sender, EventArgs e)
        {
            Resultado resultado = new Resultado();
            int metodo = BoxMetodos.SelectedIndex;

            switch (metodo)
            {
                case 0:
                    resultado = Biseccion(textbox_funcion.Text, double.Parse(textbox_LI.Text), double.Parse(textbox_LD.Text), double.Parse(textbox_Tolerancia.Text), int.Parse(textbox_IterMax.Text));
                    Console.WriteLine(textbox_funcion.Text + " " + double.Parse(textbox_LI.Text) + " " + double.Parse(textbox_LD.Text) + " " + double.Parse(textbox_Tolerancia.Text) + " " + int.Parse(textbox_IterMax.Text));
                    break;
                case 1:
                    resultado = Regla_falsa(textbox_funcion.Text, double.Parse(textbox_LI.Text), double.Parse(textbox_LD.Text), double.Parse(textbox_Tolerancia.Text), int.Parse(textbox_IterMax.Text));
                    break;
                case 2:
                    resultado = Newton_raphson(textbox_funcion.Text, double.Parse(textbox_LI.Text), double.Parse(textbox_Tolerancia.Text), int.Parse(textbox_IterMax.Text));
                    break;
                case 3:
                    resultado = Secante(textbox_funcion.Text, double.Parse(textbox_LI.Text), double.Parse(textbox_LD.Text), double.Parse(textbox_Tolerancia.Text), int.Parse(textbox_IterMax.Text));
                    break;
                default:
                    MessageBox.Show("Ingrese los parámetros a calcular", "Parámetros inválidos");
                    break;
            }

            label_ResultadoIteraciones.Text = resultado.nro_iteraciones.ToString();
            label_ResultadoErrorR.Text = resultado.error.ToString();
            label_ResultadoSolucion.Text = resultado.raiz.ToString();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void boton_generar_Click(object sender, EventArgs e)
        {
            try
            {
                int tamaño = int.Parse(tam_matriz.Text);
                int pointX = 30;
                int pointY = 30;
                matriz.Controls.Clear();
                for (int i = 0; i < tamaño; i++)
                {
                    for (int j = 0; j < tamaño + 1; j++)
                    {
                        TextBox txt = new TextBox();
                        txt.Location = new Point(pointX, pointY);
                        txt.Name = $"txt{i}{j}";
                        txt.AutoSize = true;
                        txt.Size = new Size(45, 30);
                        txt.Font = new Font("Microsoft Sans Serif", 10);
                        matriz.Controls.Add(txt);
                        pointX += 50;
                        if (j == tamaño)
                        {
                            txt.Name = $"txt{i}{j}";
                            txt.BackColor = Color.Yellow;
                            int coef = j;
                        }
                    }
                    pointY += 50;
                    pointX = 30;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un valor válido", "Error");
            }

        }

        private double[,] obtenerMatriz()
        {
            int tamaño = int.Parse(tam_matriz.Text);
            double[,] matriz_aux = new double[tamaño, tamaño + 1];
            for (int i = 0; i < tamaño; i++)
            {
                for (int j = 0; j < tamaño + 1; j++)
                {
                    Control tbx = matriz.Controls.Find("txt" + i.ToString() + j.ToString(), true).First();
                    matriz_aux[i, j] = double.Parse((tbx as TextBox).Text);
                }
            }
            return matriz_aux;
        }

        private string obtenerResultadosMetodos(double[] resultado)
        {
            string texto_result = "";
            for (int i = 0; i < resultado.Length; i++)
            {
                texto_result += "X" + i.ToString() + " = " + resultado[i] + ".\n";
            }
            return texto_result;
        }

        private void button_GaussJordan_Click(object sender, EventArgs e)
        {
            ResultadoGauss resp = MetodoGaussJordan(int.Parse(tam_matriz.Text), obtenerMatriz());
            MessageBox.Show(obtenerResultadosMetodos(resp.resultados), "Resultados Método Gauss-Jordan");
        }

        private void button_GaussSeidel_Click(object sender, EventArgs e)
        {
            ResultadoGauss resp = MetodoGaussSeidel(int.Parse(tam_matriz.Text), obtenerMatriz(), 100, 0.0001);
            if (resp.resultados == null)
            {
                MessageBox.Show("Número de iteraciones máximas superadas, el método no es convergente", "Resultados Método Gauss-Seidel");
            }
            else MessageBox.Show(obtenerResultadosMetodos(resp.resultados) + $"en {resp.nro_iteraciones} iteraciones.", "Resultados Método Gauss-Seidel");
        }

    }
}
