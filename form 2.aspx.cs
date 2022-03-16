using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace clase_1503
{
    public partial class form_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnmostrar_Click(object sender, EventArgs e)
        {
            int[] numeros = new int[5];
            numeros[0] = 1;
            numeros[1] = 2;
            numeros[2] = 3;
            numeros[3] = 4;
            numeros[4] = 5;

            //txtmostrar.Text = System.Convert.ToString((numeros[0] + "," + numeros [1] + "," + numeros [2] + "," + numeros [3] + "," + numeros [4] + "," ));

            for (int i = 0; i < numeros.Length; i++)
            {

            }
        }
    }
}