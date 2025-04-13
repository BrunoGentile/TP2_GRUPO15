using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO_15
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }

        protected void linkbVerde_Click(object sender, EventArgs e)
        {
           lblTexto.ForeColor = System.Drawing.Color.Green;
        }

        protected void linkbAzul_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = System.Drawing.Color.Blue;
        }

        protected void linkbRojo_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = System.Drawing.Color.Red;
        }
    }
}