<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frwCurso.aspx.cs" Inherits="MatriculaWeb.frmCurso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 523px;
        }
        .auto-style3 {
            width: 332px;
        }
        .auto-style11 {
            margin-left: 0px;
        }
        .auto-style12 {
            width: 332px;
            height: 33px;
        }
        .auto-style13 {
            width: 523px;
            height: 33px;
        }
        .auto-style14 {
            height: 33px;
        }
        .auto-style15 {
            width: 332px;
            height: 38px;
        }
        .auto-style16 {
            width: 523px;
            height: 38px;
        }
        .auto-style17 {
            height: 38px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" BackColor="#22577A">
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style2">
                            <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="White" Text="Registro Curso "></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label3" runat="server" ForeColor="#80ED99" Text="Nombre:"></asp:Label>
                        </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TBCurso_Nombre" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style15">
                            <asp:Label ID="Label2" runat="server" ForeColor="#80ED99" Text="Creditos:"></asp:Label>
                        </td>
                        <td class="auto-style16">
                            <asp:TextBox ID="TBCurso_Credito" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style17">
                            <asp:Label ID="Label5" runat="server" ForeColor="#80ED99" Text="Filtro:"></asp:Label>
                            <asp:DropDownList ID="DDLCurso" runat="server">
                            </asp:DropDownList>
                            <asp:Button ID="btnCurso_CargarDatos" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnCurso_CargarDatos_Click" Text="Cargar Datos" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label4" runat="server" ForeColor="#80ED99" Text="Cupo:"></asp:Label>
                        </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TBCurso_Cupo" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style12">
                            <asp:Button ID="btnCurso_insertar" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnCurso_insertar_Click" Text="Insertar " />
                        </td>
                        <td class="auto-style13">
                            <asp:Button ID="btnCurso_Modificar" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnCurso_Modificar_Click" Text="Modificar " />
                        </td>
                        <td class="auto-style14">
                            <asp:Button ID="btnCurso_Elimianar" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnCurso_Elimianar_Click" Text="Eliminar " />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:GridView ID="GridViewCurso" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" HorizontalAlign="Center">
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
                        <td class="auto-style3">
                            <asp:Button ID="Menu_est" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="Menu_est_Click" Text="Menu " />
                        </td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:Panel ID="panelAdmin" runat="server" CssClass="auto-style11" Direction="LeftToRight" Width="1193px">
                                <asp:Label ID="Admin" runat="server" ForeColor="#80ED99" Text="Adminnistrador "></asp:Label>
                                <asp:GridView ID="GridViewAdmin" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" HorizontalAlign="Center" Width="558px">
                                    <Columns>
                                        <asp:BoundField>
                                        <ControlStyle Width="50px" />
                                        </asp:BoundField>
                                    </Columns>
                                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                                    <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                                    <SortedDescendingHeaderStyle BackColor="#242121" />
                                </asp:GridView>
                                <asp:DropDownList ID="DDL_Inactivo" runat="server">
                                </asp:DropDownList>
                                <br />
                                <asp:Button ID="btnAdminActivar" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnAdminActivar_Click" Text="Activar" />
                                <asp:Button ID="btnAdminEliminar" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnAdminEliminar_Click" Text="Eliminar" Width="83px" />
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
