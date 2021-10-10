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
    public partial class frmEstudiante : System.Web.UI.Page
    {

        DataSet dsEstudiante = new DataSet();
        DataTable dtEstudiante = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarComboEstudiante();
            CargarGridEstudiante();
            CargarComboGrupo();
            CargarComboInactivosEstudiante();
            CargarGridInactivosEstudiante();
            //prueba//veriicar();

        }

        protected void btnestudiante_Insertar_Click(object sender, EventArgs e)
        {
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                elEstudiante.InsertarEstudiante(int.Parse(DDListGrupo_ID.SelectedValue.ToString()), TBEstudiante_Cedula.Text,
                    TBEstudiante_nombre.Text, TBEstudiante_PrimerApellido.Text, TBEstudiante_SegundoApellido.Text,
                   TBEstudiante_Telefono.Text, TBEstudiante_Email.Text, TBEstudiante_Direccion.Text, "A");
            }
            CargarGridEstudiante();
            CargarComboEstudiante();
            Limpiar();
        }
        protected void btnEstudiante_Mdificar_Click(object sender, EventArgs e)
        {
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                elEstudiante.ModificarEstudiante(int.Parse(DDListEstudiante.SelectedValue.ToString()), int.Parse(DDListGrupo_ID.SelectedValue.ToString()), TBEstudiante_Cedula.Text,
                    TBEstudiante_nombre.Text, TBEstudiante_PrimerApellido.Text, TBEstudiante_SegundoApellido.Text,
                   TBEstudiante_Telefono.Text, TBEstudiante_Email.Text, TBEstudiante_Direccion.Text, "A");
            }
            CargarGridEstudiante();
            CargarComboEstudiante();
            Limpiar();
        }

        protected void btnEstudiante_eliminar_Click(object sender, EventArgs e)
        {
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                elEstudiante.inactivarEstudiantes(int.Parse(DDListEstudiante.SelectedValue.ToString()));
            }
            CargarGridEstudiante();
            CargarComboEstudiante();
            CargarComboInactivosEstudiante();
            CargarGridInactivosEstudiante();
            Limpiar();
        }

        protected void btnCargaDatos_Click(object sender, EventArgs e)
        {
            int Estudiante_id = int.Parse(DDListEstudiante.SelectedValue.ToString());
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                this.dsEstudiante = elEstudiante.ConsultarEstudiante(Estudiante_id);
                this.dtEstudiante = this.dsEstudiante.Tables[0];
            }
            CargarDatosEstudiante();
        }

        protected void btnAdminActivar_Click(object sender, EventArgs e)
        {
            int Estudiante_id = int.Parse(DDList_Inactivo.SelectedValue.ToString());
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                elEstudiante.ActivarEstudiante(Estudiante_id);
            }
            CargarComboEstudiante();
            CargarComboInactivosEstudiante();
            CargarGridEstudiante();
            CargarGridInactivosEstudiante();
        }

        protected void btnAdminEliminar_Click(object sender, EventArgs e)
        {
            int Estudiante_id = int.Parse(DDList_Inactivo.SelectedValue.ToString());
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                elEstudiante.eliminarEstudiante(Estudiante_id);
            }
            CargarGridInactivosEstudiante();
        }
        protected void CargarComboEstudiante()
        {
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                DDListEstudiante.DataSource = elEstudiante.ListarEstudiante();
                DDListEstudiante.DataValueField = "Estudiante_id";
                DDListEstudiante.DataTextField = "Estudiante_cedula";
                DDListEstudiante.DataBind();
            }
        }
        protected void CargarComboGrupo()
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                DDListGrupo_ID.DataSource = elGrupo.ListarGrupo();
                DDListGrupo_ID.DataValueField = "Grupo_id";
                DDListGrupo_ID.DataTextField = "Grupo_descripcion";
                DDListGrupo_ID.DataBind();
            }
        }
        protected void CargarComboInactivosEstudiante()
        {
            using (GestorEstudiante elEstudiante = new GestorEstudiante())

            {
                DDList_Inactivo.DataSource = elEstudiante.ListarInactivoEstudiantes();
                DDList_Inactivo.DataValueField = "Estudiante_id";
                DDList_Inactivo.DataTextField = "Estudiante_id";
                DDList_Inactivo.DataBind();

            }
        }
        protected void CargarGridEstudiante()
        {
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                GridViewEstudiante.DataSource = elEstudiante.ListarEstudiante();
                GridViewEstudiante.DataBind();
            }

        }
        protected void CargarGridInactivosEstudiante()
        {
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                GridViewAdmin.DataSource = elEstudiante.ListarInactivoEstudiantes();
                GridViewAdmin.DataBind();
            }

        }
        protected void CargarDatosEstudiante()
        {
            TBEstudiante_Cedula.Text = this.dtEstudiante.Rows[0]["Estudiante_cedula"].ToString();
            TBEstudiante_nombre.Text = this.dtEstudiante.Rows[0]["Estudiante_nombre"].ToString();
            TBEstudiante_PrimerApellido.Text = this.dtEstudiante.Rows[0]["Estudiante_primerApellido"].ToString();
            TBEstudiante_SegundoApellido.Text = this.dtEstudiante.Rows[0]["Estudiante_segundoApellido"].ToString();
            TBEstudiante_Telefono.Text = this.dtEstudiante.Rows[0]["Estudiante_Telefono"].ToString();
            TBEstudiante_Email.Text = this.dtEstudiante.Rows[0]["Estudiante_correoElectronico"].ToString();
            TBEstudiante_Direccion.Text = this.dtEstudiante.Rows[0]["Estudiante_direccion"].ToString();

        }
        protected void Limpiar()
        {
            TBEstudiante_Cedula.Text = "";
            TBEstudiante_nombre.Text = "";
            TBEstudiante_PrimerApellido.Text = "";
            TBEstudiante_SegundoApellido.Text = "";
            TBEstudiante_Telefono.Text = "";
            TBEstudiante_Email.Text = "";
            TBEstudiante_Direccion.Text = "";
        }

        protected void Menu_est_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmInicio.aspx");
        }
        protected void veriicar()
        {
            panelAdmin.Visible = false;
        }

    }
}
