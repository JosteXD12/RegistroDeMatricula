<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grupo.aspx.cs" Inherits="MatriculaWeb.Grupo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style6 {
            width: 329px;
        }
        .auto-style5 {
            height: 26px;
            width: 329px;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style7 {
            height: 243px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" BackColor="#22577A">
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style6">&nbsp;</td>
                        <td>
                            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="White" Text="Registro Grupo"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style6">
                            <asp:Label ID="Label1" runat="server" ForeColor="#80ED99" Text="Descripcion"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxGrupo_Descripcion" runat="server" Width="177px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="Label2" runat="server" ForeColor="#80ED99" Text="Filtro: "></asp:Label>
                            <asp:DropDownList ID="DDListGrupo" runat="server">
                            </asp:DropDownList>
                            <asp:Button ID="btnHorario_CargarDatos" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnHorario_CargarDatos_Click" style="height: 29px" Text="Cargar Datos" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">
                            <asp:Button ID="btnGrupo_Insertar" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnGrupo_Insertar_Click" Text="Insertar" />
                        </td>
                        <td>
                            <asp:Button ID="btnGrupo_Modificar" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnGrupo_Modificar_Click" Text="Modificar" />
                        </td>
                        <td>
                            <asp:Button ID="btnGrupo_Eliminar" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnGrupo_Eliminar_Click" Text="Eliminar " />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:GridView ID="GridViewGrupo" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Height="100px" HorizontalAlign="Center">
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
                        <td class="auto-style5">
                            <asp:Button ID="Button1" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="Menu_Click" Text="Menu" Width="97px" />
                        </td>
                        <td class="auto-style3"></td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style7" colspan="3">
                            <asp:Panel ID="PanelAdmin" runat="server">
                                <asp:Label ID="Admin" runat="server" ForeColor="#80ED99" Text="Adminnistrador "></asp:Label>
                                <asp:GridView ID="GridViewAdmin" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Height="50px" HorizontalAlign="Center" Width="299px">
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
                </table>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
