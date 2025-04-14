using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security.AntiXss;
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
           lblTexto.Text = lblTexto.Text.ToUpper();
        }

        protected void Btn_restablecer_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = System.Drawing.Color.Black;
            lblTexto.Text = lblTexto.Text.ToLower();
        }

        protected void linkbRojo_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = System.Drawing.Color.Red;
            lblTexto.Text = lblTexto.Text.ToUpper();
        }

        protected void linkbAzul_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = System.Drawing.Color.Blue;
            lblTexto.Text = lblTexto.Text.ToUpper();
        }
    }
}