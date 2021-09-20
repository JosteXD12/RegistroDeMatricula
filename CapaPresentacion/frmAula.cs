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
    public partial class frmAula : Form
    {
        DataSet dsAula = new DataSet();
        DataTable dtAula = new DataTable();
        public frmAula()
        {
            InitializeComponent();
        }

        private void btnCurso_CargarDatos_Click(object sender, EventArgs e)
        {
            BuscarAula();
        }

        private void frmAula_Load(object sender, EventArgs e)
        {
            CargarGridAula();
            CargarComboAula();
        }

        private void btnAula_insertar_Click(object sender, EventArgs e)
        {
            using (GestorAula elAula = new GestorAula())
            {
                elAula.InsertarAula(txtAula_Descripcion.Text, txtAula_Capacidad.Text, "A");
            }
            CargarGridAula();
            CargarComboAula();
            Limpiar();
        }
        private void CargarGridAula()
        {
            using (GestorAula elAula = new GestorAula())
            {
                dgvAula.DataSource = elAula.ListarAula();
                dgvAula.Columns["Aula_id"].Visible = false;
                dgvAula.Columns["Aula_descripcion"].HeaderText = "Descripcion";
                dgvAula.Columns["Aula_capacidad"].HeaderText = "Capacidad";
                dgvAula.Columns["Aula_estado"].Visible = false;
            }
        }
        private void CargarComboAula()
        {
            using (GestorAula elAula = new GestorAula())
            {
                cbxAula.DataSource = elAula.ListarAula();
                cbxAula.ValueMember = "Aula_id";
                cbxAula.DisplayMember = "Aula_capacidad";
            }
        }
        private void BuscarAula()
        {
            int Aula_id = int.Parse(cbxAula.SelectedValue.ToString());
            using (GestorAula elAula = new GestorAula())
            {
                this.dsAula = elAula.consultarAula(Aula_id);
                this.dtAula = this.dsAula.Tables[0];
            }
            CargarDatosAula();
        }
        private void CargarDatosAula()
        {
            txtAula_Descripcion.Text = this.dtAula.Rows[0]["Aula_descripcion"].ToString();
            txtAula_Capacidad.Text = this.dtAula.Rows[0]["Aula_capacidad"].ToString();
        }

        private void btnAula_Modificar_Click(object sender, EventArgs e)
        {
            int Aula_id = int.Parse(cbxAula.SelectedValue.ToString());
            using (GestorAula elAula = new GestorAula())
            {

                elAula.ModificarAula(Aula_id, txtAula_Descripcion.Text, txtAula_Capacidad.Text, "A");
            }
            CargarGridAula();
            CargarComboAula();
            Limpiar();
        }

        private void dgvAula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int numFila = dgvAula.CurrentCell.RowIndex;
                int Aula_id = int.Parse(this.dgvAula[0, numFila].Value.ToString());

                using (GestorAula elAula = new GestorAula())
                {
                    this.dsAula = elAula.consultarAula(Aula_id);
                    this.dtAula = this.dsAula.Tables[0];
                }
                CargarDatosAula();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacía. Ingrese datos", "Alerta",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAula_Eliminar_Click(object sender, EventArgs e)
        {
            string opcion;
            opcion = MessageBox.Show("¿Esta seguro de eliminar la informacion?", " ",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (opcion == "OK")
            {
                using (GestorAula elAula = new GestorAula())
                {
                    elAula.eliminarAula(int.Parse(cbxAula.SelectedValue.ToString()));
                }
            }
            CargarGridAula();
            CargarComboAula();
            Limpiar();
        }

        private void btnAula_Inactivar_Click(object sender, EventArgs e)
        {
            int Aula_id = int.Parse(cbxAula.SelectedValue.ToString());
            using (GestorAula elAula = new GestorAula())
            {

                elAula.ModificarAula(Aula_id, txtAula_Descripcion.Text, txtAula_Capacidad.Text, "A");
            }
            CargarGridAula();
            CargarComboAula();
            Limpiar();
        }
        private void Limpiar()
        {
            txtAula_Descripcion.Text = "";
            txtAula_Capacidad.Text = "";

        }

    }
}
