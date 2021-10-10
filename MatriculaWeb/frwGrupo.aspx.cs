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
    public partial class frmGrupo : System.Web.UI.Page
    {

        DataSet dsGrupo = new DataSet();
        DataTable dtGrupo = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarComboGrupo();
            CargarGridGrupo();
            CargarComboInactivosGrupo();
            CargarGridInactivosGrupo();
        }

        protected void btnGrupo_Insertar_Click(object sender, EventArgs e)
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                elGrupo.InsertarGrupo(TextBoxGrupo_Descripcion.Text, "A");
            }
            CargarGridGrupo();
            CargarComboGrupo();
            Limpiar();
        }
        protected void btnGrupo_Modificar_Click(object sender, EventArgs e)
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                elGrupo.ModificarGrupo(int.Parse(DDListGrupo.SelectedValue.ToString()), TextBoxGrupo_Descripcion.Text, "A");
            }
            CargarGridGrupo();
            CargarComboGrupo();
            Limpiar();
        }
        protected void btnGrupo_Eliminar_Click(object sender, EventArgs e)
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                elGrupo.inactivarGrupo(int.Parse(DDListGrupo.SelectedValue.ToString()));
            }
            CargarGridGrupo();
            CargarComboGrupo();
            CargarComboInactivosGrupo();
            CargarGridInactivosGrupo();
            Limpiar();
        }
        protected void Menu_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmInicio.aspx");
        }
        protected void btnAdminActivar_Click(object sender, EventArgs e)
        {
            int Grupo_id = int.Parse(DropDownListadmin.SelectedValue.ToString());
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                elGrupo.ActivarGrupo(Grupo_id);
            }

            CargarGridGrupo();
            CargarComboGrupo();
            CargarComboInactivosGrupo();
            CargarGridInactivosGrupo();

        }
        protected void btnAdminEliminar_Click(object sender, EventArgs e)
        {
           
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                elGrupo.eliminarGrupo(int.Parse(DropDownListadmin.SelectedValue.ToString()));//no sirve 
            }
            CargarComboInactivosGrupo();
            CargarGridInactivosGrupo();
        }

        protected void CargarComboGrupo()
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {

                DDListGrupo.DataSource = elGrupo.ListarGrupo();
                DDListGrupo.DataValueField = "Grupo_id";
                DDListGrupo.DataTextField = "Grupo_descripcion";
                DDListGrupo.DataBind();
               

            }
        }
        protected void CargarComboInactivosGrupo()
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {

                DropDownListadmin.DataSource = elGrupo.ListarInactivoGrupo();
                DropDownListadmin.DataValueField = "Grupo_id";
                DropDownListadmin.DataTextField = "Grupo_descripcion";
                DropDownListadmin.DataBind();
               

            }
        }
        protected void CargarGridGrupo()
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                GridViewGrupo.DataSource = elGrupo.ListarGrupo();
                GridViewGrupo.DataBind();
            }
        }
        protected void CargarGridInactivosGrupo()
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {

                GridViewAdmin.DataSource = elGrupo.ListarInactivoGrupo();
                GridViewAdmin.DataBind();
            }
        }

        protected void btnHorario_CargarDatos_Click(object sender, EventArgs e)
        {
            int Grupo_id = int.Parse(DDListGrupo.SelectedValue.ToString());
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                this.dsGrupo = elGrupo.ConsultarGrupo(Grupo_id);
                this.dtGrupo = this.dsGrupo.Tables[0];
            }
            CargarDatosGrupo();
        }
        protected void CargarDatosGrupo()
        {
            TextBoxGrupo_Descripcion.Text = this.dtGrupo.Rows[0]["Grupo_descripcion"].ToString();

        }
        protected void Limpiar()
        {
            TextBoxGrupo_Descripcion.Text = "";

        }
    }
}