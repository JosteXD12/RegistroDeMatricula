using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MatriculaWeb
{
    public partial class prueba : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEstudiante_Click(object sender, EventArgs e)
        {
            Response.Redirect("frwEstudiante.aspx");
        }

        protected void btnProfesor_Click(object sender, EventArgs e)
        {
            Response.Redirect("frwProfesor.aspx");
        }

        protected void btnCurso_Click(object sender, EventArgs e)
        {
            Response.Redirect("frwCurso.aspx");
        }

        protected void btnGrupo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Grupo.aspx");
        }

        protected void btnAula_Click(object sender, EventArgs e)
        {
            Response.Redirect("frwAula.aspx");
        }

        protected void btnHorario_Click(object sender, EventArgs e)
        {
            Response.Redirect("frwHorario.aspx");
        }

        protected void btnMatricula_Click(object sender, EventArgs e)
        {
            Response.Redirect("frwMatricula.aspx");
        }
    }
}