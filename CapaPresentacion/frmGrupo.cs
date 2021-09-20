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
        DataSet dsGrupo = new DataSet();
        DataTable dtGrupo = new DataTable();
        public frmGrupo()
        {
            InitializeComponent();
        }

        private void frmGrupo_Load(object sender, EventArgs e)
        {
            Program.PropiedadesDataGried(dgvGrupo);
            CargarGridGrupo();
            CargarComboGrupo();

        }

        private void btnGrupo_Insertar_Click(object sender, EventArgs e)
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                elGrupo.InsertarGrupo(txtGrupo_Descripcion.Text, "A");
            }
            CargarGridGrupo();
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


        private void btnGrupo_modificar_Click(object sender, EventArgs e)
        {
            int Grupo_id = int.Parse(cbxGrupo.SelectedValue.ToString());
            Console.WriteLine(Grupo_id +"Esto esta aqui");
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                elGrupo.ModificarGrupo(Grupo_id,txtGrupo_Descripcion.Text,"A");
            }
            CargarGridGrupo();
            CargarComboGrupo();
        }

        private void btnGrupo_CargarDatos_Click(object sender, EventArgs e)
        {
            BuscarGrupo();
        }

        private void dgvGrupo_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void cbxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
