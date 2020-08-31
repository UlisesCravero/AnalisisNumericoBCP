using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
