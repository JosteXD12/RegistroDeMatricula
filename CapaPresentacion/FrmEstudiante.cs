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
        string Area;
        DataSet dsEstudiante = new DataSet();
        DataTable dtEstudiante = new DataTable();
        public FrmEstudiante(string Area)
        {
            this.Area = Area;
            InitializeComponent();
        }

        private void FrmEstudiante_Load(object sender, EventArgs e)
        {
            if (Area != "A1")
            {
                gpbEstudiante_Admin.Visible = false;
            }
            Program.PropiedadesDataGried(dgv_admin);
            Program.PropiedadesDataGried(dgvEstudiantes);
            CargarGridEstudiante();
            CargarComboEstudiante();
            cargarComboGrupo();
            CargarGridInactivosEstudiante();
        }

        private void btnEstudiante_insertar_Click_1(object sender, EventArgs e)
        {
            int Grupo_id = int.Parse(cbxEstudiante_Grupo.SelectedValue.ToString());
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                elEstudiante.InsertarEstudiante(Grupo_id, txtEstudiante_Cedula.Text, txtEstudiante_Nombre.Text,
                    txtEstudiante_PrimerApellido.Text, txtEstudiante_SegundoApellido.Text, txtEstudiante_Telefono.Text,
                    txtEstudiante_Email.Text, txtEstudiante_Dirreccion.Text, "A");
            }
            CargarGridEstudiante();
            CargarComboEstudiante();
            Limpiar();
        }

        private void btnEstudiante_Modificar_Click_1(object sender, EventArgs e)
        {
            int getEstudianteID;
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                if (dgvEstudiantes.CurrentCell != null && dgvEstudiantes.Rows.Count > 0)
                {
                    int numfila = dgvEstudiantes.CurrentCell.RowIndex;
                    getEstudianteID = int.Parse(dgvEstudiantes[0, numfila].Value.ToString());
                    elEstudiante.ModificarEstudiante(getEstudianteID, int.Parse(cbxEstudiante_Grupo.SelectedValue.ToString()), txtEstudiante_Cedula.Text, txtEstudiante_Nombre.Text,
                    txtEstudiante_PrimerApellido.Text, txtEstudiante_SegundoApellido.Text, txtEstudiante_Telefono.Text,
                    txtEstudiante_Email.Text, txtEstudiante_Dirreccion.Text, "A");
                }
                else if (cbxEstudiante.SelectedValue != null)
                {
                    elEstudiante.ModificarEstudiante(int.Parse(cbxEstudiante.SelectedValue.ToString()), int.Parse(cbxEstudiante_Grupo.SelectedValue.ToString()), txtEstudiante_Cedula.Text, txtEstudiante_Nombre.Text,
                    txtEstudiante_PrimerApellido.Text, txtEstudiante_SegundoApellido.Text, txtEstudiante_Telefono.Text,
                    txtEstudiante_Email.Text, txtEstudiante_Dirreccion.Text, "A");
                }

            }
            CargarGridEstudiante();
            CargarComboEstudiante();
            Limpiar();
        }

        private void btnEstudiante_Eliminar_Click(object sender, EventArgs e)
        {
            string opcion;
            int getEstudianteID;
            opcion = MessageBox.Show("¿Esta seguro de eliminar la informacion?", " ",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (opcion == "OK")
            {
                using (GestorEstudiante elEstudiante = new GestorEstudiante())
                {
                    if (dgvEstudiantes.CurrentCell != null && dgvEstudiantes.Rows.Count > 0)
                    {
                        int numfila = dgvEstudiantes.CurrentCell.RowIndex;
                        getEstudianteID = int.Parse(dgvEstudiantes[0, numfila].Value.ToString());

                        elEstudiante.inactivarEstudiantes(getEstudianteID);

                    }
                    else if (cbxEstudiante.SelectedValue != null)
                    {
                        elEstudiante.inactivarEstudiantes(int.Parse(cbxEstudiante.SelectedValue.ToString()));
                    }
                }

            }
            CargarGridEstudiante();
            CargarComboEstudiante();
            CargarGridInactivosEstudiante();
            cargarComboGrupo();
            Limpiar();
        }

        private void btnEstudiante_CargarDatos_Click_1(object sender, EventArgs e)
        {
            BuscarEstudainte();
        }

        private void btnAdmin_Activar_Click(object sender, EventArgs e)
        {
            int getEstudianteID;
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                if (dgv_admin.CurrentCell != null && dgv_admin.Rows.Count > 0)
                {
                    int numfila = dgv_admin.CurrentCell.RowIndex;
                    getEstudianteID = int.Parse(dgv_admin[0, numfila].Value.ToString());

                    elEstudiante.ActivarEstudiante(getEstudianteID);

                }

            }
            CargarComboEstudiante();
            CargarGridEstudiante();
            CargarGridInactivosEstudiante();
        }

        private void btnEliminar_Admin_Click(object sender, EventArgs e)
        {
            int getEstudianteID;
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                if (dgv_admin.CurrentCell != null && dgv_admin.Rows.Count > 0)
                {
                    int numfila = dgv_admin.CurrentCell.RowIndex;
                    getEstudianteID = int.Parse(dgv_admin[0, numfila].Value.ToString());

                    elEstudiante.eliminarEstudiante(getEstudianteID);

                }

            }
            CargarGridInactivosEstudiante();

        }
        private void CargarGridInactivosEstudiante()
        {
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                dgv_admin.DataSource = elEstudiante.ListarInactivoEstudiantes();

                dgv_admin.Columns["Estudiante_id"].HeaderText = "ID";
                dgv_admin.Columns["Grupo_id"].HeaderText = "Grupo ID";
                dgv_admin.Columns["Estudiante_cedula"].HeaderText = "Cédula";
                dgv_admin.Columns["Estudiante_nombre"].HeaderText = "Nombre";
                dgv_admin.Columns["Estudiante_primerApellido"].HeaderText = "Apellido";
                dgv_admin.Columns["Estudiante_segundoApellido"].HeaderText = "Apellido";
                dgv_admin.Columns["Estudiante_Telefono"].HeaderText = "Telefono";
                dgv_admin.Columns["Estudiante_correoElectronico"].HeaderText = "eMail";
                dgv_admin.Columns["Estudiante_direccion"].HeaderText = "Direccion";
                dgv_admin.Columns["Estudiante_estado"].HeaderText = "Estado";
            }

        }
        private void CargarDatosEstudiante()
        {
            cbxEstudiante_Grupo.Text = this.dtEstudiante.Rows[0]["Grupo_id"].ToString();
            txtEstudiante_Cedula.Text = this.dtEstudiante.Rows[0]["Estudiante_cedula"].ToString();
            txtEstudiante_Nombre.Text = this.dtEstudiante.Rows[0]["Estudiante_nombre"].ToString();
            txtEstudiante_PrimerApellido.Text = this.dtEstudiante.Rows[0]["Estudiante_primerApellido"].ToString();
            txtEstudiante_SegundoApellido.Text = this.dtEstudiante.Rows[0]["Estudiante_segundoApellido"].ToString();
            txtEstudiante_Telefono.Text = this.dtEstudiante.Rows[0]["Estudiante_Telefono"].ToString();
            txtEstudiante_Email.Text = this.dtEstudiante.Rows[0]["Estudiante_correoElectronico"].ToString();
            txtEstudiante_Dirreccion.Text = this.dtEstudiante.Rows[0]["Estudiante_direccion"].ToString();

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
            int Estudiante_id;
            
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                if (dgvEstudiantes.CurrentCell != null && dgvEstudiantes.Rows.Count > 0)
                { 
                    int numfila = dgvEstudiantes.CurrentCell.RowIndex;
                    Estudiante_id = int.Parse(dgvEstudiantes[0, numfila].Value.ToString());
                    this.dsEstudiante = elEstudiante.ConsultarEstudiante(Estudiante_id);
                    this.dtEstudiante = this.dsEstudiante.Tables[0];
                }
                else if (cbxEstudiante.SelectedValue != null)
                {
                    Estudiante_id = int.Parse(cbxEstudiante.SelectedValue.ToString());
                    this.dsEstudiante = elEstudiante.ConsultarEstudiante(Estudiante_id);
                    this.dtEstudiante = this.dsEstudiante.Tables[0];
                }


            }
            CargarDatosEstudiante();
        }

        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
        private void Limpiar()
        {
            txtEstudiante_Cedula.Text = "";
            txtEstudiante_Nombre.Text = "";
            txtEstudiante_PrimerApellido.Text = "";
            txtEstudiante_SegundoApellido.Text = "";
            txtEstudiante_Telefono.Text = "";
            txtEstudiante_Email.Text = "";
            txtEstudiante_Dirreccion.Text = "";
        }

        private void dgvEstudiantes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            BuscarEstudainte();
        }


    }
}
