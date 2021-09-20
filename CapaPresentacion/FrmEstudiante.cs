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
    public partial class FrmEstudiante : Form

    {
        DataSet dsEstudiante = new DataSet();
        DataTable dtEstudiante = new DataTable();
        public FrmEstudiante()
        {
            InitializeComponent();
        }

        private void btnEstudiante_insertar_Click(object sender, EventArgs e)
        {
            int Grupo_id = int.Parse(cbxEstudiante_Grupo.SelectedValue.ToString());
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                elEstudiante.InsertarEstudiante(Grupo_id,txtEstudiante_Cedula.Text, txtEstudiante_Nombre.Text,
                    txtEstudiante_PrimerApellido.Text, txtEstudiante_SegundoApellido.Text, txtEstudiante_Telefono.Text,
                    txtEstudiante_Email.Text, txtEstudiante_Dirreccion.Text, "A");
            }
            CargarGridEstudiante();
            CargarComboEstudiante();
        }
        
        private void FrmEstudiante_Load(object sender, EventArgs e)
        {
            CargarGridEstudiante();
            CargarComboEstudiante();
            cargarComboGrupo();
        }
        
        private void CargarGridEstudiante()
        {
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                dgvEstudiantes.DataSource = elEstudiante.ListarEstudiante();

                dgvEstudiantes.Columns["Estudiante_id"].Visible = false;
                dgvEstudiantes.Columns["Grupo_id"].Visible = false;
                dgvEstudiantes.Columns["Estudiante_cedula"].HeaderText = "Cédula";
                dgvEstudiantes.Columns["Estudiante_nombre"].HeaderText = "Nombre";
                dgvEstudiantes.Columns["Estudiante_primerApellido"].HeaderText = "Apellido";
                dgvEstudiantes.Columns["Estudiante_segundoApellido"].HeaderText = "Apellido";
                dgvEstudiantes.Columns["Estudiante_Telefono"].HeaderText = "Telefono";
                dgvEstudiantes.Columns["Estudiante_correoElectronico"].HeaderText = "eMail";
                dgvEstudiantes.Columns["Estudiante_direccion"].HeaderText = "Direccion";
                dgvEstudiantes.Columns["Estudiante_estado"].Visible = false;
            }

        }
        private void CargarComboEstudiante()
        {
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                cbxEstudiante.DataSource = elEstudiante.ListarEstudiante();
                cbxEstudiante.ValueMember = "Estudiante_id";
                cbxEstudiante.DisplayMember = "Estudiante_cedula";
            }
        }
        private void BuscarEstudainte()
        {
            int Estudiante_id = int.Parse(cbxEstudiante.SelectedValue.ToString());

            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                this.dsEstudiante = elEstudiante.ConsultarEstudiante(Estudiante_id);
                this.dtEstudiante = this.dsEstudiante.Tables[0];
            }
            CargarDatosEstudiante();
        }
        private void CargarDatosEstudiante()
        {
            txtEstudiante_Cedula.Text = this.dtEstudiante.Rows[0]["Estudiante_cedula"].ToString();
            txtEstudiante_Nombre.Text = this.dtEstudiante.Rows[0]["Estudiante_nombre"].ToString();
            txtEstudiante_PrimerApellido.Text = this.dtEstudiante.Rows[0]["Estudiante_primerApellido"].ToString();
            txtEstudiante_SegundoApellido.Text = this.dtEstudiante.Rows[0]["Estudiante_segundoApellido"].ToString();
            txtEstudiante_Telefono.Text = this.dtEstudiante.Rows[0]["Estudiante_Telefono"].ToString();
            txtEstudiante_Email.Text = this.dtEstudiante.Rows[0]["Estudiante_correoElectronico"].ToString();
            txtEstudiante_Dirreccion.Text = this.dtEstudiante.Rows[0]["Estudiante_direccion"].ToString();

        }

        private void btnEstudiante_CargarDatos_Click(object sender, EventArgs e)
        {
            BuscarEstudainte();
        }

        private void btnEstudiante_Modificar_Click(object sender, EventArgs e)
        {
            int Grupo_id = int.Parse(cbxEstudiante_Grupo.SelectedValue.ToString());
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                elEstudiante.ModificarEstudiante(int.Parse(cbxEstudiante.SelectedValue.ToString()),Grupo_id, txtEstudiante_Cedula.Text, txtEstudiante_Nombre.Text,
                    txtEstudiante_PrimerApellido.Text, txtEstudiante_SegundoApellido.Text, txtEstudiante_Telefono.Text,
                    txtEstudiante_Email.Text, txtEstudiante_Dirreccion.Text, "A");
            }
            CargarGridEstudiante();
            CargarComboEstudiante();
        }

        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int numFila = dgvEstudiantes.CurrentCell.RowIndex;
                int Estudiante_id = int.Parse(this.dgvEstudiantes[0, numFila].Value.ToString());

                using (GestorEstudiante elEstudiante = new GestorEstudiante())
                {
                    this.dsEstudiante = elEstudiante.ConsultarEstudiante(Estudiante_id);
                    this.dtEstudiante = this.dsEstudiante.Tables[0];
                }
                CargarDatosEstudiante();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacía. Ingrese datos", "Alerta",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void txtEstudiante_Telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEstudiante_SegundoNombre_Click(object sender, EventArgs e)
        {

        }

        private void cbxEstudiante_Grupo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void cargarComboGrupo()
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                cbxEstudiante_Grupo.DataSource = elGrupo.ListarGrupo();
                cbxEstudiante_Grupo.ValueMember = "Grupo_id";
                cbxEstudiante_Grupo.DisplayMember = "Grupo_descripcion";
            }
        }
    }
}
