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
    public partial class frmProfesor : Form
    {
        DataSet dsProfesor = new DataSet();
        DataTable dtProfesor = new DataTable();
        public frmProfesor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrimerApellido_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnProfesor_Insertar_Click(object sender, EventArgs e)
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                elProfesor.InsertarProfesor(txtProfesor_Cedula.Text, txtProfesor_nombre.Text,
                    txtProfesor_PrimerApeliido.Text, txtProfesor_SegundoApeliido.Text, txtProfesor_telefono.Text,
                    txtProfesor_CorreoElectronico.Text, txtProfesor_Dirreccion.Text, "A");
            }
            CargarGridProfesor();
            CargarComboProfesor();
            Limpiar();

        }

        private void frmProfesor_Load(object sender, EventArgs e)
        {
            Program.PropiedadesDataGried(dgv_admin);
            Program.PropiedadesDataGried(dvgProfesores);
            CargarGridProfesor();
            CargarComboProfesor();
            CargarGridInactivosProfesor();
        }

        private void CargarGridProfesor()
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                dvgProfesores.DataSource = elProfesor.ListarProfesor();

                dvgProfesores.Columns["Profesor_id"].Visible = false;
                dvgProfesores.Columns["Profesor_cedula"].HeaderText = "Cédula";
                dvgProfesores.Columns["Profesor_nombre"].HeaderText = "Nombre";
                dvgProfesores.Columns["Profesor_primerApellido"].HeaderText = "Apellido";
                dvgProfesores.Columns["Profesor_segundoApellido"].HeaderText = "Apellido";
                dvgProfesores.Columns["Profesor_Telefono"].HeaderText = "Telefono";
                dvgProfesores.Columns["Profesor_correoElectronico"].HeaderText = "eMail";
                dvgProfesores.Columns["Profesor_direccion"].HeaderText = "Direccion";
                dvgProfesores.Columns["Profesor_estado"].Visible = false;
            }

        }

        private void CargarComboProfesor()
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                cbxProfesor.DataSource = elProfesor.ListarProfesor();
                cbxProfesor.ValueMember = "Profesor_id";
                cbxProfesor.DisplayMember = "Profesor_cedula";
            }
        }

        private void BuscarProfesor()
        {
            int Profesor_id = int.Parse(cbxProfesor.SelectedValue.ToString());

            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                this.dsProfesor = elProfesor.consultarProfesor(Profesor_id);
                this.dtProfesor = this.dsProfesor.Tables[0];
            }
            CargarDatosProfesor();

        }
        private void CargarDatosProfesor()
        {
            txtProfesor_Cedula.Text = this.dtProfesor.Rows[0]["Profesor_cedula"].ToString();
            txtProfesor_nombre.Text = this.dtProfesor.Rows[0]["Profesor_nombre"].ToString();
            txtProfesor_PrimerApeliido.Text = this.dtProfesor.Rows[0]["Profesor_primerApellido"].ToString();
            txtProfesor_SegundoApeliido.Text = this.dtProfesor.Rows[0]["Profesor_segundoApellido"].ToString();
            txtProfesor_telefono.Text = this.dtProfesor.Rows[0]["Profesor_Telefono"].ToString();
            txtProfesor_CorreoElectronico.Text = this.dtProfesor.Rows[0]["Profesor_correoElectronico"].ToString();
            txtProfesor_Dirreccion.Text = this.dtProfesor.Rows[0]["Profesor_direccion"].ToString();

        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            BuscarProfesor();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int getProfesorID;
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                if (dvgProfesores.CurrentCell != null && dvgProfesores.Rows.Count > 0)
                {
                    int numfila = dvgProfesores.CurrentCell.RowIndex;
                    getProfesorID = int.Parse(dvgProfesores[0, numfila].Value.ToString());
                    elProfesor.ModificarProfesor(getProfesorID, txtProfesor_Cedula.Text, txtProfesor_nombre.Text,
                    txtProfesor_PrimerApeliido.Text, txtProfesor_SegundoApeliido.Text, txtProfesor_telefono.Text,
                    txtProfesor_CorreoElectronico.Text, txtProfesor_Dirreccion.Text, "A");
                }
                else if (cbxProfesor.SelectedValue != null)
                {
                    elProfesor.ModificarProfesor(int.Parse(cbxProfesor.SelectedValue.ToString()), txtProfesor_Cedula.Text, txtProfesor_nombre.Text,
                    txtProfesor_PrimerApeliido.Text, txtProfesor_SegundoApeliido.Text, txtProfesor_telefono.Text,
                    txtProfesor_CorreoElectronico.Text, txtProfesor_Dirreccion.Text, "A");
                }

            }
            CargarGridProfesor();
            CargarComboProfesor();
            Limpiar();
        }

        private void dvgProfesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int numFila = dvgProfesores.CurrentCell.RowIndex;
                int Profesor_id = int.Parse(this.dvgProfesores[0, numFila].Value.ToString());

                using (GestorProfesor elProfesor = new GestorProfesor())
                {
                    this.dsProfesor = elProfesor.consultarProfesor(Profesor_id);
                    this.dtProfesor = this.dsProfesor.Tables[0];
                }
                CargarDatosProfesor();
                CargarComboProfesor();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacía. Ingrese datos", "Alerta",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void btnProfesora_Eliminar_Click(object sender, EventArgs e)
        {
            string opcion;
            int getProfesorID;
            opcion = MessageBox.Show("¿Esta seguro de eliminar la informacion?", " ",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (opcion == "OK")
            {
                using (GestorProfesor elProfesor = new GestorProfesor())
                {
                    if (dvgProfesores.CurrentCell != null && dvgProfesores.Rows.Count > 0)
                    {
                        int numfila = dvgProfesores.CurrentCell.RowIndex;
                        getProfesorID = int.Parse(dvgProfesores[0, numfila].Value.ToString());

                        elProfesor.inactivarProfesor(getProfesorID);

                    }
                    else if (cbxProfesor.SelectedValue != null)
                    {
                        elProfesor.inactivarProfesor(int.Parse(cbxProfesor.SelectedValue.ToString()));
                    }
                }
            }
            CargarGridProfesor();
            CargarComboProfesor();
            Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int getProfesorID;
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                if (dvgProfesores.CurrentCell != null && dvgProfesores.Rows.Count > 0)
                {
                    int numfila = dvgProfesores.CurrentCell.RowIndex;
                    getProfesorID = int.Parse(dvgProfesores[0, numfila].Value.ToString());

                    elProfesor.inactivarProfesor(getProfesorID);

                }
                else if (cbxProfesor.SelectedValue != null)
                {
                    elProfesor.inactivarProfesor(int.Parse(cbxProfesor.SelectedValue.ToString()));
                }

            }
            CargarComboProfesor();
            CargarGridProfesor();
            Limpiar();
        }

        private void Limpiar()
        {
            txtProfesor_Cedula.Text = "";
            txtProfesor_nombre.Text = "";
            txtProfesor_PrimerApeliido.Text = "";
            txtProfesor_SegundoApeliido.Text = "";
            txtProfesor_telefono.Text = "";
            txtProfesor_CorreoElectronico.Text = "";
            txtProfesor_Dirreccion.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void CargarGridInactivosProfesor()
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                dgv_admin.DataSource = elProfesor.ListarInactivoProfesor();

                dgv_admin.Columns["Profesor_id"].HeaderText = "ID";
                dgv_admin.Columns["Profesor_cedula"].HeaderText = "Cédula";
                dgv_admin.Columns["Profesor_nombre"].HeaderText = "Nombre";
                dgv_admin.Columns["Profesor_primerApellido"].HeaderText = "Apellido";
                dgv_admin.Columns["Profesor_segundoApellido"].HeaderText = "Apellido";
                dgv_admin.Columns["Profesor_Telefono"].HeaderText = "Telefono";
                dgv_admin.Columns["Profesor_correoElectronico"].HeaderText = "eMail";
                dgv_admin.Columns["Profesor_direccion"].HeaderText = "Direccion";
                dgv_admin.Columns["Profesor_estado"].HeaderText = "Estado";
            }

        }
        private void dgv_admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
