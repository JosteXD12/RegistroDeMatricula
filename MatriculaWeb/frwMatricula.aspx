<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frwMatricula.aspx.cs" Inherits="MatriculaWeb.frwMatricula" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style11 {
            margin-left: 0px;
        }
        .auto-style12 {
            width: 242px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" BackColor="#22577A">
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style12">&nbsp;</td>
                        <td>
                            <asp:Label ID="Label6" runat="server" ForeColor="White" Text="Registro Matricula"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style12">
                            <asp:Label ID="Label1" runat="server" ForeColor="#80ED99" Text="Estudiante_ID:"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="DDL_EstudianteID" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style12">
                            <asp:Label ID="Label2" runat="server" ForeColor="#80ED99" Text="Grupo_ID:"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="DDL_GrupoID" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style12">
                            <asp:Label ID="Label3" runat="server" ForeColor="#80ED99" Text="Curso_ID:"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="DDL_CursoID" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="Label9" runat="server" ForeColor="#80ED99" Text="Filtro:"></asp:Label>
                            <asp:DropDownList ID="DDL_CargarDatos" runat="server">
                            </asp:DropDownList>
                            <asp:Button ID="btnMatricula_CargarDatos" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnMatricula_CargarDatos_Click" Text="Cargar Datos " />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style12">
                            <asp:Label ID="Label4" runat="server" ForeColor="#80ED99" Text="Profesor_ID:"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="DDL_ProfesorID" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style12">
                            <asp:Label ID="Label5" runat="server" ForeColor="#80ED99" Text="Horario_ID:"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="DDL_HorarioID" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style12">
                            <asp:Label ID="Label7" runat="server" ForeColor="#80ED99" Text="Aula_ID:"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="DDL_AulaID" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style12">
                            <asp:Label ID="Label8" runat="server" ForeColor="#80ED99" Text="Comprobante:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TBMatriucla_Comprobante" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style12">
                            <asp:Button ID="btnMatricula_Insertar" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnMatricula_Insertar_Click" Text="Insertar" />
                        </td>
                        <td>
                            <asp:Button ID="btnModificar" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnModificar_Click" Text="Modificar" />
                        </td>
                        <td>
                            <asp:Button ID="btnEliminar" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnEliminar_Click" Text="Eliminar" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:GridView ID="GVMatricula" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" HorizontalAlign="Center">
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
                        <td class="auto-style12">
                            <asp:Button ID="Menu_est" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="Menu_est_Click" Text="Menu " />
                        </td>
                        <td>&nbsp;</td>
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
                        <td class="auto-style12">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
