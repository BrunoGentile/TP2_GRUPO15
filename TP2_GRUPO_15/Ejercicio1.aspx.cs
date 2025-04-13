using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO_15
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnTabla_Click(object sender, EventArgs e)
        {

            if (txtProducto.Text.Length == 0 || txtCantidad.Text.Length == 0)
            {
                txtProducto.BackColor = System.Drawing.Color.Red;
                txtCantidad.BackColor = System.Drawing.Color.Red;
                return;

            }
            else
            {
                txtProducto.BackColor = System.Drawing.Color.White;
                txtCantidad.BackColor = System.Drawing.Color.White;


            }
            if (txtProducto2.Text.Length == 0 || txtCantidad2.Text.Length == 0)
            {
                txtProducto2.BackColor = System.Drawing.Color.Red;
                txtCantidad2.BackColor = System.Drawing.Color.Red;
                return;

            }
            else
            {
                txtProducto2.BackColor = System.Drawing.Color.White;
                txtCantidad2.BackColor = System.Drawing.Color.White;

            }

            if (txtCantidad.Text.All(char.IsLetter) || int.Parse(txtCantidad.Text) <= 0)
            {
                txtCantidad.BackColor = System.Drawing.Color.Red;
                return;
            }
            if (txtCantidad2.Text.All(char.IsLetter) || int.Parse(txtCantidad2.Text) <= 0)
            {
                txtCantidad2.BackColor = System.Drawing.Color.Red;
                return;
            }

            

            if (ViewState["Productos"] == null)
            {
                ViewState["Productos"] = new List<string>();
            }


            if (ViewState["Cantidades"] == null)
            {
                ViewState["Cantidades"] = new List<int>();
            }

            string producto = txtProducto.Text;
            int cantidad = int.Parse(txtCantidad.Text);
            string producto2 = txtProducto2.Text;
            int cantidad2 = int.Parse(txtCantidad2.Text);


            List<string> productos = ViewState["Productos"] as List<string>;
            List<int> cantidades = ViewState["Cantidades"] as List<int>;

            productos.Add(producto);
            cantidades.Add(cantidad);
            productos.Add(producto2);
            cantidades.Add(cantidad2);
           

      
            
            string tabla = "<table border='1'>";
            tabla += "<tr><td>Producto</td><td>Cantidades</td></tr>";
            
            for (int i = 0; i < productos.Count; i++)
            {
            
                tabla += "<tr><td>" + productos[i] + "</td><td>" +  cantidades[i] + "</td></tr>";
                

            }
            
            tabla += "<tr><td>TOTAL</td><td>" + "" + "</td></tr>"; /// MUESTRA CANTIDAD TOTAL
            tabla += "</table>";

            lblTabla.Text = tabla;

            txtProducto.Text = "";
            txtProducto2.Text = "";
            txtCantidad.Text = "";
            txtCantidad2.Text = "";

        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
    }
}