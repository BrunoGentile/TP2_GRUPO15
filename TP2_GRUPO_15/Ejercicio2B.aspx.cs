﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO_15
{
    public partial class Ejercicio2B : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            string zona;
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio2.aspx");
        }
    }
}