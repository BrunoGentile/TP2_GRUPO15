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

        protected void VerZona() /// CAMBIA EL TEXTO DEL LABEL PARA MOSTRAR LA ZONA SELECCIONADA
        {
            LBL_Zona.Text = ddlCiudad.SelectedItem.Text;
        }

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

        private bool EsCampoValido(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.BackColor = System.Drawing.Color.Red;
                return false;
            }
            else
            {
                txt.BackColor = System.Drawing.Color.White;
                return true;
            }
        }
        protected void btnVerResumen_Click(object sender, EventArgs e)
        {
            bool nombreValido = EsCampoValido(txtNombre);
            bool apellidoValido = EsCampoValido(txtApellido);

            if (!nombreValido || !apellidoValido)
            {
                return;
            }


            if (chkTemas.SelectedIndex == -1)
            {
                
                lblMensajeError.Text = "Debe seleccionar al menos un tema.";
                return;
            }
            else
            {
                lblMensajeError.Text = "";
                ///Server.Transfer("Ejercicio2B.aspx");
            }

            VerZona(); /// COLOCA EN EL LABEL LA ZONA SELECCIONADA
            lblMensajeError.Text = "";
        }

    }
        
}