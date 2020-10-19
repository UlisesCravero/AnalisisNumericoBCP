namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BoxMetodos = new System.Windows.Forms.ComboBox();
            this.label_ResultadoSolucion = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_ResultadoErrorR = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_ResultadoIteraciones = new System.Windows.Forms.Label();
            this.buttonObtener = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_LD = new System.Windows.Forms.TextBox();
            this.textbox_LI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_IterMax = new System.Windows.Forms.TextBox();
            this.textbox_Tolerancia = new System.Windows.Forms.TextBox();
            this.textbox_funcion = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.tol_seidel = new System.Windows.Forms.TextBox();
            this.label_Metodo = new System.Windows.Forms.Label();
            this.button_GaussSeidel = new System.Windows.Forms.Button();
            this.button_GaussJordan = new System.Windows.Forms.Button();
            this.matriz = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.boton_generar = new System.Windows.Forms.Button();
            this.tam_matriz = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.funcion = new System.Windows.Forms.TextBox();
            this.correlacion = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.calcular = new System.Windows.Forms.Button();
            this.metodos_box = new System.Windows.Forms.Label();
            this.metodos = new System.Windows.Forms.ComboBox();
            this.tolerancia = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.valores = new System.Windows.Forms.GroupBox();
            this.cargar_val = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.matriz_xy = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.generar_xy = new System.Windows.Forms.Button();
            this.cant_pares = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.valores.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1069, 556);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1061, 527);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Unidad 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(25, 7);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1005, 517);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(997, 488);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Actividad";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BoxMetodos);
            this.groupBox2.Controls.Add(this.label_ResultadoSolucion);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label_ResultadoErrorR);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label_ResultadoIteraciones);
            this.groupBox2.Controls.Add(this.buttonObtener);
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox2.Location = new System.Drawing.Point(24, 266);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(469, 129);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // BoxMetodos
            // 
            this.BoxMetodos.FormattingEnabled = true;
            this.BoxMetodos.Items.AddRange(new object[] {
            "Bisección",
            "Regla falsa",
            "Newton Raphson",
            "Secante"});
            this.BoxMetodos.Location = new System.Drawing.Point(16, 22);
            this.BoxMetodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BoxMetodos.Name = "BoxMetodos";
            this.BoxMetodos.Size = new System.Drawing.Size(121, 24);
            this.BoxMetodos.TabIndex = 20;
            // 
            // label_ResultadoSolucion
            // 
            this.label_ResultadoSolucion.AutoSize = true;
            this.label_ResultadoSolucion.Location = new System.Drawing.Point(277, 86);
            this.label_ResultadoSolucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ResultadoSolucion.Name = "label_ResultadoSolucion";
            this.label_ResultadoSolucion.Size = new System.Drawing.Size(18, 17);
            this.label_ResultadoSolucion.TabIndex = 17;
            this.label_ResultadoSolucion.Text = "--";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(179, 22);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Iteraciones =";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(163, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Error Relativo =";
            // 
            // label_ResultadoErrorR
            // 
            this.label_ResultadoErrorR.AutoSize = true;
            this.label_ResultadoErrorR.Location = new System.Drawing.Point(277, 54);
            this.label_ResultadoErrorR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ResultadoErrorR.Name = "label_ResultadoErrorR";
            this.label_ResultadoErrorR.Size = new System.Drawing.Size(18, 17);
            this.label_ResultadoErrorR.TabIndex = 19;
            this.label_ResultadoErrorR.Text = "--";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(195, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Solución =";
            // 
            // label_ResultadoIteraciones
            // 
            this.label_ResultadoIteraciones.AutoSize = true;
            this.label_ResultadoIteraciones.Location = new System.Drawing.Point(276, 22);
            this.label_ResultadoIteraciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ResultadoIteraciones.Name = "label_ResultadoIteraciones";
            this.label_ResultadoIteraciones.Size = new System.Drawing.Size(18, 17);
            this.label_ResultadoIteraciones.TabIndex = 18;
            this.label_ResultadoIteraciones.Text = "--";
            // 
            // buttonObtener
            // 
            this.buttonObtener.Location = new System.Drawing.Point(16, 75);
            this.buttonObtener.Margin = new System.Windows.Forms.Padding(4);
            this.buttonObtener.Name = "buttonObtener";
            this.buttonObtener.Size = new System.Drawing.Size(100, 28);
            this.buttonObtener.TabIndex = 3;
            this.buttonObtener.Text = "Obtener";
            this.buttonObtener.UseVisualStyleBackColor = true;
            this.buttonObtener.Click += new System.EventHandler(this.ObtenerClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "METODOS:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textbox_LD);
            this.groupBox1.Controls.Add(this.textbox_LI);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textbox_IterMax);
            this.groupBox1.Controls.Add(this.textbox_Tolerancia);
            this.groupBox1.Controls.Add(this.textbox_funcion);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox1.Location = new System.Drawing.Point(8, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(979, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de entrada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "L.D.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(536, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "L.I.";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textbox_LD
            // 
            this.textbox_LD.Location = new System.Drawing.Point(584, 71);
            this.textbox_LD.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_LD.Name = "textbox_LD";
            this.textbox_LD.Size = new System.Drawing.Size(132, 22);
            this.textbox_LD.TabIndex = 7;
            // 
            // textbox_LI
            // 
            this.textbox_LI.Location = new System.Drawing.Point(584, 39);
            this.textbox_LI.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_LI.Name = "textbox_LI";
            this.textbox_LI.Size = new System.Drawing.Size(132, 22);
            this.textbox_LI.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Iteraciones max =";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tolerancia =";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "f(x) =";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textbox_IterMax
            // 
            this.textbox_IterMax.Location = new System.Drawing.Point(176, 100);
            this.textbox_IterMax.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_IterMax.Name = "textbox_IterMax";
            this.textbox_IterMax.Size = new System.Drawing.Size(132, 22);
            this.textbox_IterMax.TabIndex = 2;
            // 
            // textbox_Tolerancia
            // 
            this.textbox_Tolerancia.Location = new System.Drawing.Point(176, 68);
            this.textbox_Tolerancia.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_Tolerancia.Name = "textbox_Tolerancia";
            this.textbox_Tolerancia.Size = new System.Drawing.Size(132, 22);
            this.textbox_Tolerancia.TabIndex = 1;
            // 
            // textbox_funcion
            // 
            this.textbox_funcion.Location = new System.Drawing.Point(176, 36);
            this.textbox_funcion.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_funcion.Name = "textbox_funcion";
            this.textbox_funcion.Size = new System.Drawing.Size(132, 22);
            this.textbox_funcion.TabIndex = 0;
            this.textbox_funcion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.tol_seidel);
            this.tabPage2.Controls.Add(this.label_Metodo);
            this.tabPage2.Controls.Add(this.button_GaussSeidel);
            this.tabPage2.Controls.Add(this.button_GaussJordan);
            this.tabPage2.Controls.Add(this.matriz);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1061, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = "";
            this.tabPage2.Text = "Unidad 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(820, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Tolerancia:";
            // 
            // tol_seidel
            // 
            this.tol_seidel.Location = new System.Drawing.Point(903, 113);
            this.tol_seidel.Name = "tol_seidel";
            this.tol_seidel.Size = new System.Drawing.Size(82, 22);
            this.tol_seidel.TabIndex = 8;
            this.tol_seidel.Text = "0";
            // 
            // label_Metodo
            // 
            this.label_Metodo.AutoSize = true;
            this.label_Metodo.Location = new System.Drawing.Point(795, 30);
            this.label_Metodo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Metodo.Name = "label_Metodo";
            this.label_Metodo.Size = new System.Drawing.Size(66, 17);
            this.label_Metodo.TabIndex = 6;
            this.label_Metodo.Text = "Métodos:";
            // 
            // button_GaussSeidel
            // 
            this.button_GaussSeidel.Location = new System.Drawing.Point(820, 142);
            this.button_GaussSeidel.Margin = new System.Windows.Forms.Padding(4);
            this.button_GaussSeidel.Name = "button_GaussSeidel";
            this.button_GaussSeidel.Size = new System.Drawing.Size(165, 27);
            this.button_GaussSeidel.TabIndex = 5;
            this.button_GaussSeidel.Text = "Gauss Seidel";
            this.button_GaussSeidel.UseVisualStyleBackColor = true;
            this.button_GaussSeidel.Click += new System.EventHandler(this.button_GaussSeidel_Click);
            // 
            // button_GaussJordan
            // 
            this.button_GaussJordan.Location = new System.Drawing.Point(817, 59);
            this.button_GaussJordan.Margin = new System.Windows.Forms.Padding(4);
            this.button_GaussJordan.Name = "button_GaussJordan";
            this.button_GaussJordan.Size = new System.Drawing.Size(168, 26);
            this.button_GaussJordan.TabIndex = 4;
            this.button_GaussJordan.Text = "Gauss Jordan";
            this.button_GaussJordan.UseVisualStyleBackColor = true;
            this.button_GaussJordan.Click += new System.EventHandler(this.button_GaussJordan_Click);
            // 
            // matriz
            // 
            this.matriz.Location = new System.Drawing.Point(235, 17);
            this.matriz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.matriz.Name = "matriz";
            this.matriz.Size = new System.Drawing.Size(492, 452);
            this.matriz.TabIndex = 3;
            this.matriz.Tag = "Matriz";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.boton_generar);
            this.groupBox3.Controls.Add(this.tam_matriz);
            this.groupBox3.Location = new System.Drawing.Point(7, 7);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(205, 140);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nueva matriz";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ingrese tamaño (nxn):";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // boton_generar
            // 
            this.boton_generar.Location = new System.Drawing.Point(43, 94);
            this.boton_generar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boton_generar.Name = "boton_generar";
            this.boton_generar.Size = new System.Drawing.Size(123, 41);
            this.boton_generar.TabIndex = 1;
            this.boton_generar.Text = "Generar matriz";
            this.boton_generar.UseVisualStyleBackColor = true;
            this.boton_generar.Click += new System.EventHandler(this.boton_generar_Click);
            // 
            // tam_matriz
            // 
            this.tam_matriz.Location = new System.Drawing.Point(21, 54);
            this.tam_matriz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tam_matriz.Name = "tam_matriz";
            this.tam_matriz.Size = new System.Drawing.Size(169, 22);
            this.tam_matriz.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.valores);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1061, 527);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Unidad 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.funcion);
            this.groupBox5.Controls.Add(this.correlacion);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Location = new System.Drawing.Point(320, 306);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(252, 174);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Resultados";
            // 
            // funcion
            // 
            this.funcion.Location = new System.Drawing.Point(131, 34);
            this.funcion.Name = "funcion";
            this.funcion.Size = new System.Drawing.Size(100, 22);
            this.funcion.TabIndex = 4;
            // 
            // correlacion
            // 
            this.correlacion.Location = new System.Drawing.Point(131, 81);
            this.correlacion.Name = "correlacion";
            this.correlacion.Size = new System.Drawing.Size(100, 22);
            this.correlacion.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "% correlación:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Función obtenida:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.calcular);
            this.groupBox4.Controls.Add(this.metodos_box);
            this.groupBox4.Controls.Add(this.metodos);
            this.groupBox4.Controls.Add(this.tolerancia);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(35, 306);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(242, 174);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Elección parámetros";
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(105, 120);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(110, 31);
            this.calcular.TabIndex = 4;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            // 
            // metodos_box
            // 
            this.metodos_box.AutoSize = true;
            this.metodos_box.Location = new System.Drawing.Point(29, 84);
            this.metodos_box.Name = "metodos_box";
            this.metodos_box.Size = new System.Drawing.Size(59, 17);
            this.metodos_box.TabIndex = 3;
            this.metodos_box.Text = "Método:";
            // 
            // metodos
            // 
            this.metodos.FormattingEnabled = true;
            this.metodos.Location = new System.Drawing.Point(94, 77);
            this.metodos.Name = "metodos";
            this.metodos.Size = new System.Drawing.Size(121, 24);
            this.metodos.TabIndex = 2;
            // 
            // tolerancia
            // 
            this.tolerancia.Location = new System.Drawing.Point(115, 35);
            this.tolerancia.Name = "tolerancia";
            this.tolerancia.Size = new System.Drawing.Size(100, 22);
            this.tolerancia.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tolerancia:";
            // 
            // valores
            // 
            this.valores.Controls.Add(this.cargar_val);
            this.valores.Controls.Add(this.label17);
            this.valores.Controls.Add(this.label13);
            this.valores.Controls.Add(this.matriz_xy);
            this.valores.Controls.Add(this.label8);
            this.valores.Controls.Add(this.generar_xy);
            this.valores.Controls.Add(this.cant_pares);
            this.valores.Location = new System.Drawing.Point(35, 48);
            this.valores.Name = "valores";
            this.valores.Size = new System.Drawing.Size(987, 226);
            this.valores.TabIndex = 0;
            this.valores.TabStop = false;
            this.valores.Text = "Valores a ingresar";
            // 
            // cargar_val
            // 
            this.cargar_val.Location = new System.Drawing.Point(842, 185);
            this.cargar_val.Name = "cargar_val";
            this.cargar_val.Size = new System.Drawing.Size(139, 35);
            this.cargar_val.TabIndex = 7;
            this.cargar_val.Text = "Cargar valores";
            this.cargar_val.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 133);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 17);
            this.label17.TabIndex = 6;
            this.label17.Text = "Y";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "X";
            // 
            // matriz_xy
            // 
            this.matriz_xy.Location = new System.Drawing.Point(41, 79);
            this.matriz_xy.Name = "matriz_xy";
            this.matriz_xy.Size = new System.Drawing.Size(940, 91);
            this.matriz_xy.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Cantidad de pares:";
            // 
            // generar_xy
            // 
            this.generar_xy.Location = new System.Drawing.Point(216, 35);
            this.generar_xy.Name = "generar_xy";
            this.generar_xy.Size = new System.Drawing.Size(81, 33);
            this.generar_xy.TabIndex = 2;
            this.generar_xy.Text = "Generar";
            this.generar_xy.UseVisualStyleBackColor = true;
            this.generar_xy.Click += new System.EventHandler(this.generar_xy_Click);
            // 
            // cant_pares
            // 
            this.cant_pares.Location = new System.Drawing.Point(154, 40);
            this.cant_pares.Name = "cant_pares";
            this.cant_pares.Size = new System.Drawing.Size(46, 22);
            this.cant_pares.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1061, 527);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Unidad 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.valores.ResumeLayout(false);
            this.valores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textbox_funcion;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_IterMax;
        private System.Windows.Forms.TextBox textbox_Tolerancia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox_LD;
        private System.Windows.Forms.TextBox textbox_LI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_ResultadoSolucion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_ResultadoErrorR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_ResultadoIteraciones;
        private System.Windows.Forms.Button buttonObtener;
        private System.Windows.Forms.ComboBox BoxMetodos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button boton_generar;
        private System.Windows.Forms.TextBox tam_matriz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel matriz;
        private System.Windows.Forms.Label label_Metodo;
        private System.Windows.Forms.Button button_GaussSeidel;
        private System.Windows.Forms.Button button_GaussJordan;
        private System.Windows.Forms.TextBox tol_seidel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox valores;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox funcion;
        private System.Windows.Forms.TextBox correlacion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label metodos_box;
        private System.Windows.Forms.ComboBox metodos;
        private System.Windows.Forms.TextBox tolerancia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button generar_xy;
        private System.Windows.Forms.TextBox cant_pares;
        private System.Windows.Forms.Button cargar_val;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel matriz_xy;
    }
}

