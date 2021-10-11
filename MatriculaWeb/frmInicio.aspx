<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmInicio.aspx.cs" Inherits="MatriculaWeb.prueba" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 270px;
        }
        .auto-style3 {
            height: 32px;
        }
        .auto-style4 {
            width: 270px;
            height: 32px;
        }
        .auto-style5 {
            height: 26px;
        }
        .auto-style6 {
            width: 270px;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server">
                <table style="width:100%;">
                    <tr>
                        <td>
                            <asp:Panel ID="Panel4" runat="server">
                                <asp:Panel ID="Panel5" runat="server" BackColor="#22577A">
                                    <table style="width:100%;">
                                        <tr>
                                            <td class="auto-style5"></td>
                                            <td class="auto-style6"></td>
                                            <td class="auto-style5"></td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style5"></td>
                                            <td class="auto-style6"></td>
                                            <td class="auto-style5"></td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style2">
                                                <asp:Label ID="Label1" runat="server" Font-Size="16pt" ForeColor="White" Text="Resgistro Matricula "></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style2">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style5"></td>
                                            <td class="auto-style6">&nbsp;</td>
                                            <td class="auto-style5"></td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style3">&nbsp;</td>
                                            <td class="auto-style4">
                                                <asp:Button ID="btnEstudiante" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnEstudiante_Click" Text="Resgistro Estudiante " Width="250px" />
                                            </td>
                                            <td class="auto-style3"></td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style2">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style2">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style2">
                                                <asp:Button ID="btnProfesor" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnProfesor_Click" Text="Resgistro Profesor " Width="250px" />
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style2">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style2">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style2">
                                                <asp:Button ID="btnCurso" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnCurso_Click" Text="Registro  Curso" Width="250px" />
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style2">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style2">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style2">
                                                <asp:Button ID="btnGrupo" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnGrupo_Click" Text="Registro Grupo " Width="250px" />
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style2">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style2">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style2">
                                                <asp:Button ID="btnAula" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnAula_Click" Text="Resgistro Aula" Width="250px" />
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style2">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style2">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style2">
                                                <asp:Button ID="btnHorario" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnHorario_Click" Text="Resgistro Horario" Width="250px" />
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style2">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style2">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style2">
                                                <asp:Button ID="btnMatricula" runat="server" BackColor="#38A3A5" ForeColor="White" OnClick="btnMatricula_Click" Text="Registro Matricula " Width="250px" />
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style2">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style2">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style2">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style2">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style2">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </asp:Panel>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
