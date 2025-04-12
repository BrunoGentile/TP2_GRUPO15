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
            string producto = txtProducto.Text;
            string cantidad = txtCantidad.Text;
            int CantidadTotal = int.Parse(txtCantidad.Text) + int.Parse(txtCantidad2.Text); /// SUMA DE CANTIDADES PARA MOSTRAR TOTAL

            if (ViewState["Productos"] == null)
            {
                ViewState["Productos"] = new List<string>();
            }

            List<string> productos = ViewState["Productos"] as List<string>;


            if (producto.Length == 0 || cantidad.Length == 0)
            {
                txtProducto.BackColor = System.Drawing.Color.Red;
                txtCantidad.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                txtProducto.BackColor = System.Drawing.Color.White;
                txtCantidad.BackColor = System.Drawing.Color.White;
                productos.Add(producto);
            }

            string tabla = "<table border='1'>";
            tabla += "<tr><td>Producto</td></tr>";

            foreach (string product in productos)
            {
                tabla += "<tr><td>" + product + "</td></tr>";
            }
            
            tabla += "<tr><td>TOTAL</td><td>" + CantidadTotal + "</td></tr>"; /// MUESTRA CANTIDAD TOTAL
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