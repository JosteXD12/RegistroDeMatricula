<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProfesor.aspx.cs" Inherits="MatriculaWeb.frmProfesor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 459px;
        }
        .auto-style3 {
            width: 459px;
            height: 26px;
        }
        .auto-style5 {
            height: 26px;
        }
        .auto-style6 {
            width: 446px;
        }
        .auto-style7 {
            width: 446px;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Text="Cédula:"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBoxProfesor_Cedula" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBoxProfesor_Nombre" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label3" runat="server" Text="PrimerApellido:"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBoxProfesor_PrimerApellido" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:DropDownList ID="DDListProfesores" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label4" runat="server" Text="SegundoApellido "></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBoxProfesor_SegundoApellido" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnCargarDatoss" runat="server" OnClick="Button1_Click" Text="Cargar Datos " />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label5" runat="server" Text="Telefono:"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBoxProfesor_Telefono" runat="server"></asp:TextBox>
                    </td>
                    <td>`</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label6" runat="server" Text="Email:"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBoxProfesor_Email" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label7" runat="server" Text="Dirreccion:"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBoxProfesor_Direccion" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="btnProfesor_insertar" runat="server" OnClick="btnProfesor_insertar_Click" Text="Insertar" />
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="btnProfesor_Modificar" runat="server" Text="Modificar" />
                    </td>
                    <td>
                        <asp:Button ID="btnProfesor_Eliminar" runat="server" Text="Eliminar" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="DGVProfesores" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </form>
</body>
</html>
