using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace clase_1503
{
    public partial class form_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnmostrar_Click(object sender, EventArgs e)
        {
            string[] nombres1 = new string[5];
            nombres1[0] = "Paola";
            nombres1[1] = "Diana";
            nombres1[2] = "Martha";
            nombres1[3] = "Ana";
            nombres1[4] = "Carolina";
            //txtmostrar.Text = System.Convert.ToString((nombres1[0] + "," + nombres1[1] + ";" + nombres1[2] + "," + nombres1[3] + "," + nombres1[4]));

            for (int i = 0; i < nombres1.Length; i++)
            {
                txtmostrar.Text = System.Convert.ToString(nombres1[i]);
            }
        }
    }
}