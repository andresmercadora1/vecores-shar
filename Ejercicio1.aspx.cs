using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vectores
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            int tamanio = Convert.ToInt32(txtVector.Text);
            double[] vector = new double[tamanio];
            double suma = 0, prom = 0;
            string may = "[ ", aux = "[ ";

            for (int i = 0; i < tamanio; i++)
            {
                vector[i] = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor del vector en la posición " + i));
                suma += vector[i];
                aux += vector[i] + ", ";
            }

            prom = suma / tamanio;

            for (int i = 0; i < tamanio; i++)
            {
                if (vector[i] > prom)
                {
                    may += vector[i] + ", ";
                }
            }

            may += "]";
            aux += "]";

            lblVector.Text = aux;
            lblPromedio.Text = System.Convert.ToString(prom);
            lblValMayP.Text = may;
        }
    }
}