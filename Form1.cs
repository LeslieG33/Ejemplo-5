using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_5
{
    public partial class frmEjemplo5 : Form
    {
        public frmEjemplo5()
        {
            InitializeComponent();
        }

        private void cmdMayor_Click(object sender, EventArgs e)
        {
            // Programa que determina si una persona es mayor de edad utilizando la selectiva
            // simple
            // Ejemplo 5
            // Leslie Giselle Avila Romero 23211918

            // Declaración de variables
            byte Edad;

            // Asignación de valores a las varibales
            Edad = Convert.ToByte(txtEdad.Text);

            // Condición que determina mayor de edad
            if (Edad >= 18)
                lblMayMen.Text = "Mayor de edad";
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            lblMayMen.Text = "";
            txtEdad.Clear();

        }

        private void cmdSalida_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
