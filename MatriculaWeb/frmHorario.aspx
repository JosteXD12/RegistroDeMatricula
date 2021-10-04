<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmHorario.aspx.cs" Inherits="MatriculaWeb.frmHorario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 478px;
            margin-left: 40px;
        }
        .auto-style2 {
            width: 291px;
        }
        .auto-style3 {
            width: 478px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server" Text="Descripcion: "></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBoxHorario_Descripcion" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server" Text="Dia:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBoxHorario_Dia" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:DropDownList ID="DDListHorario" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label3" runat="server" Text="Horario inicio:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBoxHorario_Inicio" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnHorario_Cargardatos" runat="server" OnClick="Button4_Click" style="height: 29px" Text="Cargar Datos " />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label4" runat="server" Text="Hora fin:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBoxHorario_Fin" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="btnHorario_Insertar" runat="server" OnClick="btnHorario_Insertar_Click" Text="Insertar" />
                    </td>
                    <td class="auto-style2">
                        <asp:Button ID="btnHorario_Modificar" runat="server" Text="Modificar" />
                    </td>
                    <td>
                        <asp:Button ID="btnHorario_Eliminar" runat="server" Text="Eliminar" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="GridViewHorario" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
