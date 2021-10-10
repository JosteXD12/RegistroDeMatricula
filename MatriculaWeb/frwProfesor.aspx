<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frwProfesor1.aspx.cs" Inherits="MatriculaWeb.frmProfesor1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 321px;
        }
        .auto-style2 {
            width: 497px;
        }
        .auto-style4 {
            height: 221px;
        }
        .auto-style7 {
            width: 328px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" BackColor="#22577A">
                <table style="width: 100%;">
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td class="auto-style2">
                            <asp:Label ID="Label9" runat="server" Font-Bold="True" ForeColor="White" Text="Registro Profesor "></asp:Label>
                        </td>
                        <td class="auto-style7">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:Label ID="Label1" runat="server" ForeColor="#80ED99" Text="Cédula:"></asp:Label>
                        </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBoxProfesor_Cedula" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style7">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:Label ID="Label2" runat="server" ForeColor="#80ED99" Text="Nombre:"></asp:Label>
                        </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBoxProfesor_Nombre" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style7">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:Label ID="Label3" runat="server" ForeColor="#80ED99" Text="PrimerApellido:"></asp:Label>
                        </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBoxProfesor_PrimerApellido" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style7">
                            <asp:Label ID="Label8" runat="server" ForeColor="#80ED99" Text="Filtro:"></asp:Label>
                            <asp:DropDownList ID="DDListProfesores" runat="server">
                            </asp:DropDownList>
                            <asp:Button ID="btnCargarDatoss" runat="server" OnClick="btnCargarDatoss_Click" Text="Cargar Datos " />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:Label ID="Label4" runat="server" ForeColor="#80ED99" Text="SegundoApellido "></asp:Label>
                        </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBoxProfesor_SegundoApellido" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style7">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:Label ID="Label5" runat="server" ForeColor="#80ED99" Text="Telefono:"></asp:Label>
                        </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBoxProfesor_Telefono" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style7">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:Label ID="Label7" runat="server" ForeColor="#80ED99" Text="Dirreccion:"></asp:Label>
                        </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBoxProfesor_Email" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style7">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:Label ID="Label6" runat="server" ForeColor="#80ED99" Text="Email:"></asp:Label>
                        </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBoxProfesor_Direccion" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style7">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:Button ID="btnProfesor_insertar" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnProfesor_insertar_Click" Text="Insertar" />
                        </td>
                        <td class="auto-style2">
                            <asp:Button ID="btnProfesor_Modificar" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnProfesor_Modificar_Click" Text="Modificar" />
                        </td>
                        <td class="auto-style7">
                            <asp:Button ID="btnProfesor_Eliminar" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnProfesor_Eliminar_Click" Text="Eliminar" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td class="auto-style7">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4" colspan="3">
                            <asp:GridView ID="DGVProfesores" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Height="100px" HorizontalAlign="Center" Width="250px">
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
                        <td colspan="3">
                            <asp:Button ID="btnMenu" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnMenu_Click" Text="Menu" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:Panel ID="PanelAdmin" runat="server">
                                <table style="width: 100%;">
                                    <tr>
                                        <td>
                                            <asp:Label ID="Admin" runat="server" ForeColor="#80ED99" Text="Adminnistrador "></asp:Label>
                                            <asp:GridView ID="GridViewAdmin" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" HorizontalAlign="Center" Width="856px">
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
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                </table>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
