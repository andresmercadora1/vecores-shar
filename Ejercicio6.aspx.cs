using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vectores
{
    public partial class Ejercicio6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            int tamanio = Convert.ToInt32(txtVector.Text);
            int[] vector = new int[tamanio];
            int[] vectorInv = new int[tamanio];
            int tam = tamanio - 1;
            string mostrar = "[ ";
            string mostrarInv = "[ ";

            for (int i = 0; i < tamanio; i++)
            {
                vector[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor del vector en la posición " + i));
                vectorInv[tam] = vector[i];
                mostrar += vector[i] + ", ";
                tam--;
            }

            for (int i = 0; i < tamanio; i++)
            {
                mostrarInv += vectorInv[i] + ", ";
            }

            mostrar += "]";
            mostrarInv += "]";

            lblOriginal.Text = mostrar;
            lblInvertido.Text = mostrarInv;
        }
    }
}