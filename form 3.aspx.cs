using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace clase_1503
{
    public partial class form_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnmostrar_Click(object sender, EventArgs e)
        {
            int tamano;
            int prom, suma = 0, cont = 0, valores = 0;
            string nrogran = "";
            string dato = "";
            tamano = Convert.ToInt32(txtingreso.Text);
            int[] vector = new int[tamano];
            for (int i = 0; i < vector.Length; i++)
            {
                valores = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese los valores" + valores + "Valores del vector"));
                vector[i] = valores;
                dato = dato + "  ," + vector[i];
            }
            lblvalores.Text = dato;
        }
    }
}