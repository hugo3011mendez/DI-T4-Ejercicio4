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

        }
    }
}
