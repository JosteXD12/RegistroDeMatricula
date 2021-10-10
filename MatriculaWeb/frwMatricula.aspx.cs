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
    public partial class frwMatricula : System.Web.UI.Page
    {
        DataSet dsMatricula = new DataSet();
        DataTable dtMatricula = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarGridMatricula();
            CargarComboMatricula();
            CargarDatosMatricula();
            CargarGridInactivosMatricula();
        }

        protected void btnMatricula_Insertar_Click(object sender, EventArgs e)
        {
            int Estudiante_ID = int.Parse(DDL_EstudianteID.SelectedValue.ToString());
            int Grupo_ID = int.Parse(DDL_GrupoID.SelectedValue.ToString());
            int Curso_ID = int.Parse(DDL_CursoID.SelectedValue.ToString());
            int Profesor_ID = int.Parse(DDL_ProfesorID.SelectedValue.ToString());
            int Horario_ID = int.Parse(DDL_HorarioID.SelectedValue.ToString());
            int Aula_ID = int.Parse(DDL_AulaID.SelectedValue.ToString());

            using (GestorMatricula laMatricula = new GestorMatricula())
            {
                laMatricula.InsertarMatricula(Estudiante_ID, Grupo_ID, Curso_ID, Profesor_ID, Horario_ID,
                    Aula_ID, TBMatriucla_Comprobante.Text, "A");
            }
            CargarGridMatricula();
            CargarComboMatricula();
            Limpiar();


        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            int Estudiante_ID = int.Parse(DDL_EstudianteID.SelectedValue.ToString());
            int Grupo_ID = int.Parse(DDL_GrupoID.SelectedValue.ToString());
            int Curso_ID = int.Parse(DDL_CursoID.SelectedValue.ToString());
            int Profesor_ID = int.Parse(DDL_ProfesorID.SelectedValue.ToString());
            int Horario_ID = int.Parse(DDL_HorarioID.SelectedValue.ToString());
            int Aula_ID = int.Parse(DDL_AulaID.SelectedValue.ToString());
            using (GestorMatricula laMatricula = new GestorMatricula())
            {
                laMatricula.ModificarMatricula(int.Parse(DDL_CargarDatos.SelectedValue.ToString()), Estudiante_ID, Grupo_ID, Curso_ID, Profesor_ID, Horario_ID,
                    Aula_ID, TBMatriucla_Comprobante.Text, "A");
            }
            CargarGridMatricula();
            CargarComboMatricula();
            Limpiar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            using (GestorMatricula laMatricula = new GestorMatricula())
            {
                laMatricula.inactivarMatricula(int.Parse(DDL_CargarDatos.SelectedValue.ToString()));
            }
            CargarGridMatricula();
            CargarComboMatricula();
            CargarComboInactivosMatricula();
            CargarGridInactivosMatricula();
            Limpiar();
        }

        protected void Menu_est_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmInicio.aspx");
        }

        protected void btnAdminActivar_Click(object sender, EventArgs e)
        {
            using (GestorMatricula laMatricula = new GestorMatricula())
            {
                laMatricula.ActivarMatricula(int.Parse(DDL_Inactivo.SelectedValue.ToString()));
            }
            CargarGridMatricula();
            CargarComboMatricula();
            CargarComboInactivosMatricula();
            CargarGridInactivosMatricula();
        }

        protected void btnAdminEliminar_Click(object sender, EventArgs e)
        {
            using (GestorMatricula laMatricula = new GestorMatricula())
            {
                laMatricula.eliminarMatricula(int.Parse(DDL_Inactivo.SelectedValue.ToString()));
            }
            CargarComboInactivosMatricula();
            CargarGridInactivosMatricula();
            Limpiar();
        }

        protected void CargarComboMatricula()
        {
            using (GestorMatricula laMatricula = new GestorMatricula())
            {
                DDL_CargarDatos.DataSource = laMatricula.ListarMatricula();
                DDL_CargarDatos.DataValueField = "Matricula_id";
                DDL_CargarDatos.DataTextField = "Matricula_comprobante";
                DDL_CargarDatos.DataBind();

            }
        }
        protected void CargarComboEstudiante()
        {
            using (GestorEstudiante laEstudiante = new GestorEstudiante())
            {
                DDL_EstudianteID.DataSource = laEstudiante.ListarEstudiante();
                DDL_EstudianteID.DataValueField = "Estudiante_id";
                DDL_EstudianteID.DataTextField = "Estudiante_cedula";
                DDL_EstudianteID.DataBind();

            }
        }
        protected void CargarComboGrupo()
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                DDL_GrupoID.DataSource = elGrupo.ListarGrupo();
                DDL_GrupoID.DataValueField = "Grupo_id";
                DDL_GrupoID.DataTextField = "Grupo_descripcion";
                DDL_GrupoID.DataBind();

            }
        }
        protected void CargarComboCurso()
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                DDL_CursoID.DataSource = elCurso.ListarCurso();
                DDL_CursoID.DataValueField = "Curso_id";
                DDL_CursoID.DataTextField = "Curso_nombre";
                DDL_CursoID.DataBind();

            }
        }

        protected void CargarComboProfesor()
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                DDL_ProfesorID.DataSource = elProfesor.ListarProfesor();
                DDL_ProfesorID.DataValueField = "Profesor_id";
                DDL_ProfesorID.DataTextField = "Profesor_cedula";
                DDL_ProfesorID.DataBind();

            }
        }
        protected void CargarComboHorario()
        {
            using (GestorHorario elHorario = new GestorHorario())
            {
                DDL_HorarioID.DataSource = elHorario.ListarHorario();
                DDL_HorarioID.DataValueField = "Horario_id";
                DDL_HorarioID.DataTextField = "Horario_dia";
                DDL_HorarioID.DataBind();

            }
        }
        protected void CargarComboAula()
        {
            using (GestorAula elAula = new GestorAula())
            {
                DDL_AulaID.DataSource = elAula.ListarAula();
                DDL_AulaID.DataValueField = "Aula_id";
                DDL_AulaID.DataTextField = "Aula_capacidad";
                DDL_AulaID.DataBind();

            }
        }

        protected void CargarComboInactivosMatricula()
        {
            using (GestorMatricula laMatricula = new GestorMatricula())
            {
                DDL_Inactivo.DataSource = laMatricula.ListarInactivoMatricula();
                DDL_Inactivo.DataValueField = "Matricula_id";
                DDL_Inactivo.DataTextField = "Matricula_comprobante";
                DDL_Inactivo.DataBind();

            }
        }
        protected void CargarGridMatricula()
        {
            using (GestorMatricula laMatricula = new GestorMatricula())
            {

                GVMatricula.DataSource = laMatricula.ListarMatricula();
                GVMatricula.DataBind();
            }
        }
        protected void CargarGridInactivosMatricula()
        {
            using (GestorMatricula laMatricula = new GestorMatricula())
            {

                GridViewAdmin.DataSource = laMatricula.ListarInactivoMatricula();
                GridViewAdmin.DataBind();
            }
        }
        private void Limpiar()
        {
            TBMatriucla_Comprobante.Text = "";

        }

        protected void btnMatricula_CargarDatos_Click(object sender, EventArgs e)
        {
            CargarDatosMatricula();
            CargarDatos();
        }
        protected void CargarDatosMatricula()
        {
            CargarComboEstudiante();
            CargarComboGrupo();
            CargarComboCurso();
            CargarComboProfesor();
            CargarComboHorario();
            CargarComboAula();
        }
        protected void CargarDatos()
        {
            #region Estudiante
            DataSet dsEstudiante = new DataSet();
            DataTable dtEstudiante = new DataTable();
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                int estudiante = int.Parse(dtMatricula.Rows[9]["Estudiante_id"].ToString());
                dsEstudiante = elEstudiante.ConsultarEstudiante(int.Parse(dtMatricula.Rows[9]["Estudiante_id"].ToString()));
                dtEstudiante = dsEstudiante.Tables[0];
                DDL_AulaID.DataSource = dtEstudiante;
                DDL_Inactivo.DataValueField = "Matricula_id";
                DDL_Inactivo.DataTextField = "Matricula_comprobante";
                    
            }
            #endregion

            #region Grupo   
            DataSet dsGrupo = new DataSet();
            DataTable dtGrupo = new DataTable();
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                int Grupo = int.Parse(dtMatricula.Rows[0]["Grupo_id"].ToString());
                dsGrupo = elGrupo.ConsultarGrupo(int.Parse(dtMatricula.Rows[0]["Grupo_id"].ToString()));
                dtGrupo = dsGrupo.Tables[0];
                DDL_GrupoID.DataSource = dtGrupo;
                DDL_GrupoID.DataValueField = "Grupo_id";
                DDL_GrupoID.DataTextField = "Grupo_descripcion";
            }
            #endregion Grupo

            #region Curso   
            DataSet dsCurso = new DataSet();
            DataTable dtCurso = new DataTable();
            using (GestorCurso elCurso = new GestorCurso())
            {
                int Curso = int.Parse(dtMatricula.Rows[0]["Curso_id"].ToString());
                dsCurso = elCurso.ConsultarCurso(int.Parse(dtMatricula.Rows[0]["Curso_id"].ToString()));
                dtCurso = dsCurso.Tables[0];
                DDL_CursoID.DataSource = dtCurso;
                DDL_CursoID.DataValueField = "Curso_id";
                DDL_CursoID.DataTextField = "Curso_nombre";
            }
            #endregion Curso
           
            #region Profesor   
            DataSet dsProfesor = new DataSet();
            DataTable dtProfesor = new DataTable();
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                int Profesor = int.Parse(dtMatricula.Rows[0]["Profesor_id"].ToString());
                dsProfesor = elProfesor.consultarProfesor(int.Parse(dtMatricula.Rows[0]["Profesor_id"].ToString()));
                dtProfesor = dsProfesor.Tables[0];
                DDL_ProfesorID.DataSource = dtProfesor;
                DDL_ProfesorID.DataValueField = "Profesor_id";
                DDL_ProfesorID.DataTextField = "Profesor_cedula";
            }
            #endregion Profesor

            #region Horario   
            DataSet dsHorario = new DataSet();
            DataTable dtHorario = new DataTable();
            using (GestorHorario elHorario = new GestorHorario())
            {
                int Horario = int.Parse(dtMatricula.Rows[0]["Horario_id"].ToString());
                dsHorario = elHorario.ConsultarHorario(int.Parse(dtMatricula.Rows[0]["Horario_id"].ToString()));
                dtHorario = dsHorario.Tables[0];
                DDL_HorarioID.DataSource = dtHorario;
                DDL_HorarioID.DataValueField = "Horario_id";
                DDL_HorarioID.DataTextField = "Horario_dia"; ;
            }
            #endregion Horario

            #region Aula   
            DataSet dsAula = new DataSet();
            DataTable dtAula = new DataTable();
            using (GestorAula elAula = new GestorAula())
            {
                int Aula = int.Parse(dtMatricula.Rows[0]["Aula_id"].ToString());
                dsAula = elAula.consultarAula(int.Parse(dtMatricula.Rows[0]["Aula_id"].ToString()));
                dtAula = dsAula.Tables[0];
                DDL_AulaID.DataSource = dtAula;
                DDL_AulaID.DataValueField = "Aula_id";
                DDL_AulaID.DataTextField = "Aula_capacidad";
            }
            #endregion Aula
            TBMatriucla_Comprobante.Text = this.dtMatricula.Rows[0]["Matricula_comprobante"].ToString();
        }




    }


}