using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaIntegracion;
using Resgistro_de_Matricula.CapaIntegracion;

namespace MatriculaWeb
{
    public partial class frwInicioSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void access()
        {
            using (GestorUsuario elUsuario = new GestorUsuario())
            {
                DataSet laData = elUsuario.Login(user.Text, password.Text);
                DataTable datatable = laData.Tables[0];
                if (datatable.Rows.Count > 0)
                {
                    Response.Redirect("frmInicio.aspx");

                }
                else
                {
                    Response.Write("<script>alert('Has introducido la contraseña o el usuario mal vuelve a intentarlo')</script>");
                }
            }
        }

        protected void inicioSesion_Click(object sender, EventArgs e)
        {
            access();
        }
    }
}