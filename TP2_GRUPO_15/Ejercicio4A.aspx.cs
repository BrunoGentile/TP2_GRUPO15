using System;

namespace TP2_GRUPO_15
{
    public partial class Ejercicio4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["IntentosFallidos"] == null)
            {
                Session["IntentosFallidos"] = 0;
            }
            lblIntentos.Text = "Intentos fallidos: " + Session["IntentosFallidos"].ToString();

            int intentos = (int)Session["IntentosFallidos"];

            if (intentos > 3)
            {
                Response.Redirect("Inicio.aspx");
            }


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
                lblMensaje.Text = "Se deben rellenar todos los campos."; //EN CASO DE QUE SE DEJEN CAMPOS VACÍOS
      
                return;
            }

            else if (Usuario == "claudio" && Clave == "casas")
            {
                Session["IntentosFallidos"] = 0;
                Server.Transfer("Ejercicio4B.aspx");

                /// INSTRUCCIONES
            }
            else
            {
                // Incrementar los intentos fallidos
                Session["IntentosFallidos"] = (int)Session["IntentosFallidos"] + 1;
                // Mostrar el número de intentos fallidos
                lblIntentos.Text = "Intentos fallidos: " + Session["IntentosFallidos"].ToString();
                Server.Transfer("Ejercicio4C.aspx");
            }
        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
    }
    
}