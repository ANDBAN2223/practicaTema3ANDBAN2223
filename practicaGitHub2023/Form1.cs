using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaGitHub2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = 'o';
            int numPalabras = 0;
            double coste;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (rUrgente.Checked)
                tipoTelegrama = 'u';
            //Obtengo el número de palabras que forma el telegrama
            int numCaracteres = textoTelegrama.Length;
            char caracter;
            if (numCaracteres > 0)
                numPalabras = 1;
            for (int i = 0; i < numCaracteres; i++)
            {
                caracter = textoTelegrama[i];
                if (caracter == ' ')
                    numPalabras++;
            }
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 2.6;
                else
                    coste = 2.5 + 0.5 * (numPalabras - 10);
            //Si el telegrama es urgente
            else
                if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
