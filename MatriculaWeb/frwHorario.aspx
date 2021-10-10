<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frwHorario.aspx.cs" Inherits="MatriculaWeb.frmHorario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style7 {
            height: 26px;
        }
        .auto-style9 {
            height: 26px;
            width: 383px;
        }
        .auto-style15 {
            width: 467px;
        }
        .auto-style16 {
            width: 467px;
            height: 26px;
        }
        .auto-style17 {
            width: 383px;
        }
        .auto-style18 {
            height: 243px;
        }
        .auto-style19 {
            width: 383px;
            height: 38px;
        }
        .auto-style20 {
            width: 467px;
            height: 38px;
        }
        .auto-style21 {
            height: 38px;
        }
        .auto-style22 {
            width: 383px;
            height: 29px;
        }
        .auto-style23 {
            width: 467px;
            height: 29px;
        }
        .auto-style24 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <div>
            <asp:Panel ID="Panel1" runat="server" BackColor="#22577A">
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style17">&nbsp;</td>
                        <td class="auto-style15">
                            <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="White" Text="Registro Horario"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style17">
                            <asp:Label ID="Label1" runat="server" Text="Descripcion: " ForeColor="#80ED99"></asp:Label>
                        </td>
                        <td class="auto-style15">
                            <asp:TextBox ID="TextBoxHorario_Descripcion" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style19">
                            <asp:Label ID="Label2" runat="server" Text="Dia:" ForeColor="#80ED99"></asp:Label>
                        </td>
                        <td class="auto-style20">
                            <asp:TextBox ID="TextBoxHorario_Dia" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style21">
                            <asp:Label ID="Label5" runat="server" Text="Filtro:" ForeColor="#80ED99"></asp:Label>
                            <asp:DropDownList ID="DDListHorario" runat="server">
                            </asp:DropDownList>
                            <asp:Button ID="btnHorario_Cargardatos" runat="server" OnClick="CargarDatos_Click" style="height: 29px" Text="Cargar Datos " />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style22">
                            <asp:Label ID="Label3" runat="server" Text="Horario inicio:" ForeColor="#80ED99"></asp:Label>
                        </td>
                        <td class="auto-style23">
                            <asp:TextBox ID="TextBoxHorario_Inicio" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style24"></td>
                    </tr>
                    <tr>
                        <td class="auto-style9">
                            <asp:Label ID="Label4" runat="server" Text="Hora fin:" ForeColor="#80ED99"></asp:Label>
                        </td>
                        <td class="auto-style16">
                            <asp:TextBox ID="TextBoxHorario_Fin" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style7"></td>
                    </tr>
                    <tr>
                        <td class="auto-style17">
                            <asp:Button ID="btnHorario_Insertar" runat="server" OnClick="btnHorario_Insertar_Click" Text="Insertar" BackColor="#38A3A5" ForeColor="White" />
                        </td>
                        <td class="auto-style15">
                            <asp:Button ID="btnHorario_Modificar" runat="server" OnClick="btnHorario_Modificar_Click" Text="Modificar" BackColor="#38A3A5" ForeColor="White" />
                        </td>
                        <td>
                            <asp:Button ID="btnHorario_Eliminar" runat="server" OnClick="btnHorario_Eliminar_Click" Text="Eliminar" BackColor="#38A3A5" ForeColor="White" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style17">&nbsp;</td>
                        <td class="auto-style15">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:GridView ID="GridViewHorario" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Height="100px" HorizontalAlign="Center" Width="856px">
                                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                                <SortedDescendingHeaderStyle BackColor="#242121" />
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style17">&nbsp;</td>
                        <td class="auto-style15">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style17">
                            <asp:Button ID="Button1" runat="server" OnClick="Menu_Click" Text="Menu" BackColor="#38A3A5" ForeColor="White" Width="97px" />
                        </td>
                        <td class="auto-style15">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style17">&nbsp;</td>
                        <td class="auto-style15">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style18" colspan="3">
                            <asp:Panel ID="PanelAdmin" runat="server">
                                <asp:Label ID="Admin" runat="server" ForeColor="#80ED99" Text="Adminnistrador "></asp:Label>
                                <asp:GridView ID="GridViewAdmin" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Height="100px" HorizontalAlign="Center" Width="856px">
                                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                                    <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                                    <SortedDescendingHeaderStyle BackColor="#242121" />
                                </asp:GridView>
                                <asp:Button ID="btnAdminActivar" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnAdminActivar_Click" Text="Activar" />
                                <asp:Button ID="btnAdminEliminar" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnAdminEliminar_Click" Text="Eliminar" Width="83px" />
                                <asp:DropDownList ID="DropDownListadmin" runat="server">
                                </asp:DropDownList>
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style17">&nbsp;</td>
                        <td class="auto-style15">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
