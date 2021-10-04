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
    public partial class frmHorario : System.Web.UI.Page
    {
        DataSet dsHorario = new DataSet();
        DataTable dtHorario = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarComboHorario();
            CargarGridHorario();
        }

        protected void btnHorario_Insertar_Click(object sender, EventArgs e)
        {
            using (GestorHorario elHorario = new GestorHorario())
            {
                elHorario.InsertarHorario(TextBoxHorario_Descripcion.Text, TextBoxHorario_Dia.Text,
                    TextBoxHorario_Inicio.Text, TextBoxHorario_Fin.Text, "A");
            }
            CargarGridHorario();
            CargarComboHorario();
            Limpiar();
        }
        protected void CargarComboHorario()
        {
            using (GestorHorario elHorario = new GestorHorario())
            {
                if (!IsPostBack)
                {
                    DDListHorario.DataSource = elHorario.ListarHorario();
                    DDListHorario.DataValueField = "Horario_id";
                    DDListHorario.DataTextField = "Horario_dia";
                    DDListHorario.DataBind();
                    DDListHorario.SelectedIndex = 0;
                }
            }
        }

        protected void CargarGridHorario()
        {
            using (GestorHorario elHorario = new GestorHorario())
            {



                GridViewHorario.DataSource = elHorario.ListarHorario();
                GridViewHorario.DataBind();


            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int Horario_id = int.Parse(DDListHorario.SelectedValue.ToString());
            using (GestorHorario elHorario = new GestorHorario())
            {
                this.dsHorario = elHorario.ConsultarHorario(Horario_id);
                this.dtHorario = this.dsHorario.Tables[0];
            }
            CargarDatosHorario();
        }
        protected void CargarDatosHorario()
        {
            TextBoxHorario_Descripcion.Text = this.dtHorario.Rows[0]["Horario_descripcion"].ToString();
            TextBoxHorario_Dia.Text = this.dtHorario.Rows[0]["Horario_dia"].ToString();
            TextBoxHorario_Inicio.Text = this.dtHorario.Rows[0]["Horario_horaInicio"].ToString();
            TextBoxHorario_Fin.Text = this.dtHorario.Rows[0]["Horario_horaFin"].ToString();
        }
        protected void Limpiar()
        {
            TextBoxHorario_Descripcion.Text = "";
            TextBoxHorario_Dia.Text = "";
            TextBoxHorario_Inicio.Text = "";
            TextBoxHorario_Fin.Text = "";
        }
    }
}