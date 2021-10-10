<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frwEstudiante.aspx.cs" Inherits="MatriculaWeb.frmEstudiante" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style5 {
            height: 265px;
            }
        .auto-style6 {
            width: 515px;
        }
        .auto-style7 {
            width: 515px;
            height: 29px;
        }
        .auto-style8 {
            width: 372px;
            height: 29px;
        }
        .auto-style9 {
            height: 29px;
            width: 539px;
        }
        .auto-style10 {
            width: 372px;
        }
        .auto-style11 {
            margin-left: 0px;
        }
        .auto-style12 {
            height: 35px;
        }
        .auto-style13 {
            height: 33px;
        }
        .auto-style14 {
            width: 539px;
        }
        .auto-style15 {
            width: 515px;
            height: 28px;
        }
        .auto-style16 {
            width: 372px;
            height: 28px;
        }
        .auto-style17 {
            height: 28px;
            width: 539px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" BackColor="#22577A">
                <table style="width:100%;">
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:Label ID="Label10" runat="server" CssClass="auto-style11" EnableTheming="True" Font-Bold="True" Font-Size="Medium" ForeColor="White" Text="Registro Estudiante " Width="264px"></asp:Label>
                        </td>
                        <td class="auto-style14">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            <asp:Label runat="server" ForeColor="#80ED99" Text="Grupo_id: "></asp:Label>
                        </td>
                        <td class="auto-style8">
                            <asp:DropDownList ID="DDListGrupo_ID" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style9"></td>
                    </tr>
                    <tr>
                        <td class="auto-style6">
                            <asp:Label ID="Label2" runat="server" ForeColor="#80ED99" Text="Cédula: "></asp:Label>
                        </td>
                        <td class="auto-style10">
                            <asp:TextBox ID="TBEstudiante_Cedula" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style14">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style6">
                            <asp:Label ID="Label3" runat="server" ForeColor="#80ED99" Text="Nombre: "></asp:Label>
                        </td>
                        <td class="auto-style10">
                            <asp:TextBox ID="TBEstudiante_nombre" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style14">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style6">
                            <asp:Label ID="Label4" runat="server" ForeColor="#80ED99" Text="PrimerApellido:"></asp:Label>
                        </td>
                        <td class="auto-style10">
                            <asp:TextBox ID="TBEstudiante_PrimerApellido" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style14">
                            <asp:Label ID="Label9" runat="server" ForeColor="#80ED99" Text="Filtro: "></asp:Label>
                            <asp:DropDownList ID="DDListEstudiante" runat="server">
                            </asp:DropDownList>
                            <asp:Button ID="btnCargaDatos" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnCargaDatos_Click" Text="Cargar datos" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style15">
                            <asp:Label ID="Label5" runat="server" ForeColor="#80ED99" Text="SegundoApellido:"></asp:Label>
                        </td>
                        <td class="auto-style16">
                            <asp:TextBox ID="TBEstudiante_SegundoApellido" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style17"></td>
                    </tr>
                    <tr>
                        <td class="auto-style6">
                            <asp:Label ID="Label6" runat="server" ForeColor="#80ED99" Text="Telefono: "></asp:Label>
                        </td>
                        <td class="auto-style10">
                            <asp:TextBox ID="TBEstudiante_Telefono" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style14">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style6">
                            <asp:Label ID="Label7" runat="server" ForeColor="#80ED99" Text="Email: "></asp:Label>
                        </td>
                        <td class="auto-style10">
                            <asp:TextBox ID="TBEstudiante_Email" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style14">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style6">
                            <asp:Label ID="Label8" runat="server" ForeColor="#80ED99" Text="Dirreccion: "></asp:Label>
                        </td>
                        <td class="auto-style10">
                            <asp:TextBox ID="TBEstudiante_Direccion" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style14">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style6">
                            <asp:Button ID="btnestudiante_Insertar" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnestudiante_Insertar_Click" Text="Insertar" />
                        </td>
                        <td class="auto-style10">
                            <asp:Button ID="btnEstudiante_Mdificar" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnEstudiante_Mdificar_Click" Text="Modificar" />
                        </td>
                        <td class="auto-style14">
                            <asp:Button ID="btnEstudiante_eliminar" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnEstudiante_eliminar_Click" Text="Eliminar" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">&nbsp;</td>
                        <td class="auto-style10">&nbsp;</td>
                        <td class="auto-style14">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:GridView ID="GridViewEstudiante" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Height="100px" HorizontalAlign="Center" Width="600px">
                                <Columns>
                                    <asp:BoundField>
                                    <ControlStyle Width="50px" />
                                    </asp:BoundField>
                                </Columns>
                                <EditRowStyle Font-Size="10pt" />
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
                        <td colspan="3" class="auto-style13">
                            <asp:Button ID="Menu_est" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="Menu_est_Click" Text="Menu " />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                </table>
            </asp:Panel>
        </div>
        <asp:Panel ID="Panel2" runat="server" BackColor="#22577A">
            <table style="width:100%;">
                <tr>
                    <td class="auto-style5">
                        <asp:Panel ID="panelAdmin" runat="server" CssClass="auto-style11" Direction="LeftToRight" Width="1198px">
                            <asp:Label ID="Admin" runat="server" ForeColor="#80ED99" Text="Adminnistrador "></asp:Label>
                            <asp:GridView ID="GridViewAdmin" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" HorizontalAlign="Center" Width="600px">
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
                            <asp:DropDownList ID="DDList_Inactivo" runat="server">
                            </asp:DropDownList>
                            <br />
                            <asp:Button ID="btnAdminActivar" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnAdminActivar_Click" Text="Activar" />
                            <asp:Button ID="btnAdminEliminar" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnAdminEliminar_Click" Text="Eliminar" Width="83px" />
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12"></td>
                </tr>
            </table>
        </asp:Panel>
    </form>
</body>
</html>
