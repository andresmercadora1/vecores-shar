using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vectores
{
    public partial class Ejercicio7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            int tamanio = Convert.ToInt32(txtTamanio.Text);
            int[] vectorM = new int[tamanio];
            int[] vectorN = new int[tamanio];
            string mostrarM = "[ ";
            string mostrarN = "[ ";
            int cont = 0;

            for (int i = 0; i < tamanio; i++)
            {
                vectorM[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor del vector M en la posición " + i));
                vectorN[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor del vector N en la posición " + i));
                mostrarM += vectorM[i] + ", ";
                mostrarN += vectorN[i] + ", ";

                if (vectorM[i] == vectorN[i])
                {
                    cont++;
                }
            }

            mostrarM += "]";
            mostrarN += "]";

            lblVectorM.Text = mostrarM;
            lblVectorN.Text = mostrarN;

            if (cont == tamanio)
            {
                lblResult.Text = "Los vectores son iguales";
            } else
            {
                lblResult.Text = "Los vectores son diferentes";
            }
        }
    }
}