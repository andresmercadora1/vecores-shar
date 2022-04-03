using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vectores
{
    public partial class Ejercicio4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            int tamanio = Convert.ToInt32(txtTamanio.Text);
            double[] vectorOrg = new double[tamanio];
            double[] vectorResult = new double[tamanio];
            string mostrar = "[ ";
            string mostrarResult = "[ ";

            for (int i = 0; i < tamanio; i++)
            {
                vectorOrg[i] = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor del vector en la posición " + i));
                vectorResult[i] = Math.Pow(vectorOrg[i], 2);

                mostrar += vectorOrg[i] + ", ";
                mostrarResult += vectorResult[i] + ", ";
            }

            mostrar += "]";
            mostrarResult += "]";

            lblVectorOrg.Text = mostrar;
            lblVectorResult.Text = mostrarResult;

        }
    }
}