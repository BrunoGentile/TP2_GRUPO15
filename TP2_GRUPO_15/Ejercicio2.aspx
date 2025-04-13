<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TP2_GRUPO_15.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 10px;
        }
        .auto-style4 {
            height: 23px;
            width: 10px;
        }
        .auto-style5 {
            width: 70px;
        }
        .auto-style6 {
            height: 23px;
            width: 70px;
        }
        .auto-style7 {
            width: 160px;
        }
        .auto-style8 {
            height: 23px;
            width: 160px;
        }
        .auto-style9 {
            width: 158px;
        }
        .auto-style10 {
            width: 50px;
        }
        .auto-style11 {
            width: 50px;
            height: 23px;
        }
        .auto-style12 {
            width: 158px;
            height: 23px;
        }
        .auto-style13 {
            width: 50px;
            height: 40px;
        }
        .auto-style14 {
            width: 158px;
            height: 40px;
        }
        .auto-style15 {
            height: 40px;
        }
        .auto-style16 {
            width: 58px;
        }
        .auto-style17 {
            height: 23px;
            width: 58px;
        }
        .auto-style18 {
            width: 50px;
            height: 48px;
        }
        .auto-style19 {
            width: 158px;
            height: 48px;
        }
        .auto-style20 {
            height: 48px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style6">Nombre:</td>
            <td class="auto-style8">
                <asp:TextBox ID="txtNombre" runat="server" Width="150px" AutoPostBack="true"  OnTextChanged="ValidarCampos"></asp:TextBox>
            </td>
            <td class="auto-style17"></td>
            <td class="auto-style2">
                <asp:Button ID="btnInicio" runat="server" OnClick="btnInicio_Click" Text="Inicio" Width="55px" />
            </td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">Apellido:</td>
            <td class="auto-style7">
                <asp:TextBox ID="txtApellido" runat="server" Width="150px" AutoPostBack="true" OnTextChanged="ValidarCampos"></asp:TextBox>
            </td>
            <td class="auto-style16">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">Ciudad</td>
            <td class="auto-style7">
                <asp:DropDownList ID="ddlCiudad" runat="server" Width="120px">
                    <asp:ListItem Value="Zona Norte">Gral. Pacheco</asp:ListItem>
                    <asp:ListItem Value="Zona Oeste">San Miguel</asp:ListItem>
                    <asp:ListItem Value="Zona Sur">Boedo</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style16">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style6">Temas</td>
            <td class="auto-style8"></td>
            <td class="auto-style17"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style7">
                <asp:CheckBoxList ID="chkTemas" runat="server" BorderStyle="None">
                </asp:CheckBoxList>
            </td>
            <td class="auto-style16">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style7">
                <asp:Button ID="btnVerResumen" runat="server" OnClick="btnVerResumen_Click" Text="Ver resumen" />
            </td>
            <td class="auto-style16">
                <asp:Label ID="lblMensajeError" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
        </div>
    </form>
    <form id="form2" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style18"></td>
                    <td class="auto-style19">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="18pt" Text="Resumen"></asp:Label>
                    </td>
                    <td class="auto-style20"></td>
                    <td class="auto-style20"></td>
                    <td class="auto-style20"></td>
                    <td class="auto-style20"></td>
                    <td class="auto-style20"></td>
                </tr>
                <tr>
                    <td class="auto-style13"></td>
                    <td class="auto-style14">
                        Nombre:</td>
                    <td class="auto-style15">
                        <asp:Label ID="LBL_Nombre" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style15"></td>
                    <td class="auto-style15"></td>
                    <td class="auto-style15"></td>
                    <td class="auto-style15"></td>
                </tr>
                <tr>
                    <td class="auto-style11"></td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style11"></td>
                    <td class="auto-style12">Apellido:</td>
                    <td class="auto-style2">
                        <asp:Label ID="LBL_Apellido" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style11"></td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style9">Zona:</td>
                    <td>
                        <asp:Label ID="LBL_Zona" runat="server"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style9">Los temas elegidos son:</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style9">
                        <asp:Label ID="lblTemas" runat="server"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
