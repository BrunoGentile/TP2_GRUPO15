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


        protected void ValidarCampos(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0 && txtApellido.Text.Length == 0)
            {
                txtNombre.BackColor = System.Drawing.Color.Red;
                txtApellido.BackColor = System.Drawing.Color.Red;
                return;
            }
            else
            {
                txtNombre.BackColor = System.Drawing.Color.White;
                txtApellido.BackColor = System.Drawing.Color.White;
            }


        }
        protected void VerNombre() /// MUESTRA EL TEXTO DEL LABEL PARA MOSTRAR EL NOMBRE 
        {
            string nombre = txtNombre.Text;
            LBL_Nombre.Text = "<b>" + nombre + "</b>";
        }
        protected void VerApellido() /// MUESTRA EL TEXTO DEL LABEL PARA MOSTRAR EL APELLIDO
        {
            string apellido = txtApellido.Text;
            LBL_Apellido.Text = "<b>" + apellido + "</b>";        
        }
        protected void VerZona() /// CAMBIA EL TEXTO DEL LABEL PARA MOSTRAR LA ZONA SELECCIONADA
        {
            LBL_Zona.Text = "<b>" + ddlCiudad.SelectedItem.Text + "</b>";
        }

        protected void VerTemas()
        {
            lblTemas.Text = "";

            foreach (ListItem item in chkTemas.Items)
            {
                if (item.Selected)
                {
                    lblTemas.Text += "<b>" + item.Text + "</b><br/>";
                }
            }
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

        private string firstLetterToUpper(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return "";
            }

            texto = texto.ToLower();
            return char.ToUpper(texto[0]) + texto.Substring(1);
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
            }
            VerNombre();
            lblMensajeError.Text = "";

            VerApellido();
            lblMensajeError.Text = "";

            VerZona(); /// COLOCA EN EL LABEL LA ZONA SELECCIONADA
            lblMensajeError.Text = "";

            VerTemas();
            lblMensajeError.Text = "";
        }


        


    }
        
}