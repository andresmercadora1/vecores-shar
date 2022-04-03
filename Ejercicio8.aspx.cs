using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vectores
{
    public partial class Ejercicio8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            int tamanio = Convert.ToInt32(txtVector .Text);
            int[] vector = new int[tamanio];
            string mostrar = "[ ";
            int cont = 0, asc = 0;

            for (int i = 0; i < tamanio; i++)
            {
                vector[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor del vector en la posición " + i));
                mostrar += vector[i] + ", ";

               if(vector[i] >= asc)
                {
                    asc = vector[i];
                    cont++;
                }
            }

            mostrar += "]";
            lblVector.Text = mostrar;

            if (cont == tamanio)
            {
                lblResult.Text = "SI";
            } else
            {
                lblResult.Text = "NO";
            }
        }
    }
}