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
    public partial class frmHorario : Form
    {
        DataSet dsHorario = new DataSet();
        DataTable dtHorario = new DataTable();
        public frmHorario()
        {
            InitializeComponent();
        }

        private void frmHorario_Load(object sender, EventArgs e)
        {
            CargarGridHorario();
            CargarComboHorario();
        }

        private void btnHorario_insertar_Click(object sender, EventArgs e)
        {
            using (GestorHorario elHorario = new GestorHorario())
            {
                elHorario.InsertarHorario(txtHorario_Descripccion.Text, txtHorario_Dia.Text,
                    txtHorario_HoraInicio.Text, txtHorario_horaFinalizacion.Text, "A");
            }
            CargarGridHorario();
            CargarComboHorario();
        }
        private void CargarGridHorario()
        {
            using (GestorHorario elHorario = new GestorHorario())
            {
                dgvHorario.DataSource = elHorario.ListarHorario();
                dgvHorario.Columns["Horario_id"].Visible = false;
                dgvHorario.Columns["Horario_descripcion"].HeaderText = "Descripcíon";
                dgvHorario.Columns["Horario_dia"].HeaderText = "Dia";
                dgvHorario.Columns["Horario_horaInicio"].HeaderText = "Hora inicio";
                dgvHorario.Columns["Horario_horaFin"].HeaderText = "Hora Finalizacion";
                dgvHorario.Columns["Horario_estado"].Visible = false;
            }
        }
        private void CargarComboHorario()
        {
            using (GestorHorario elHorario = new GestorHorario())
            {
                cbxHorario.DataSource = elHorario.ListarHorario();
                cbxHorario.ValueMember = "Horario_id";
                cbxHorario.DisplayMember = "Horarario_dia";
            }
        }
        private void BuscarHorario()
        {
            int Horario_id = int.Parse(cbxHorario.SelectedValue.ToString());
            using (GestorHorario elHorario = new GestorHorario())
            {
                this.dsHorario = elHorario.ConsultarHorario(Horario_id);
                this.dtHorario = this.dsHorario.Tables[0];
            }
            CargarDatosHorario();
        }
        private void CargarDatosHorario()
        {
            txtHorario_Descripccion.Text = this.dtHorario.Rows[0]["Horario_descripcion"].ToString();
            txtHorario_Dia.Text = this.dtHorario.Rows[0]["Horarario_dia"].ToString();
            txtHorario_HoraInicio.Text = this.dtHorario.Rows[0]["Horario_horaInicio"].ToString();
            txtHorario_horaFinalizacion.Text = this.dtHorario.Rows[0]["Horario_horaFin"].ToString();
        }

        private void btnHorario_CargarDatos_Click(object sender, EventArgs e)
        {
            BuscarHorario();
        }
        private void btnHorario_modificar_Click(object sender, EventArgs e)
        {
            int Horario_id = int.Parse(cbxHorario.SelectedValue.ToString());
            using (GestorHorario elHorario = new GestorHorario())
            {

                elHorario.ModificarHorario(Horario_id, txtHorario_Descripccion.Text, txtHorario_Dia.Text,
                    txtHorario_HoraInicio.Text, txtHorario_horaFinalizacion.Text, "A");
            }
            CargarGridHorario();
            CargarComboHorario();
        }

        private void dgvHorario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int numFila = dgvHorario.CurrentCell.RowIndex;
                int Horario_id = int.Parse(this.dgvHorario[0, numFila].Value.ToString());

                using (GestorHorario elHorario = new GestorHorario())
                {
                    this.dsHorario = elHorario.ConsultarHorario(Horario_id);
                    this.dtHorario = this.dsHorario.Tables[0];
                }
                CargarDatosHorario();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacía. Ingrese datos", "Alerta",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            }
        }
    }
}
