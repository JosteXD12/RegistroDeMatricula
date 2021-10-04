using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Resgistro_de_Matricula.CapaIntegracion;

namespace MatriculaWeb
{
    public partial class frmCurso : System.Web.UI.Page
    {
        DataSet dsCurso = new DataSet();
        DataTable dtCurso = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarComboCurso();
            CargarGridCurso();
        }

        protected void btnCurso_Insertar_Click(object sender, EventArgs e)
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                elCurso.InsertarCurso(TextBoxNombre.Text, TextBoxCcreditos.Text,
                    TextBoxCuposs.Text, "A");
            }
            CargarGridCurso();
            CargarComboCurso();
            Limpiar();
        }
        protected void CargarComboCurso()
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                if (!IsPostBack)
                {
                    DDListCurso.DataSource = elCurso.ListarCurso();
                    DDListCurso.DataValueField = "Curso_id";
                    DDListCurso.DataTextField = "Curso_nombre";
                    DDListCurso.DataBind();
                    DDListCurso.SelectedIndex = 0;
                }
            }
        }
        protected void CargarGridCurso()
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                GridViewCurso.DataSource = elCurso.ListarCurso();
                GridViewCurso.DataBind();
            }
        }

        protected void CargarDDatos_Click(object sender, EventArgs e)
        {
            int curso_id = int.Parse(DDListCurso.SelectedValue.ToString());
            using (GestorCurso elCurso = new GestorCurso())
            {
                this.dsCurso = elCurso.ConsultarCurso(curso_id);
                this.dtCurso = this.dsCurso.Tables[0];
            }
            CargarDatosCurso();
        }
        protected void CargarDatosCurso()
        {
            TextBoxNombre.Text = this.dtCurso.Rows[0]["Curso_nombre"].ToString();
            TextBoxCcreditos.Text = this.dtCurso.Rows[0]["Curso_creditos"].ToString();
            TextBoxCuposs.Text = this.dtCurso.Rows[0]["Curso_cupo"].ToString();
        }
       protected void Limpiar()
        {
            TextBoxNombre.Text = "";
            TextBoxCcreditos.Text = "";
            TextBoxCuposs.Text = "";
        }
    }
}