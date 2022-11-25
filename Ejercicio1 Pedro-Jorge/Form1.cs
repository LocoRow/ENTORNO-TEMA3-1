
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_Pedro_Jorge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = 'o';
            int numPalabras = 0;
            double coste;

            int cuentaPalabras = 0, i = 0; 

            textoTelegrama = txtTelegrama.Text;

            if (cbUrgente.Checked)
                tipoTelegrama = 'u';

            //Erróneo numPalabras = textoTelegrama.Length;

            // Cálculo del número de palabras de una cadena 
            /*for (i=0;i< textoTelegrama.Length;i++)
            {
                if (textoTelegrama[i].ToString() == " ")
                    cuentaPalabras ++; 

            }*/

            while (textoTelegrama.IndexOf(" ") != -1)
            {
                cuentaPalabras++;
                textoTelegrama = textoTelegrama.Substring(textoTelegrama.IndexOf(" ") + 1, textoTelegrama.Length - textoTelegrama.IndexOf(" ") - 1);
            }



            if (textoTelegrama.Length > 0)
                cuentaPalabras++;

            if (tipoTelegrama != 'u')
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 0.5 * numPalabras;
            else
            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros ";
            /* Pedro es un pringao
             quiero cambiar esto solo en la rama nueva 
            que he creado de COMENTARIO*/
        }

    }
}

