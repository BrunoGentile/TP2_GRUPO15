﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP2_GRUPO_15.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejercicio 1</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 10px;
        }
        .auto-style3 {
            width: 189px;
        }
        .auto-style4 {
            width: 160px;
        }
        .auto-style5 {
            width: 65px;
        }
        .auto-style6 {
            width: 10px;
            height: 23px;
        }
        .auto-style7 {
            width: 189px;
            height: 23px;
        }
        .auto-style8 {
            width: 160px;
            height: 23px;
        }
        .auto-style9 {
            height: 23px;
        }
        .auto-style10 {
            width: 65px;
            height: 23px;
        }
        .auto-style11 {
            width: 110px;
        }
        .auto-style12 {
            height: 23px;
            width: 110px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">Ingrese nombre del producto:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtProducto" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">Cantidad:</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txtCantidad" runat="server" Width="100px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6" id="txtProducto2"></td>
                    <td class="auto-style7" id="txtProducto2">
                        <asp:Label ID="Label1" runat="server" Text="Ingrese nombre del producto: "></asp:Label>
                    </td>
                    <td class="auto-style8" id="txtProducto2">
                        <asp:TextBox ID="txtProducto2" runat="server" Width="149px"></asp:TextBox>
                    </td>
                    <td class="auto-style6" id="txtProducto2"></td>
                    <td class="auto-style10" id="txtProducto2">
                        <asp:Label ID="Label2" runat="server" Text="Cantidad:"></asp:Label>
                    </td>
                    <td class="auto-style12" id="txtProducto2">
                        <asp:TextBox ID="txtCantidad2" runat="server" Width="100px"></asp:TextBox>
                    </td>
                    <td class="auto-style9" id="txtProducto2"></td>
                </tr>
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style7">
                        &nbsp;</td>
                    <td class="auto-style8"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style10"></td>
                    <td class="auto-style12">
                        &nbsp;</td>
                    <td class="auto-style9"></td>
                </tr>
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style7">
                        <asp:Button ID="BtnTabla" runat="server" Font-Bold="False" Font-Size="Small" style="margin-bottom: 0px" Text="Generar Tabla" OnClick="BtnTabla_Click" />
                    </td>
                    <td class="auto-style8"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style10"></td>
                    <td class="auto-style12">
                        <asp:Button ID="btnInicio" runat="server" OnClick="btnInicio_Click" Text="Inicio" Width="58px" />
                    </td>
                    <td class="auto-style9"></td>
                </tr>
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style7">
                        &nbsp;</td>
                    <td class="auto-style8"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style10"></td>
                    <td class="auto-style12"></td>
                    <td class="auto-style9"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="lblTabla" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
