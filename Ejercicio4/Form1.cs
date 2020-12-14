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
        // Creo variables que gestionarán el Timer
        int minutos = 0;
        int segundos = 0;

        // Creo y declaro el delegado y la Hashtable
        public delegate double Operacion(double num1, double num2);
        Hashtable operaciones = new Hashtable();

        Operacion seleccionada; // Creo una variable de tipo delegado para guardar la operación seleccionada 

        public Form1()
        {
            InitializeComponent();

            lblSigno.Text = "";
            lblResultado.Text = "";

            // Añado los delegados a la Hashtable
            operaciones.Add("Suma", new Operacion((num1, num2) => num1 + num2));
            operaciones.Add("Resta", new Operacion((num1, num2) => num1 - num2));
            operaciones.Add("Multiplicación", new Operacion((num1, num2) => num1 * num2));
            operaciones.Add("División", new Operacion((num1, num2) => num1 / num2));
        }


        // Función que gestiona las acciones a realizar cuando se pulsa un RadioButton
        public void pulsarRadioButton(object sender, EventArgs e)
        {
            RadioButton seleccionado = (RadioButton)sender;

            seleccionada = (Operacion)operaciones[seleccionado.Text]; // Guardo en seleccionada, el valor correspondiente a la clave igual al texto del RadioButton

            lblSigno.Text = seleccionado.Tag.ToString(); // Establezco el label del signo al tag del RadioButton, que se corresponde con su signo
        }
        

        // Función que gestiona las acciones a realizar cuando se pulsa el botón de mostrar resultado
        private void btnOperacion_Click(object sender, EventArgs e)
        {
            try
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
            catch (FormatException)
            {
                MessageBox.Show("Debes escribir números para operar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Función que gestiona las acciones a realizar con cada tick del timer
        private void timer_Tick(object sender, EventArgs e)
        {
            segundos++;

            if (segundos == 60)
            {
                segundos = 0;
                minutos++;
            }

            Text = String.Format("{0:D2} : {1:D2}", minutos, segundos);
        }
    }
}
