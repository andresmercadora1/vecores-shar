using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vectores
{
    public partial class Ejercicio10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            int tamanio = Convert.ToInt32(txtTamanio.Text);
            int[] vectorA = new int[tamanio];
            int[] vectorB = new int[tamanio];
            int[] vectorC = new int[tamanio];
            int cont = tamanio - 1;
            string vecA = "[ ", vecB = "[ ", vecC = "[ ";

            for (int i = 0; i < tamanio; i++)
            {
                vectorA[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Digite el valor A del vector en la posición " + (i+1)));
                vectorB[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Digite el valor B del vector en la posición " + (i+1)));
                vecA += vectorA[i] + "  ";
                vecB += vectorB[i] + "  ";
            }

            for (int i = 0; i < tamanio; i++)
            {
                vectorC[i] = vectorA[i] * vectorB[cont];
                vecC += vectorC[i] + "  ";
                cont--;
            }

            vecA += "]";
            vecB += "]";
            vecC += "]";

            lblVectorA.Text = System.Convert.ToString(vecA);
            lblVectorB.Text = System.Convert.ToString(vecB);
            lblVectorC.Text = System.Convert.ToString(vecC);

        }
    }
}