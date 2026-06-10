using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBasica1
{ 
    public partial class txtnum1 : Form
    {
        public txtnum1()

        {

            InitializeComponent();


            {

                // Conectamos manualmente los botones con sus acciones
                btn_sumar.Click += new EventHandler(btn_sumar_Click);
                btn_restar.Click += new EventHandler(btn_restar_Click);
                btn_multiplicar.Click += new EventHandler(btn_multiplicar_Click);
                btn_dividir.Click += new EventHandler(btn_dividir_Click);
            }
        }
        // Método que revisa si el usuario escribió números válidos
        private bool verificar_Contenido()
        {
            bool valido = true;
            ErrorEncontrado.Clear();

            // Validar primer cuadro de texto
            if (string.IsNullOrWhiteSpace(textnum1.Text))
            {
                ErrorEncontrado.SetError(textnum1, "Ingrese el primer número.");
                valido = false;
            }
            else if (!double.TryParse(textnum1.Text, out _))
            {
                ErrorEncontrado.SetError(textnum1, "Debe ingresar un valor numérico.");
                valido = false;
            }

            // Validar segundo cuadro de texto
            if (string.IsNullOrWhiteSpace(textnum2.Text))
            {
                ErrorEncontrado.SetError(textnum2, "Ingrese el segundo número.");
                valido = false;
            }
            else if (!double.TryParse(textnum2.Text, out _))
            {
                ErrorEncontrado.SetError(textnum2, "Debe ingresar un valor numérico.");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(textnum3.Text))
            {
                ErrorEncontrado.SetError(textnum3, "Debe ingresar un valor numerico");
                valido = false;
            }
            else if (!double.TryParse(textnum3.Text, out _))
            {
                ErrorEncontrado.SetError(textnum3, "Debe ingresar un valor numerico");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(textnum4.Text))
            {
                ErrorEncontrado.SetError(textnum4, "Ingrese un valor numerico");
                valido = false;
            }
            else if (!double.TryParse(textnum4.Text, out _))
            {
                ErrorEncontrado.SetError(textnum4, "Debe ingresar un valor numerico");
                valido = false;
            }

                return valido;
            }

            // Acción al presionar el botón Sumar
            private void btn_sumar_Click(object sender, EventArgs e)
            {
                if (!verificar_Contenido()) return;

                double num1 = double.Parse(textnum1.Text);
                double num2 = double.Parse(textnum2.Text);
                double num3 = double.Parse(textnum3.Text);
                double num4 = double.Parse(textnum4.Text);
                double resultado = num1 + num2 + num3 + num4;

                MessageBox.Show("Resultado: " + resultado, "SUMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Acción al presionar el botón Restar
            private void btn_restar_Click(object sender, EventArgs e)
            {
                if (!verificar_Contenido()) return;

                double num1 = double.Parse(textnum1.Text);
                double num2 = double.Parse(textnum2.Text);
                double num3 = double.Parse(textnum3.Text);
                double num4 = double.Parse(textnum4.Text);
                double resultado = num1 - num2 - num3 - num4;

                MessageBox.Show("Resultado: " + resultado, "RESTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Acción al presionar el botón Multiplicar
            private void btn_multiplicar_Click(object sender, EventArgs e)
            {
                if (!verificar_Contenido()) return;

                double num1 = double.Parse(textnum1.Text);
                double num2 = double.Parse(textnum2.Text);
                double num3 = double.Parse(textnum3.Text);
                double num4 = double.Parse(textnum4.Text);
                double resultado = num1 * num2 * num3 * num4;

                MessageBox.Show("Resultado: " + resultado, "MULTIPLICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Acción al presionar el botón Dividir
            private void btn_dividir_Click(object sender, EventArgs e)
            {
                if (!verificar_Contenido()) return;

                double num1 = double.Parse(textnum1.Text);
                double num2 = double.Parse(textnum2.Text);
                double num3 = double.Parse(textnum3.Text);
                double num4 = double.Parse(textnum4.Text);
                double resultado = num1 / num2 / num3 / num4;
                // Validación especial para no dividir entre cero
                if (num2 == 0 ||num3 == 0|| num4 == 0)
                {
                    MessageBox.Show("No se puede dividir entre cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                resultado = num1 / num2 / num3 / num4;
                MessageBox.Show("Resultado: " + resultado, "DIVISIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }


    }

        

