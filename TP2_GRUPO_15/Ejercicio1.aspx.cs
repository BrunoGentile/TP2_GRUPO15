using System;
using System.Collections.Generic;
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

            if (ViewState["Productos"] == null)
            {
                ViewState["Productos"] = new List<string>();
            }

            List<string> productos = ViewState["Productos"] as List<string>;

            productos.Add(producto);

            string tabla = "<table border='1'>";
            tabla += "<tr><td>Producto</td></tr>";

            foreach (string product in productos)
            {
                tabla += "<tr><td>" + product + "</td></tr>";
            }
            tabla += "<tr><td>TOTAL</td></tr>";
            tabla += "</table>";

            lblTabla.Text = tabla;

            txtProducto.Text = "";
        }
    }
}