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
    public partial class frmGrupo : Form
    {
        string Area;
        DataSet dsGrupo = new DataSet();
        DataTable dtGrupo = new DataTable();
        public frmGrupo(string Area)
        {
            this.Area = Area;
            InitializeComponent();
        }

        private void frmGrupo_Load(object sender, EventArgs e)
        {
            if (Area != "A1")
            {
                gpbGrupo_Admin.Visible = false;
            }
            Program.PropiedadesDataGried(dgvGrupo);
            Program.PropiedadesDataGried(dgv_admin);
            CargarGridInactivosGrupo();
            CargarGridGrupo();
            CargarComboGrupo();

        }

        private void btnGrupo_Insertar_Click_1(object sender, EventArgs e)
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                elGrupo.InsertarGrupo(txtGrupo_Descripcion.Text, "A");
            }
            CargarGridGrupo();
            CargarComboGrupo();
            Limpiar();
        }

        private void btnGrupo_modificar_Click_1(object sender, EventArgs e)
        {

            int getGrupoID;
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                if (dgvGrupo.CurrentCell != null && dgvGrupo.Rows.Count > 0)
                {
                    int numfila = dgvGrupo.CurrentCell.RowIndex;
                    getGrupoID = int.Parse(dgvGrupo[0, numfila].Value.ToString());
                    elGrupo.ModificarGrupo(getGrupoID, txtGrupo_Descripcion.Text, "A");
                }
                else if (cbxGrupo.SelectedValue != null)
                {
                    elGrupo.ModificarGrupo(int.Parse(cbxGrupo.SelectedValue.ToString()), txtGrupo_Descripcion.Text, "A");
                }

            }
            CargarGridGrupo();
            CargarComboGrupo();
            Limpiar();
        }

        private void btnGrupo_eliminar_Click(object sender, EventArgs e)
        {
            string opcion;
            int getGrupoID;
            opcion = MessageBox.Show("¿Esta seguro de eliminar la informacion?", " ",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (opcion == "OK")
            {
                using (GestorGrupo elGrupo = new GestorGrupo())
                {
                    if (dgvGrupo.CurrentCell != null && dgvGrupo.Rows.Count > 0)
                    {
                        int numfila = dgvGrupo.CurrentCell.RowIndex;
                        getGrupoID = int.Parse(dgvGrupo[0, numfila].Value.ToString());

                        elGrupo.inactivarGrupo(getGrupoID);

                    }
                    else if (cbxGrupo.SelectedValue != null)
                    {
                        elGrupo.inactivarGrupo(int.Parse(cbxGrupo.SelectedValue.ToString()));
                    }
                }
            }
            CargarGridGrupo();
            CargarComboGrupo();
            CargarGridInactivosGrupo();
            Limpiar();
        }

        private void btnAdmin_Activar_Click(object sender, EventArgs e)
        {
            int getGrupID;
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                if (dgv_admin.CurrentCell != null && dgv_admin.Rows.Count > 0)
                {
                    int numfila = dgv_admin.CurrentCell.RowIndex;
                    getGrupID = int.Parse(dgv_admin[0, numfila].Value.ToString());

                    elGrupo.ActivarGrupo(getGrupID);

                }

            }
            CargarComboGrupo();
            CargarGridGrupo();
            CargarGridInactivosGrupo();
        }

        private void btnEliminar_Admin_Click(object sender, EventArgs e)
        {
            int GrupoID;
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                if (dgv_admin.CurrentCell != null && dgv_admin.Rows.Count > 0)
                {
                    int numfila = dgv_admin.CurrentCell.RowIndex;
                    GrupoID = int.Parse(dgv_admin[0, numfila].Value.ToString());

                    elGrupo.eliminarGrupo(GrupoID);

                }

            }
            CargarGridInactivosGrupo();
        }

        private void btnGrupo_CargarDatos_Click_1(object sender, EventArgs e)
        {
            BuscarGrupo();
        }
        private void CargarGridGrupo()
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                dgvGrupo.DataSource = elGrupo.ListarGrupo();

                dgvGrupo.Columns["Grupo_id"].Visible = false;
                dgvGrupo.Columns["Grupo_descripcion"].HeaderText = "Descripccíon";
                dgvGrupo.Columns["Grupo_estado"].Visible = false;
            }

        }
        private void CargarGridInactivosGrupo()
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                dgv_admin.DataSource = elGrupo.ListarInactivoGrupo();

                dgv_admin.Columns["Grupo_id"].HeaderText = "ID";
                dgv_admin.Columns["Grupo_descripcion"].HeaderText = "Descripcion";
                dgv_admin.Columns["Grupo_estado"].HeaderText = "Estado";

            }

        }
        private void CargarComboGrupo()
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                cbxGrupo.DataSource = elGrupo.ListarGrupo();
                cbxGrupo.ValueMember = "Grupo_id";
                cbxGrupo.DisplayMember = "Grupo_descripcion";
            }
        }
        private void BuscarGrupo()
        {
            int Grupo_id = int.Parse(cbxGrupo.SelectedValue.ToString());

            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                this.dsGrupo = elGrupo.ConsultarGrupo(Grupo_id);
                this.dtGrupo = this.dsGrupo.Tables[0];
            }
            CargarDatosGrupo();

        }
        private void CargarDatosGrupo()
        {
            txtGrupo_Descripcion.Text = this.dtGrupo.Rows[0]["Grupo_descripcion"].ToString();

        }

        private void dgvGrupo_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int numFila = dgvGrupo.CurrentCell.RowIndex;
                int Grupo_id = int.Parse(this.dgvGrupo[0, numFila].Value.ToString());

                using (GestorGrupo elGrupo = new GestorGrupo())
                {
                    this.dsGrupo = elGrupo.ConsultarGrupo(Grupo_id);
                    this.dtGrupo = this.dsGrupo.Tables[0];
                }
                CargarDatosGrupo();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacía. Ingrese datos", "Alerta",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            }
        }
        private void Limpiar()
        {
            txtGrupo_Descripcion.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
