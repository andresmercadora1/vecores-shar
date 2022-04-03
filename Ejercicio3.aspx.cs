using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vectores
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            int tamanio = Convert.ToInt32(txtTamanio.Text);
            int[] vector = new int[tamanio];
            int posic = 0, valor = 0, mayor = 0;
            string mostrar = "[ ";

            for (int i = 0; i < tamanio; i++)
            {
                vector[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor del vector en la posición " + (i+1)));
                valor = vector[i];

                if (valor > mayor)
                {
                    posic = i+1;
                    mayor = vector[i];
                }

                mostrar += vector[i] + ", ";
            }

            mostrar += "]";

            lblVector.Text = mostrar;
            lblPosicion.Text = System.Convert.ToString(posic);
            lblValor.Text = System.Convert.ToString(mayor);
        }
    }
}