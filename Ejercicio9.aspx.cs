using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vectores
{
    public partial class Ejercicio9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Buscar_Click(object sender, EventArgs e)
        {
            int tamanio = Convert.ToInt32(txtTamanio.Text);
            int[] vector = new int[tamanio];
            string mostrar = "[ ";
            int busqueda = Convert.ToInt32(txtBusqueda.Text);
            int posi = 0;

            for (int i = 1; i <= tamanio; i++)
            {
                vector[i-1] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor del vector en la posición " + i));
                mostrar += vector[i-1] + ", ";

                if (vector[i-1] == busqueda)
                {
                    posi = i-1;
                }
                
            }

            mostrar += "]";
            lblVector.Text = mostrar;

            if (posi > 0)
            {
                lblResult.Text = "La posición del vector es: " + posi;
            } else
            {
                lblResult.Text = "NO";
            }
        }
    }
}