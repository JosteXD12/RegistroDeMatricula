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
    public partial class frmProfesor1 : System.Web.UI.Page
    {
        DataSet dsProfesor = new DataSet();
        DataTable dtProfesor = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarComboProfesor();
            CargarGridProfesor();
            CargarComboInactivosProfesor();
            CargarGridInactivosProfesor();
        }

        protected void btnProfesor_insertar_Click(object sender, EventArgs e)
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                elProfesor.InsertarProfesor(TextBoxProfesor_Cedula.Text, TextBoxProfesor_Nombre.Text, TextBoxProfesor_PrimerApellido.Text,
                    TextBoxProfesor_SegundoApellido.Text, TextBoxProfesor_Telefono.Text, TextBoxProfesor_Email.Text, TextBoxProfesor_Direccion.Text, "A");
            }
            CargarGridProfesor();
            CargarComboProfesor();
            Limpiar();
        }

        protected void btnProfesor_Modificar_Click(object sender, EventArgs e)
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                elProfesor.ModificarProfesor(int.Parse(DDListProfesores.SelectedValue.ToString()), TextBoxProfesor_Cedula.Text, TextBoxProfesor_Nombre.Text, TextBoxProfesor_PrimerApellido.Text,
                   TextBoxProfesor_SegundoApellido.Text, TextBoxProfesor_Telefono.Text, TextBoxProfesor_Email.Text, TextBoxProfesor_Direccion.Text, "A");
            }

            CargarGridProfesor();
            CargarComboProfesor();
            Limpiar();
        }

        protected void btnProfesor_Eliminar_Click(object sender, EventArgs e)
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                elProfesor.inactivarProfesor(int.Parse(DDListProfesores.SelectedValue.ToString()));
            }
            CargarGridProfesor();
            CargarComboProfesor();
            CargarComboInactivosProfesor();
            CargarGridInactivosProfesor();
            Limpiar();
        }

        protected void btnCargarDatoss_Click(object sender, EventArgs e)
        {
            int Profesor_id = int.Parse(DDListProfesores.SelectedValue.ToString());
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                this.dsProfesor = elProfesor.consultarProfesor(Profesor_id);
                this.dtProfesor = this.dsProfesor.Tables[0];
            }
            CargarDatosProfesor();
        }

        protected void btnMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmInicio.aspx");
        }

        protected void btnAdminActivar_Click(object sender, EventArgs e)
        {
            int Profesores_id = int.Parse(DropDownListadmin.SelectedValue.ToString());
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                elProfesor.ActivarProfesor(Profesores_id);
            }
            CargarComboProfesor();
            CargarComboInactivosProfesor();
            CargarGridProfesor();
            CargarGridInactivosProfesor();
        }

        protected void btnAdminEliminar_Click(object sender, EventArgs e)
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                elProfesor.eliminarProfesor(int.Parse(DropDownListadmin.SelectedValue.ToString()));
            }
            CargarComboInactivosProfesor();
            CargarGridInactivosProfesor();
        }
        protected void CargarComboProfesor()
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                DDListProfesores.DataSource = elProfesor.ListarProfesor();
                DDListProfesores.DataValueField = "Profesor_id";
                DDListProfesores.DataTextField = "Profesor_cedula";
                DDListProfesores.DataBind();
                // DDListProfesores.SelectedIndex = 0;
            }
        }

        protected void CargarComboInactivosProfesor()
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                DropDownListadmin.DataSource = elProfesor.ListarInactivoProfesor();
                DropDownListadmin.DataValueField = "Profesor_id";
                DropDownListadmin.DataTextField = "Profesor_cedula";
                DropDownListadmin.DataBind();
                // DropDownListadmin.SelectedIndex = 0;
            }
        }
        protected void CargarGridProfesor()
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {

                DGVProfesores.DataSource = elProfesor.ListarProfesor();
                DGVProfesores.DataBind();

            }
        }
        protected void CargarGridInactivosProfesor()
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {

                GridViewAdmin.DataSource = elProfesor.ListarInactivoProfesor();
                GridViewAdmin.DataBind();

            }
        }
        protected void CargarDatosProfesor()
        {

            TextBoxProfesor_Cedula.Text = this.dtProfesor.Rows[0]["Profesor_cedula"].ToString();
            TextBoxProfesor_Nombre.Text = this.dtProfesor.Rows[0]["Profesor_nombre"].ToString();
            TextBoxProfesor_PrimerApellido.Text = this.dtProfesor.Rows[0]["Profesor_primerApellido"].ToString();
            TextBoxProfesor_SegundoApellido.Text = this.dtProfesor.Rows[0]["Profesor_segundoApellido"].ToString();
            TextBoxProfesor_Telefono.Text = this.dtProfesor.Rows[0]["Profesor_Telefono"].ToString();
            TextBoxProfesor_Email.Text = this.dtProfesor.Rows[0]["Profesor_correoElectronico"].ToString();
            TextBoxProfesor_Direccion.Text = this.dtProfesor.Rows[0]["Profesor_direccion"].ToString();

        }
        protected void Limpiar()
        {
            TextBoxProfesor_Cedula.Text = "";
            TextBoxProfesor_Nombre.Text = "";
            TextBoxProfesor_PrimerApellido.Text = "";
            TextBoxProfesor_SegundoApellido.Text = "";
            TextBoxProfesor_Telefono.Text = "";
            TextBoxProfesor_Email.Text = "";
            TextBoxProfesor_Direccion.Text = "";
        }
    }
}