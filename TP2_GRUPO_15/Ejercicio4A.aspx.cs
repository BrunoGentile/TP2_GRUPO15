using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO_15
{
    public partial class Ejercicio4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnValidar_Click1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtClave.Text))
            {
                    return;
            }else if (txtUsuario.Text == "claudio" && txtClave.Text == "casas")
            {
                /// INSTRUCCIONES
            }else
            {
                Server.Transfer("Ejercicio4C.aspx");
            }
        }

    }
}