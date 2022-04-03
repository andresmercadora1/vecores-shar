using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vectores
{
    public partial class Ejercicio11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            int tamanio = Convert.ToInt32(txtTamanio.Text);
            int[] fibonacci = new int[tamanio];
            string data = "[ ";
            int f1 = 0, f2 = 0;
            for (int i = 0; i < fibonacci.Length; i++)
            {
                if(i == 0 || i == 1)
                {
                    fibonacci[i] = 1;
                    f1 = 1;
                    f2 = 1;
                } else
                {
                    fibonacci[i] = f1 + f2;
                    f1 = fibonacci[i - 1];
                    f2 = fibonacci[i];
                }
                data += fibonacci[i]+", ";
            }
            data += "]";
            lblFibinacci.Text = data;
        }
    }
}