using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Git_Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
			// Modificación desde otro repositorio
            InitializeComponent();

            //Cambio realizado por Ana Sánchez
            MessageBox.Show("¡Realizado!", "cambio", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saludos desde ¡Hola Mundo!");
			
			// Modificación en 2015
			
			// Modificación en 2016
			
			// Segunda modificación 2016 en clase

            // Modificación realizada el dia 4/5/2016 - Alumno 1º DAW - "Felipe Ruz Perez"
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
