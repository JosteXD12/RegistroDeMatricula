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
        protected void CargarComboGrupo()
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                if (!IsPostBack)
                {
                    DDListGrupo.DataSource = elGrupo.ListarGrupo();
                    DDListGrupo.DataValueField = "Grupo_id";
                    DDListGrupo.DataTextField = "Grupo_descripcion";
                    DDListGrupo.DataBind();
                    DDListGrupo.SelectedIndex = 0;
                }
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