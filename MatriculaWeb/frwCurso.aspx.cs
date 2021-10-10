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
            CargarGridCurso();
            CargarComboCurso();
            CargarComboInactivosCurso();
            CargarGridInactivosCurso();
        }

        protected void btnCurso_insertar_Click(object sender, EventArgs e)
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                elCurso.InsertarCurso(TBCurso_Nombre.Text, TBCurso_Credito.Text,
                    TBCurso_Cupo.Text, "A");
            }
            CargarGridCurso();
            CargarComboCurso();
            Limpiar();
        }

        protected void btnCurso_Modificar_Click(object sender, EventArgs e)
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                elCurso.ModificarCurso(int.Parse(DDLCurso.SelectedValue.ToString()),TBCurso_Nombre.Text, TBCurso_Credito.Text,
                    TBCurso_Cupo.Text, "A");
            }
            CargarGridCurso();
            CargarComboCurso();
            Limpiar();
        }

        protected void btnCurso_Elimianar_Click(object sender, EventArgs e)
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                elCurso.inactivarCurso(int.Parse(DDLCurso.SelectedValue.ToString()));
            }
            CargarGridCurso();
            CargarComboCurso();
            CargarComboInactivosCurso();
            CargarGridInactivosCurso();
        }

        protected void btnCurso_CargarDatos_Click(object sender, EventArgs e)
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                this.dsCurso = elCurso.ConsultarCurso(int.Parse(DDLCurso.SelectedValue.ToString()));
                this.dtCurso = this.dsCurso.Tables[0];
            }
            CargarDatosCurso();
        }

        protected void Menu_est_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmInicio.aspx");
        }

        protected void btnAdminActivar_Click(object sender, EventArgs e)
        {
           int Curso_id = int.Parse(DDL_Inactivo.SelectedValue.ToString());
            using (GestorCurso elCurso = new GestorCurso())
            {
                elCurso.ActivarCurso(Curso_id);
            }
            CargarGridCurso();
            CargarComboCurso();
            CargarComboInactivosCurso();
            CargarGridInactivosCurso();
        }

        protected void btnAdminEliminar_Click(object sender, EventArgs e)
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                elCurso.eliminarCurso(int.Parse(DDL_Inactivo.SelectedValue.ToString()));
            }
            CargarComboInactivosCurso();
            CargarGridInactivosCurso();
        }
        protected void CargarComboCurso()
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                DDLCurso.DataSource = elCurso.ListarCurso();
                DDLCurso.DataValueField = "Curso_id";
                DDLCurso.DataTextField = "Curso_nombre";
                DDLCurso.DataBind();

            }
        }
        protected void CargarComboInactivosCurso()
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                DDL_Inactivo.DataSource = elCurso.ListarInactivoCurso();
                DDL_Inactivo.DataValueField = "Curso_id";
                DDL_Inactivo.DataTextField = "Curso_nombre";
                DDL_Inactivo.DataBind();

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
        protected void CargarGridInactivosCurso()
        {
            using (GestorCurso elCurso = new GestorCurso())
            {

                GridViewAdmin.DataSource = elCurso.ListarInactivoCurso();
                GridViewAdmin.DataBind();
            }
        }
        private void CargarDatosCurso()
        {
            TBCurso_Nombre.Text = this.dtCurso.Rows[0]["Curso_nombre"].ToString();
            TBCurso_Credito.Text = this.dtCurso.Rows[0]["Curso_creditos"].ToString();
            TBCurso_Cupo.Text = this.dtCurso.Rows[0]["Curso_cupo"].ToString();
        }
        private void Limpiar()
        {
            TBCurso_Nombre.Text = "";
            TBCurso_Credito.Text = "";
            TBCurso_Cupo.Text = "";
        }
    }
    
}