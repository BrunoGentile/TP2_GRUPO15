﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO_15
{
    public partial class Ejercicio5 : System.Web.UI.Page
    {

        /// MÉTODO PARA CALCULAR PRECIO TOTAL

        protected float CalcularPrecioTotal() /// RETORNA PRECIO TOTAL
        {
            float PrecioTotal = 0; /// VARIABLE QUE ALMACENA PRECIO TOTAL

            switch (ddlMemoria.SelectedIndex) /// ALMACENA EL PRECIO DE LA MEMORIA
            {
                case 0: PrecioTotal += 200; break;
                case 1: PrecioTotal += 375; break;
                case 2: PrecioTotal += 500; break;
            }

            foreach (ListItem Item in cblAccesorios.Items) /// RECORRE LOS ACCESORIOS
            {
                if (Item.Selected) /// VERIFICA QUE EL ITEM ESTÉ SELECCIONADO
                {

                    switch (int.Parse(Item.Value))
                    {
                        case 0: PrecioTotal += 2000.50f; break;
                        case 1: PrecioTotal += 550.50f; break;
                        case 2: PrecioTotal += 1200; break;
                    }

                }
            }

            return PrecioTotal;
        }

        /// MÉTODO QUE SE EJECUTA CUANDO SE CARGA LA PÁGINA

        protected void Page_Load(object sender, EventArgs e)
        {
            //CARGAR DROPDOWNLIST
            if (!IsPostBack)
            {
                ddlMemoria.Items.Add("2 GB");
                ddlMemoria.Items.Add("4 GB");
                ddlMemoria.Items.Add("6 GB");
            }
        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }

        /// MÉTODO CALCULAR PRECIO

        protected void btnCalcularPrecio_Click(object sender, EventArgs e)
        {

            // string precioSeleccionado = ddlMemoria.SelectedValue;

            // decimal precioMemoria = decimal.TryParse(precioSeleccionado, out decimal resultado) ? resultado : 0;
            float PrecioAnterior = 0;
            float PrecioTotal = 0;

            if (cblAccesorios.SelectedItem != null) //Validar que se seleccione una opción
            {
                PrecioTotal = CalcularPrecioTotal();

                if (PrecioTotal == 4251)
                {
                    PrecioTotal *= 0.9f;
                    lblSinDescuento.Text = "Sin descuento: $4251 ";
                }
                else
                {
                    lblSinDescuento.Text = "";
                }

                LBL_PrecioFinal.Text = "El precio final es de " + PrecioTotal.ToString("F2") + " $";

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Seleccione por lo menos un accesorio.');", true);
            }

            if (ViewState["PrecioAnterior"] != null)
            {
                PrecioAnterior = (float)ViewState["PrecioAnterior"];
                lblAnterior.Text = "Precio anterior: " + PrecioAnterior.ToString("F2") + " $";

                float diferencia = 0;

                if (PrecioAnterior > PrecioTotal)
                {
                    diferencia = PrecioAnterior - PrecioTotal;
                }
                else
                {
                    diferencia = PrecioTotal - PrecioAnterior;
                }
                lblDiferencia.Text = "la diferencia de precio con el cálculo anterior es de $" + diferencia.ToString("F2");


            }

            ViewState["PrecioAnterior"] = PrecioTotal;

            // string precioSeleccionado = ddlMemoria.SelectedValue;

            // decimal precioMemoria = decimal.TryParse(precioSeleccionado, out decimal resultado) ? resultado : 0;


        }

        /// BOTÓN PARA DOLARIZAR

        protected void BTN_Dolarizar_Click(object sender, EventArgs e) /// DOLARIZA EL PRECIO
        {
            float PrecioTotal = CalcularPrecioTotal() / 1074.09f;
            LBL_PrecioFinal.Text = "El precio final es de " + PrecioTotal.ToString("F2") + " USD";
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            // Reiniciar selección del dropdown
            ddlMemoria.SelectedIndex = -1;

            // Destildar todos los checkboxes
            foreach (ListItem item in cblAccesorios.Items)
            {
                item.Selected = false;
            }

            // Limpiar el texto del label del precio final
            LBL_PrecioFinal.Text = "";
            lblDiferencia.Text = "";
            lblAnterior.Text = "";
            lblSinDescuento.Text = "";
        }
    }
}
