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
    public partial class frwAula : System.Web.UI.Page
    {
        DataSet dsAula = new DataSet();
        DataTable dtAula = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarComboAula();
            CargarComboInactivosAula();
            CargarGridAula();
            CargarGridInactivosAula();

        }

        protected void btnAula_insertar_Click(object sender, EventArgs e)
        {
            using (GestorAula elAula = new GestorAula())
            {
                elAula.InsertarAula(TBAula_Descripcion.Text, TBAula_Capacidad.Text,
                     "A");
            }
            CargarGridAula();
            CargarComboAula();
            Limpiar();
        }

        protected void btnAula_Modificar_Click(object sender, EventArgs e)
        {
            using (GestorAula elAula = new GestorAula())
            {
                elAula.ModificarAula(int.Parse(DDL_Aula.SelectedValue.ToString()),TBAula_Descripcion.Text, TBAula_Capacidad.Text,
                     "A");
            }
            CargarGridAula();
            CargarComboAula();
            Limpiar();
        }

        protected void btnAula_Eliminar_Click(object sender, EventArgs e)
        {
            using (GestorAula elAula = new GestorAula())
            {
                elAula.inactivarAula(int.Parse(DDL_Aula.SelectedValue.ToString()));
            }
            CargarGridAula();
            CargarComboAula();
            CargarComboInactivosAula();
            CargarGridInactivosAula();
            Limpiar();
        }

        protected void btnAula_CargarDatos_Click(object sender, EventArgs e)
        {
            using (GestorAula elAula = new GestorAula())
            {
                this.dsAula = elAula.consultarAula(int.Parse(DDL_Aula.SelectedValue.ToString()));
                this.dtAula = this.dsAula.Tables[0];
            }
            CargarDatosAula();
        }

        protected void Menu_est_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmInicio.aspx");
        }

        protected void btnAdminActivar_Click(object sender, EventArgs e)
        {
            using (GestorAula elAula = new GestorAula())
            {
                elAula.ActivarAula(int.Parse(DDL_Inactivo.SelectedValue.ToString()));
            }
            CargarGridAula();
            CargarComboAula();
            CargarComboInactivosAula();
            CargarGridInactivosAula();
        }

        protected void btnAdminEliminar_Click(object sender, EventArgs e)
        {
            using (GestorAula elAula = new GestorAula())
            {
                elAula.eliminarAula(int.Parse(DDL_Inactivo.SelectedValue.ToString()));
            }
            CargarComboInactivosAula();
            CargarGridInactivosAula();
        }
        protected void CargarComboAula()
        {
            using (GestorAula elAula = new GestorAula())
            {
                DDL_Aula.DataSource = elAula.ListarAula();
                DDL_Aula.DataValueField = "Aula_id";
                DDL_Aula.DataTextField = "Aula_capacidad";
                DDL_Aula.DataBind();

            }
        }
        protected void CargarComboInactivosAula()
        {
            using (GestorAula elAula = new GestorAula())
            {
                DDL_Inactivo.DataSource = elAula.ListarInactivoAula();
                DDL_Inactivo.DataValueField = "Aula_id";
                DDL_Inactivo.DataTextField = "Aula_capacidad";
                DDL_Inactivo.DataBind();

            }
        }
        protected void CargarGridAula()
        {
            using (GestorAula elAula = new GestorAula())
            {

                GVAula.DataSource = elAula.ListarAula();
                GVAula.DataBind();
            }
        }
        protected void CargarGridInactivosAula()
        {
            using (GestorAula elAula = new GestorAula())
            {

                GridViewAdmin.DataSource = elAula.ListarInactivoAula();
                GridViewAdmin.DataBind();
            }
        }
        private void CargarDatosAula()
        {
            TBAula_Descripcion.Text = this.dtAula.Rows[0]["Aula_descripcion"].ToString();
            TBAula_Capacidad.Text = this.dtAula.Rows[0]["Aula_capacidad"].ToString();
        }

        private void Limpiar()
        {
            TBAula_Descripcion.Text = "";
            TBAula_Capacidad.Text = "";

        }
    }
}