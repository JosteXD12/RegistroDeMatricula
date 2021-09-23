using Resgistro_de_Matricula.CapaIntegracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmMatricula : Form
    {


        string Area;
        DataSet dsMatricula = new DataSet();
        DataTable dtMatricula = new DataTable();
        public frmMatricula(string Area)
        {
            this.Area = Area;
            InitializeComponent();
        }

        private void frmMatricula_Load(object sender, EventArgs e)
        {
            if (Area != "A1")
            {
                gpbMatricula_Admin.Visible = false;
            }
            Program.PropiedadesDataGried(dgv_admin);
            Program.PropiedadesDataGried(dgvMatricula);
            CargarGridMatricula();
            CargarComboMatricula();
            CargarDatosMatricula();
            CargarGridInactivosMatricula();

        }
        private void CargarComboEstudiante()
        {
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                cbxEstudianteID.DataSource = elEstudiante.ListarEstudiante();
                cbxEstudianteID.ValueMember = "Estudiante_id";
                cbxEstudianteID.DisplayMember = "Estudiante_cedula";
            }
        }

        private void CargarComboGrupo()
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                cbxGrupoID.DataSource = elGrupo.ListarGrupo();
                cbxGrupoID.ValueMember = "Grupo_id";
                cbxGrupoID.DisplayMember = "Grupo_descripcion";
            }
        }
        private void CargarComboCurso()
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                cbxCursoID.DataSource = elCurso.ListarCurso();
                cbxCursoID.ValueMember = "Curso_id";
                cbxCursoID.DisplayMember = "Curso_nombre";
            }
        }
        private void CargarComboProfesor()
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                cbxProfesorID.DataSource = elProfesor.ListarProfesor();
                cbxProfesorID.ValueMember = "Profesor_id";
                cbxProfesorID.DisplayMember = "Profesor_cedula";
            }
        }
        private void CargarComboHorario()
        {
            using (GestorHorario elHorario = new GestorHorario())
            {
                cbxHorarioID.DataSource = elHorario.ListarHorario();
                cbxHorarioID.ValueMember = "Horario_id";
                cbxHorarioID.DisplayMember = "Horario_dia";
            }
        }
        private void CargarComboAula()
        {
            using (GestorAula elAula = new GestorAula())
            {
                cbxAulaID.DataSource = elAula.ListarAula();
                cbxAulaID.ValueMember = "Aula_id";
                cbxAulaID.DisplayMember = "Aula_capacidad";
            }
        }
        private void CargarComboMatricula()
        {
            using (GestorMatricula laMatricula = new GestorMatricula())
            {
                cbxMatricula.DataSource = laMatricula.ListarMatricula();
                cbxMatricula.ValueMember = "Matricula_id";
                cbxMatricula.DisplayMember = "Matricula_comprobante";
            }
        }

        private void btnMatricula_Insertar_Click(object sender, EventArgs e)
        {
            using (GestorMatricula laMatricula = new GestorMatricula())
            {
                int EstudianteID = int.Parse(cbxEstudianteID.SelectedValue.ToString());
                int GrupoID = int.Parse(cbxGrupoID.SelectedValue.ToString());
                int CursoID = int.Parse(cbxCursoID.SelectedValue.ToString());
                int ProfesorID = int.Parse(cbxProfesorID.SelectedValue.ToString());
                int HorarioID = int.Parse(cbxHorarioID.SelectedValue.ToString());
                int AulaID = int.Parse(cbxAulaID.SelectedValue.ToString());
                Console.WriteLine(cbxEstudianteID.SelectedValue.ToString());
                Console.WriteLine("aqui estoy sadsdasdasd");

                laMatricula.InsertarMatricula(EstudianteID, GrupoID, CursoID, ProfesorID,
                    HorarioID, AulaID, txtComprobanteMatricula.Text, "A");
            }
            CargarGridMatricula();
            CargarComboMatricula();
            Limpiar();
        }

        private void btnMatricula_Eliminar_Click(object sender, EventArgs e)
        {
            string opcion;
            int GetMatriculaID;
            opcion = MessageBox.Show("¿Esta seguro de eliminar la informacion?", " ",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (opcion == "OK")
            {
                using (GestorMatricula elMatricula = new GestorMatricula())
                {
                    if (dgvMatricula.CurrentCell != null && dgvMatricula.Rows.Count > 0)
                    {
                        int numfila = dgvMatricula.CurrentCell.RowIndex;
                        GetMatriculaID = int.Parse(dgvMatricula[0, numfila].Value.ToString());

                        elMatricula.inactivarMatricula(GetMatriculaID);
                    }
                    else if (cbxMatricula.SelectedValue != null)
                    {
                        elMatricula.inactivarMatricula(int.Parse(cbxMatricula.SelectedValue.ToString()));
                    }

                }
            }
            CargarGridMatricula();
            CargarComboMatricula();
            CargarGridInactivosMatricula();
            Limpiar();
        }

        private void btnMatricula_Modificar_Click(object sender, EventArgs e)
        {
            int getAulaID;
            int EstudianteID = int.Parse(cbxEstudianteID.SelectedIndex.ToString());
            int GrupoID = int.Parse(cbxGrupoID.SelectedIndex.ToString());
            int CursoID = int.Parse(cbxCursoID.SelectedIndex.ToString());
            int ProfesorID = int.Parse(cbxProfesorID.SelectedIndex.ToString());
            int HorarioID = int.Parse(cbxHorarioID.SelectedIndex.ToString());
            int AulaID = int.Parse(cbxAulaID.SelectedIndex.ToString());
            using (GestorMatricula laMatricula = new GestorMatricula())
            {
                if (dgvMatricula.CurrentCell != null && dgvMatricula.Rows.Count > 0)
                {
                    int numfila = dgvMatricula.CurrentCell.RowIndex;
                    getAulaID = int.Parse(dgvMatricula[0, numfila].Value.ToString());
                    laMatricula.ModificarMatricula(getAulaID, EstudianteID, GrupoID, CursoID, ProfesorID,
                        HorarioID, AulaID, txtComprobanteMatricula.Text, "A");
                }
                else if (cbxMatricula.SelectedValue != null)
                {
                    laMatricula.ModificarMatricula(int.Parse(cbxMatricula.SelectedValue.ToString()), EstudianteID, GrupoID, CursoID, ProfesorID,
                        HorarioID, AulaID, txtComprobanteMatricula.Text, "A");
                }

            }
            CargarGridMatricula();
            CargarComboMatricula();
            Limpiar();
        }

        private void btnLoadDatos_Click(object sender, EventArgs e)
        {
            BuscarMatricula();
        }

        private void btnAdmin_Activar_Click(object sender, EventArgs e)
        {
            int getMatriculaID;
            using (GestorMatricula laMatricula = new GestorMatricula())
            {
                if (dgv_admin.CurrentCell != null && dgv_admin.Rows.Count > 0)
                {
                    int numfila = dgv_admin.CurrentCell.RowIndex;
                    getMatriculaID = int.Parse(dgv_admin[0, numfila].Value.ToString());

                    laMatricula.ActivarMatricula(getMatriculaID);

                }

            }
            CargarComboMatricula();
            CargarGridMatricula();
            CargarGridInactivosMatricula();
        }

        private void btnEliminar_Admin_Click(object sender, EventArgs e)
        {
            int getMatriculaID;
            using (GestorMatricula laMatricula = new GestorMatricula())
            {
                if (dgv_admin.CurrentCell != null && dgv_admin.Rows.Count > 0)
                {
                    int numfila = dgv_admin.CurrentCell.RowIndex;
                    getMatriculaID = int.Parse(dgv_admin[0, numfila].Value.ToString());

                    laMatricula.eliminarMatricula(getMatriculaID);

                }

            }
            CargarGridInactivosMatricula();
        }
        private void CargarGridMatricula()
        {

            using (GestorMatricula laMatricula = new GestorMatricula())
            {

                dgvMatricula.DataSource = laMatricula.ListarMatricula();
                dgvMatricula.Columns["Matricula_id"].Visible = false;
                dgvMatricula.Columns["Estudiante_id"].Visible = false;
                dgvMatricula.Columns["Grupo_id"].Visible = false;
                dgvMatricula.Columns["Curso_id"].Visible = false;
                dgvMatricula.Columns["Profesor_id"].Visible = false;
                dgvMatricula.Columns["Horario_id"].Visible = false;
                dgvMatricula.Columns["Curso_id"].Visible = false;
                dgvMatricula.Columns["Aula_id"].Visible = false;
                dgvMatricula.Columns["Matricula_comprobante"].HeaderText = "Comprobante";
                dgvMatricula.Columns["Matricula_estado"].Visible = false;
            }
        }
        private void CargarDatos()
        {
            #region Estudiante
            DataSet dsEstudiante = new DataSet();
            DataTable dtEstudiante = new DataTable();
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                int estudiante = int.Parse(dtMatricula.Rows[0]["Estudiante_id"].ToString());
                dsEstudiante = elEstudiante.ConsultarEstudiante(int.Parse(dtMatricula.Rows[0]["Estudiante_id"].ToString()));
                dtEstudiante = dsEstudiante.Tables[0];
                cbxEstudianteID.DataSource = dtEstudiante;
                cbxEstudianteID.DisplayMember = "Estudiante_cedula";
                cbxEstudianteID.ValueMember = "Estudiante_id";
            }
            #endregion estudiante .

            #region Grupo   
            DataSet dsGrupo = new DataSet();
            DataTable dtGrupo = new DataTable();
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                int Grupo = int.Parse(dtMatricula.Rows[0]["Grupo_id"].ToString());
                dsGrupo = elGrupo.ConsultarGrupo(int.Parse(dtMatricula.Rows[0]["Grupo_id"].ToString()));
                dtGrupo = dsGrupo.Tables[0];
                cbxGrupoID.DataSource = dtGrupo;
                cbxGrupoID.DisplayMember = "Grupo_descripcion";
                cbxGrupoID.ValueMember = "Grupo_id";
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
                cbxCursoID.DataSource = dtCurso;
                cbxCursoID.DisplayMember = "Curso_nombre";
                cbxCursoID.ValueMember = "Curso_id";
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
                cbxProfesorID.DataSource = dtProfesor;
                cbxProfesorID.DisplayMember = "Profesor_cedula";
                cbxProfesorID.ValueMember = "Profesor_id";
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
                cbxHorarioID.DataSource = dtHorario;
                cbxHorarioID.DisplayMember = "Horario_dia";
                cbxHorarioID.ValueMember = "Horario_id";
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
                cbxAulaID.DataSource = dtAula;
                cbxAulaID.DisplayMember = "Aula_capacidad";
                cbxAulaID.ValueMember = "Aula_id";
            }
            #endregion Aula

            txtComprobanteMatricula.Text = this.dtMatricula.Rows[0]["Matricula_comprobante"].ToString();


        }

        private void CargarGridInactivosMatricula()
        {
            using (GestorMatricula laMatricula = new GestorMatricula())
            {
                dgv_admin.DataSource = laMatricula.ListarInactivoMatricula();
                dgv_admin.Columns["Matricula_id"].HeaderText = "Matricula_ID";
                dgvMatricula.Columns["Estudiante_id"].HeaderText = "Estudiante";
                dgv_admin.Columns["Grupo_id"].HeaderText = "Grupo";
                dgv_admin.Columns["Curso_id"].HeaderText = "Curso";
                dgv_admin.Columns["Profesor_id"].HeaderText = "Profesor";
                dgv_admin.Columns["Horario_id"].HeaderText = "Horario";
                dgv_admin.Columns["Curso_id"].HeaderText = "Curso";
                dgv_admin.Columns["Aula_id"].HeaderText = "Aula";
                dgv_admin.Columns["Matricula_comprobante"].HeaderText = "Comprobante";
                dgv_admin.Columns["Matricula_estado"].HeaderText = "Estado";
            }
        }
        private void BuscarMatricula()
        {
            int Aula_id = int.Parse(cbxMatricula.SelectedValue.ToString());
            using (GestorMatricula laMatricula = new GestorMatricula())
            {
                this.dsMatricula = laMatricula.consultarMatricula(Aula_id);
                this.dtMatricula = this.dsMatricula.Tables[0];
            }
            CargarDatosMatricula();
        }
        private void CargarDatosMatricula()
        {
            CargarComboEstudiante();
            CargarComboProfesor();
            CargarComboHorario();
            CargarComboGrupo();
            CargarComboCurso();
            CargarComboAula();

            
        }
        private void Limpiar()
        {
            txtComprobanteMatricula.Text = "";

        }

        private void dgvMatricula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int numFila = dgvMatricula.CurrentCell.RowIndex;
                int Matricula_id = int.Parse(this.dgvMatricula[0, numFila].Value.ToString());

                using (GestorMatricula laMatricula = new GestorMatricula())
                {
                    this.dsMatricula = laMatricula.consultarMatricula(Matricula_id);
                    this.dtMatricula = this.dsMatricula.Tables[0];
                }
                CargarDatosMatricula();
                CargarDatos();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacía. Ingrese datos", "Alerta",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            }
        }
    }
}
