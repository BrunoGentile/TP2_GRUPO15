using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO_15
{
    public partial class Ejercicio4C : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string usuario;
            string contraseña;
            if (!IsPostBack) { 
            usuario = Request["txtUsuario"].ToString();
            contraseña = Request["txtClave"].ToString();
            if (usuario != "claudio" && contraseña != "casas")
            {
                LBL_Error.Text = "EL USUARIO Y CONTRASEÑA ES INVALIDO";
            }
            else if (usuario != "claudio")
            {
                LBL_Error.Text = "EL USUARIO ES INVALIDO";
            }
            else
            {
                LBL_Error.Text = "LA CONTRASEÑA ES INVALIDA";
            }
            }


        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio4A.aspx");
        }
    }
    
}