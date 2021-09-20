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
        DataSet dsCurso = new DataSet();
        DataTable dtCurso = new DataTable();

        public frmCurso()
        {
            InitializeComponent();
        }

        private void frmCurso_Load(object sender, EventArgs e)
        {
            CargarGridCurso();
            CargarComboCurso();
        }

        private void btnCurso_insertar_Click(object sender, EventArgs e)
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                elCurso.InsertarCurso(txtCurso_Nombre.Text, txtCurso_Creditos.Text,
                    txtCurso_Cupos.Text, "A");
            }
            CargarGridCurso();
            CargarComboCurso();
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
        private void CargarDatosCurso()
        {
            txtCurso_Nombre.Text = this.dtCurso.Rows[0]["Curso_nombre"].ToString();
            txtCurso_Creditos.Text = this.dtCurso.Rows[0]["Curso_creditos"].ToString();
            txtCurso_Cupos.Text = this.dtCurso.Rows[0]["Curso_cupo"].ToString(); 
        }

        private void btnCurso_CargarDatos_Click(object sender, EventArgs e)
        {
            BuscarCurso();
        }

        private void btnCurso_Modificar_Click(object sender, EventArgs e)
        {
            int Curso_id = int.Parse(cbxCurso.SelectedValue.ToString());
            using (GestorCurso elCurso = new GestorCurso())
            {

                elCurso.ModificarCurso(Curso_id, txtCurso_Nombre.Text, txtCurso_Creditos.Text,
                    txtCurso_Cupos.Text, "A");
            }
            CargarGridCurso();
            CargarComboCurso();
        }

        private void dgvCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
