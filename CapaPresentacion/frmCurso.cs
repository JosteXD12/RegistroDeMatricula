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
    public partial class frmCurso : Form
    {
        string Area;
        DataSet dsCurso = new DataSet();
        DataTable dtCurso = new DataTable();

        public frmCurso(string Area)
        {
            this.Area = Area;
            InitializeComponent();
        }

        private void frmCurso_Load(object sender, EventArgs e)
        {
            if (Area != "A1")
            {
                gpbCurso_Admin.Visible = false;
            }
            Program.PropiedadesDataGried(dgv_admin);
            Program.PropiedadesDataGried(dgvCurso);
            CargarGridCurso();
            CargarComboCurso();
            CargarGridInactivosCurso();
        }
       
        private void btnCurso_insertar_Click_1(object sender, EventArgs e)
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                elCurso.InsertarCurso(txtCurso_Nombre.Text, txtCurso_Creditos.Text,
                    txtCurso_Cupos.Text, "A");
            }
            CargarGridCurso();
            CargarComboCurso();
        }

        private void btnCurso_Modificar_Click_1(object sender, EventArgs e)
        {
            int getCursoID;
            using (GestorCurso elCurso = new GestorCurso())
            {
                if (dgvCurso.CurrentCell != null && dgvCurso.Rows.Count > 0)
                {
                    int numfila = dgvCurso.CurrentCell.RowIndex;
                    getCursoID = int.Parse(dgvCurso[0, numfila].Value.ToString());
                    elCurso.ModificarCurso(getCursoID, txtCurso_Nombre.Text, txtCurso_Creditos.Text,
                    txtCurso_Cupos.Text, "A");
                }
                else if (cbxCurso.SelectedValue != null)
                {
                    elCurso.ModificarCurso(int.Parse(cbxCurso.SelectedValue.ToString()), txtCurso_Nombre.Text, txtCurso_Creditos.Text,
                    txtCurso_Cupos.Text, "A");
                }

            }
            CargarGridCurso();
            CargarComboCurso();
            Limpiar();
        }
        private void btnCurso_Eliminar_Click(object sender, EventArgs e)
        {
            string opcion;
            int getCursoID;
            opcion = MessageBox.Show("¿Esta seguro de eliminar la informacion?", " ",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (opcion == "OK")
            {
                using (GestorCurso elCurso = new GestorCurso())
                {
                    if (dgvCurso.CurrentCell != null && dgvCurso.Rows.Count > 0)
                    {
                        int numfila = dgvCurso.CurrentCell.RowIndex;
                        getCursoID = int.Parse(dgvCurso[0, numfila].Value.ToString());

                        elCurso.inactivarCurso(getCursoID);

                    }
                    else if (cbxCurso.SelectedValue != null)
                    {
                        elCurso.inactivarCurso(int.Parse(cbxCurso.SelectedValue.ToString()));
                    }
                }
            }
            CargarGridCurso();
            CargarComboCurso();
            CargarGridInactivosCurso();
            Limpiar();

        }

        private void btnCurso_CargarDatos_Click_1(object sender, EventArgs e)
        {
            BuscarCurso();
        }


        private void btnCurso_Eliminar_Click_1(object sender, EventArgs e)
        {
            string opcion;
            int getCursoID;
            opcion = MessageBox.Show("¿Esta seguro de eliminar la informacion?", " ",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (opcion == "OK")
            {
                using (GestorCurso elCurso = new GestorCurso())
                {
                    if (dgvCurso.CurrentCell != null && dgvCurso.Rows.Count > 0)
                    {
                        int numfila = dgvCurso.CurrentCell.RowIndex;
                        getCursoID = int.Parse(dgvCurso[0, numfila].Value.ToString());

                        elCurso.inactivarCurso(getCursoID);

                    }

                }
            }

            CargarGridCurso();
            CargarComboCurso();
            CargarGridInactivosCurso();
            Limpiar();

        }

        private void CargarGridInactivosCurso()
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                dgv_admin.DataSource = elCurso.ListarInactivoCurso();
                dgv_admin.Columns["Curso_id"].HeaderText = "ID";
                dgv_admin.Columns["Curso_nombre"].HeaderText = "Nombre del Curso";
                dgv_admin.Columns["Curso_creditos"].HeaderText = "Creditos";
                dgv_admin.Columns["Curso_cupo"].HeaderText = "Cupo";
                dgv_admin.Columns["Curso_estado"].HeaderText = "Estado";
            }

        }
        private void CargarGridCurso()
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                dgvCurso.DataSource = elCurso.ListarCurso();
                dgvCurso.Columns["Curso_id"].Visible = false;
                dgvCurso.Columns["Curso_nombre"].HeaderText = "Nombre del Curso";
                dgvCurso.Columns["Curso_creditos"].HeaderText = "Creditos";
                dgvCurso.Columns["Curso_cupo"].HeaderText = "Cupo";
                dgvCurso.Columns["Curso_estado"].Visible = false;
            }
        }

        private void dgvCurso_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int numFila = dgvCurso.CurrentCell.RowIndex;
                int Curso_id = int.Parse(this.dgvCurso[0, numFila].Value.ToString());

                using (GestorCurso elCurso = new GestorCurso())
                {
                    this.dsCurso = elCurso.ConsultarCurso(Curso_id);
                    this.dtCurso = this.dsCurso.Tables[0];
                }
                CargarDatosCurso();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacía. Ingrese datos", "Alerta",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            }
        }
        private void CargarDatosCurso()
        {
            txtCurso_Nombre.Text = this.dtCurso.Rows[0]["Curso_nombre"].ToString();
            txtCurso_Creditos.Text = this.dtCurso.Rows[0]["Curso_creditos"].ToString();
            txtCurso_Cupos.Text = this.dtCurso.Rows[0]["Curso_cupo"].ToString();
        }

        private void CargarComboCurso()
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                cbxCurso.DataSource = elCurso.ListarCurso();
                cbxCurso.ValueMember = "Curso_id";
                cbxCurso.DisplayMember = "Curso_nombre";
            }
        }

        private void BuscarCurso()
        {
            int Curso_id = int.Parse(cbxCurso.SelectedValue.ToString());
            using (GestorCurso elCurso = new GestorCurso())
            {
                this.dsCurso = elCurso.ConsultarCurso(Curso_id);
                this.dtCurso = this.dsCurso.Tables[0];
            }
            CargarDatosCurso();
        }
        private void Limpiar()
        {
           txtCurso_Nombre.Text = "";
           txtCurso_Creditos.Text = "";
           txtCurso_Cupos.Text = "";
        }

        private void txtCurso_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.verficacionLetras(e);
        }

        private void txtCurso_Creditos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.verficacionNumero(e);
        }

        private void txtCurso_Cupos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.verficacionNumero(e);
        }

        private void btnEliminar_Admin_Click_1(object sender, EventArgs e)
        {
            int getCursoID;
            using (GestorCurso elCurso = new GestorCurso())
            {
                if (dgv_admin.CurrentCell != null && dgv_admin.Rows.Count > 0)
                {
                    int numfila = dgv_admin.CurrentCell.RowIndex;
                    getCursoID = int.Parse(dgv_admin[0, numfila].Value.ToString());

                    elCurso.eliminarCurso(getCursoID);

                }

            }
            CargarGridInactivosCurso();
        }

        private void btnAdmin_Activar_Click_1(object sender, EventArgs e)
        {
            int getCursoID;
            using (GestorCurso elCurso = new GestorCurso())
            {
                if (dgv_admin.CurrentCell != null && dgv_admin.Rows.Count > 0)
                {
                    int numfila = dgv_admin.CurrentCell.RowIndex;
                    getCursoID = int.Parse(dgv_admin[0, numfila].Value.ToString());

                    elCurso.ActivarCurso(getCursoID);

                }
            }
            CargarComboCurso();
            CargarGridCurso();
            CargarGridInactivosCurso();
        }
    }
}
