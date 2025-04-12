using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO_15
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                chkTemas.Items.Add("Ciencias");
                chkTemas.Items.Add("Literatura");
                chkTemas.Items.Add("Historia");
            }
        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }

        protected void btnVerResumen_Click(object sender, EventArgs e)
        {

            if (chkTemas.SelectedIndex == -1)
            {
                // No se seleccionó ningún tema: mostrar mensaje y salir
                lblMensajeError.Text = "Debe seleccionar al menos un tema.";
                return;
            }

            // Si hay al menos un tema seleccionado, borramos el mensaje (opcional)
            lblMensajeError.Text = "";
        }

    }
        
}