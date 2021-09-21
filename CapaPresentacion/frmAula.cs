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
        string Area;
        DataSet dsAula = new DataSet();
        DataTable dtAula = new DataTable();
        public frmAula(String Area)
        {
            this.Area = Area;
            InitializeComponent();
        }
        private void frmAula_Load(object sender, EventArgs e)
        {
            if (Area != "A1")
            {
                gpbAula_Admin.Visible = false;
            }
            Program.PropiedadesDataGried(dgvAula);
            Program.PropiedadesDataGried(dgv_admin);
            CargarGridInactivosAula();
            CargarGridAula();
            CargarComboAula();
        }

        private void btnAula_insertar_Click_1(object sender, EventArgs e)
        {
            using (GestorAula elAula = new GestorAula())
            {
                elAula.InsertarAula(txtAula_Descripcion.Text, txtAula_Capacidad.Text, "A");
            }
            CargarGridAula();
            CargarComboAula();
            Limpiar();
        }

        private void btnAula_Eliminar_Click_1(object sender, EventArgs e)
        {
            string opcion;
            int GetAulaID;
            opcion = MessageBox.Show("¿Esta seguro de eliminar la informacion?", " ",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (opcion == "OK")
            {
                using (GestorAula elAula = new GestorAula())
                {
                    if (dgvAula.CurrentCell != null && dgvAula.Rows.Count > 0)
                    {
                        int numfila = dgvAula.CurrentCell.RowIndex;
                        GetAulaID = int.Parse(dgvAula[0, numfila].Value.ToString());

                        elAula.inactivarAula(GetAulaID);
                    }
                    else if (cbxAula.SelectedValue != null)
                    {
                        elAula.inactivarAula(int.Parse(cbxAula.SelectedValue.ToString()));
                    }

                }
            }
            CargarGridAula();
            CargarComboAula();
            CargarGridInactivosAula();
            Limpiar();
        }

        private void btnAula_Modificar_Click_1(object sender, EventArgs e)
        {
            int getAulaID;
            using (GestorAula elAula = new GestorAula())
            {
                if (dgvAula.CurrentCell != null && dgvAula.Rows.Count > 0)
                {
                    int numfila = dgvAula.CurrentCell.RowIndex;
                    getAulaID = int.Parse(dgvAula[0, numfila].Value.ToString());
                    elAula.ModificarAula(getAulaID, txtAula_Descripcion.Text, txtAula_Capacidad.Text, "A");
                }
                else if (cbxAula.SelectedValue != null)
                {
                    elAula.ModificarAula(int.Parse(cbxAula.SelectedValue.ToString()), txtAula_Descripcion.Text, txtAula_Capacidad.Text, "A");
                }

            }
            CargarGridAula();
            CargarComboAula();
            Limpiar();
        }

        private void btnCurso_CargarDatos_Click_1(object sender, EventArgs e)
        {
            BuscarAula();
        }

        private void btnAdmin_Activar_Click(object sender, EventArgs e)
        {
            int getAulaID;
            using (GestorAula elAula = new GestorAula())
            {
                if (dgv_admin.CurrentCell != null && dgv_admin.Rows.Count > 0)
                {
                    int numfila = dgv_admin.CurrentCell.RowIndex;
                    getAulaID = int.Parse(dgv_admin[0, numfila].Value.ToString());

                    elAula.ActivarAula(getAulaID);

                }

            }
            CargarComboAula();
            CargarGridAula();
            CargarGridInactivosAula();
        }

        private void btnEliminar_Admin_Click(object sender, EventArgs e)
        {
            int getAulaID;
            using (GestorAula elAula = new GestorAula())
            {
                if (dgv_admin.CurrentCell != null && dgv_admin.Rows.Count > 0)
                {
                    int numfila = dgv_admin.CurrentCell.RowIndex;
                    getAulaID = int.Parse(dgv_admin[0, numfila].Value.ToString());

                    elAula.eliminarAula(getAulaID);

                }

            }
            CargarGridInactivosAula();
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
        private void CargarGridInactivosAula()
        {
            using (GestorAula elAula = new GestorAula())
            {
                dgv_admin.DataSource = elAula.ListarInactivoAula();

                dgv_admin.Columns["Aula_id"].HeaderText = "ID";
                dgv_admin.Columns["Aula_descripcion"].HeaderText = "Descripcion";
                dgv_admin.Columns["Aula_capacidad"].HeaderText = "Capacidad";
                dgv_admin.Columns["Aula_estado"].HeaderText = "Estado";

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

        private void Limpiar()
        {
            txtAula_Descripcion.Text = "";
            txtAula_Capacidad.Text = "";

        }

        private void dgvAula_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
    }
}
    

