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

        /// FUNCIÓN PARA CONVERTIR STRING A MINÚSCULA
        
        protected string ConverToMinuscula(string Palabra)
        {

            Palabra = Palabra.Trim().ToLower();

            return Palabra;
        }

        protected void btnValidar_Click1(object sender, EventArgs e)
        {

            string Usuario = ConverToMinuscula(txtUsuario.Text); /// ALMACENO EL NOMBRE DEL USUARIO EN MINÚSCULA
            string Clave = ConverToMinuscula(txtClave.Text); /// ALMACENO LA CONTRASEÑA DEL USUARIO EN MINÚSCULA

            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtClave.Text))
            {
                txtUsuario.BackColor = System.Drawing.Color.DarkRed;
                txtClave.BackColor = System.Drawing.Color.DarkRed;
                return;
            }else if ( Usuario == "claudio" && Clave == "casas")
            {
                Server.Transfer("Ejercicio4B.aspx");

                /// INSTRUCCIONES
            }
            else
            {
                Server.Transfer("Ejercicio4C.aspx");
            }
        }

    }
}