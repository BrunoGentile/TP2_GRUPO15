using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO_15
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// EVENTOS PARA IR A LOS EJERCICIOS

        protected void BTN_Ejercicio1_Click(object sender, EventArgs e)
        {
            Server.Transfer("Ejercicio1.aspx");
        }

<<<<<<< HEAD
        protected void BTN_Ejercicio2_Click(object sender, EventArgs e)
=======
        protected void Button2_Click(object sender, EventArgs e)
>>>>>>> 612a7a9... hice la funcionalidad de los botones de inicio y arregle el ejercicio 3 para que pinte los los colores
        {
            Server.Transfer("Ejercicio2.aspx");
        }

<<<<<<< HEAD
        protected void BTN_Ejercicio3_Click(object sender, EventArgs e)
=======
        protected void Button3_Click(object sender, EventArgs e)
>>>>>>> 612a7a9... hice la funcionalidad de los botones de inicio y arregle el ejercicio 3 para que pinte los los colores
        {
            Server.Transfer("Ejercicio3.aspx");
        }

<<<<<<< HEAD
        protected void BTN_Ejercicio4_Click(object sender, EventArgs e)
=======
        protected void Button4_Click(object sender, EventArgs e)
>>>>>>> 612a7a9... hice la funcionalidad de los botones de inicio y arregle el ejercicio 3 para que pinte los los colores
        {
            Server.Transfer("Ejercicio4A.aspx");
        }

<<<<<<< HEAD
        protected void BTN_Ejercicio5_Click(object sender, EventArgs e)
=======
        protected void Button5_Click(object sender, EventArgs e)
>>>>>>> 612a7a9... hice la funcionalidad de los botones de inicio y arregle el ejercicio 3 para que pinte los los colores
        {
            Server.Transfer("Ejercicio5.aspx");
        }
    }
}