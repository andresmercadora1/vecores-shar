using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vectores
{
    public partial class Ejercicio5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            int tamanio = Convert.ToInt32(txtTamanio.Text);
            int[] vector = new int[tamanio];
            int cero = 0, negativo = 0, positivo = 0, sumaN = 0, sumaP = 0;
            string mostrar = "[ ";

            for (int i = 0; i < tamanio; i++)
            {
                vector[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor del vector en la posición " + i));
                if (vector[i] < 0)
                {
                    negativo++;
                    sumaN += vector[i];
                }
                else if (vector[i] == 0)
                {
                    cero++;
                } else
                {
                    positivo++;
                    sumaP += vector[i];
                }

                mostrar += vector[i] + ", ";
            }

            mostrar += "]";
            lblVector.Text = mostrar;
            lblCero.Text = System.Convert.ToString(cero);
            lblNegativo.Text = System.Convert.ToString(negativo);
            lblSumaN.Text = System.Convert.ToString(sumaN);
            lblPositivo.Text = System.Convert.ToString(positivo);
            lblSumaP.Text = System.Convert.ToString(sumaP);
        }
    }
}