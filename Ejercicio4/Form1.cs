using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        // Creo y declaro el delegado y la Hashtable
        public delegate double Operacion(double num1, double num2);
        Hashtable operaciones = new Hashtable();

        // Procedo a crear los diferentes delegados Operacion con funciones lambda indicando cada operación aritmética necesaria :
        Operacion suma = new Operacion((num1, num2) =>
        {
            return num1 + num2;
        });

        Operacion resta = new Operacion((num1, num2) =>
        {
            return num1 - num2;
        });

        Operacion multiplicacion = new Operacion((num1, num2) =>
        {
            return num1 * num2;
        });

        Operacion division = new Operacion((num1, num2) =>
        {
            return num1 / num2;
        });

        Operacion seleccionada;

        public Form1()
        {
            InitializeComponent();

            lblSigno.Text = "";
            lblResultado.Text = "";

            // Añado los delegados a la Hashtable
            operaciones.Add("Suma", suma);
            operaciones.Add("Resta", resta);
            operaciones.Add("Multiplicación", multiplicacion);
            operaciones.Add("División", division);
        }

        public void pulsarRadioButton(object sender, EventArgs e)
        {
            RadioButton seleccionado = (RadioButton)sender;

            // Recorro la Hashtable 
            foreach (DictionaryEntry de in operaciones)
            {
                if (de.Key.ToString() == seleccionado.Text) // Si la entrada de la Hashtable tiene como clave el texto del RadioButton pulsado...
                {
                    seleccionada = (Operacion)de.Value; // Guardo en el delegado seleccionada el valor de dicha entrada, que también es un delegado
                }
            }

            // Según el RadioButton que se haya seleccionado, establezco el signo de la operación
            if (seleccionado.Text == "Suma")
            {
                lblSigno.Text = "+";
            }
            else if (seleccionado.Text == "Resta")
            {
                lblSigno.Text = "-";
            }
            else if (seleccionado.Text == "Multiplicación")
            {
                lblSigno.Text = "X";
            }
            else if (seleccionado.Text == "División")
            {
                lblSigno.Text = "/";
            }
        }

        private void btnOperacion_Click(object sender, EventArgs e)
        {
            if (seleccionada != null)
            {
                lblResultado.Text = seleccionada(Convert.ToDouble(txtNum1.Text), Convert.ToDouble(txtNum2.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Tiene que indicar un tipo de operación!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
