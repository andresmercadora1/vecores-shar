using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vectores
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            int tamanio = Convert.ToInt32(txtVector.Text);
            int[] vectorA = new int[tamanio];
            int[] vectorB = new int[tamanio];
            int[] vectorC = new int[tamanio];

            string vecA = "[ ", vecB = "[ ", vecC = "[ ";

            for (int i = 0; i < tamanio; i++)
            {
                vectorA[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor del vector A en la posición " + i));
                vectorB[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor del vector B en la posición " + i));
                vectorC[i] = vectorA[i] + vectorB[i];
                vecA += vectorA[i] + ", ";
                vecB += vectorB[i] + ", ";
                vecC += vectorC[i] + ", ";
            }

            vecA += "]";
            vecB += "]";
            vecC += "]";

            lblVectorA.Text = vecA;
            lblVectorB.Text = vecB;
            lblVectorC.Text = vecC;
        }
    }
}