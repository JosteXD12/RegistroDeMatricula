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
        string Area;
        DataSet dsHorario = new DataSet();
        DataTable dtHorario = new DataTable();
        public frmHorario(string Area)
        {
            this.Area = Area;
            InitializeComponent();
        }
        private void Horario_Load(object sender, EventArgs e)
        {
            if (Area != "A1")
            {
                gpbHorario_Admin.Visible = false;
            }
            Program.PropiedadesDataGried(dgv_admin);
            Program.PropiedadesDataGried(dgvHorario);
            CargarGridHorario();
            CargarComboHorario();
            CargarGridInactivosHorario();
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
            Limpiar();
        }

        private void Eliminar_Horario_Click(object sender, EventArgs e)
        {
            string opcion;
            int getHorarioID;
            opcion = MessageBox.Show("¿Esta seguro de eliminar la informacion?", " ",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (opcion == "OK")
            {
                using (GestorHorario elHorario = new GestorHorario())
                {
                    if (dgvHorario.CurrentCell != null && dgvHorario.Rows.Count > 0)
                    {
                        int numfila = dgvHorario.CurrentCell.RowIndex;
                        getHorarioID = int.Parse(dgvHorario[0, numfila].Value.ToString());

                        elHorario.inactivarHorario(getHorarioID);

                    }
                    else if (cbxHorario.SelectedValue != null)
                    {
                        elHorario.inactivarHorario(int.Parse(cbxHorario.SelectedValue.ToString()));
                    }
                }
            }
            CargarGridHorario();
            CargarComboHorario();
            CargarGridInactivosHorario();
            Limpiar();
        }

        private void btnHorario_modificar_Click(object sender, EventArgs e)
        {
            int getHorarioID;
            using (GestorHorario elHorario = new GestorHorario())
            {
                if (dgvHorario.CurrentCell != null && dgvHorario.Rows.Count > 0)
                {
                    int numfila = dgvHorario.CurrentCell.RowIndex;
                    getHorarioID = int.Parse(dgvHorario[0, numfila].Value.ToString());
                    elHorario.ModificarHorario(getHorarioID, txtHorario_Descripccion.Text, txtHorario_Dia.Text,
                    txtHorario_HoraInicio.Text, txtHorario_horaFinalizacion.Text, "A");
                }
                else if (cbxHorario.SelectedValue != null)
                {
                    elHorario.ModificarHorario(int.Parse(cbxHorario.SelectedValue.ToString()), txtHorario_Descripccion.Text, txtHorario_Dia.Text,
                    txtHorario_HoraInicio.Text, txtHorario_horaFinalizacion.Text, "A");
                }

            }
            CargarGridHorario();
            CargarComboHorario();
            Limpiar();
        }

        private void btnHorario_CargarDatos_Click(object sender, EventArgs e)
        {
            BuscarHorario();
        }

        private void btnAdmin_Activar_Click(object sender, EventArgs e)
        {
            int getHorarioID;
            using (GestorHorario elHorario = new GestorHorario())
            {
                if (dgv_admin.CurrentCell != null && dgv_admin.Rows.Count > 0)
                {
                    int numfila = dgv_admin.CurrentCell.RowIndex;
                    getHorarioID = int.Parse(dgv_admin[0, numfila].Value.ToString());

                    elHorario.ActivarHorario(getHorarioID);

                }

            }
            CargarComboHorario();
            CargarGridHorario();
            CargarGridInactivosHorario();
        }

        private void btnEliminar_Admin_Click(object sender, EventArgs e)
        {
            int getHorarioID;
            using (GestorHorario elHorario = new GestorHorario())
            {
                if (dgv_admin.CurrentCell != null && dgv_admin.Rows.Count > 0)
                {
                    int numfila = dgv_admin.CurrentCell.RowIndex;
                    getHorarioID = int.Parse(dgv_admin[0, numfila].Value.ToString());

                    elHorario.eliminarHorario(getHorarioID);

                }

            }
            CargarGridInactivosHorario();
        }
        private void CargarGridHorario()
        {
            using (GestorHorario elHorario = new GestorHorario())
            {
                dgvHorario.DataSource = elHorario.ListarHorario();
                dgvHorario.Columns["Horario_id"].Visible = false;
                dgvHorario.Columns["Horario_descripcion"].HeaderText = "Descripcíon";
                dgvHorario.Columns["Horario_dia"].HeaderText = "Dia";
                dgvHorario.Columns["Horario_horaInicio"].HeaderText = "inicio";
                dgvHorario.Columns["Horario_horaFin"].HeaderText = "Finalizacion";
                dgvHorario.Columns["Horario_estado"].Visible = false;
            }
        }
        private void CargarGridInactivosHorario()
        {
            using (GestorHorario elHorario = new GestorHorario())
            {
                dgv_admin.DataSource = elHorario.ListarInactivoHorario();
                dgv_admin.Columns["Horario_id"].HeaderText = "ID";
                dgv_admin.Columns["Horario_descripcion"].HeaderText = "Descripcíon";
                dgv_admin.Columns["Horario_dia"].HeaderText = "Dia";
                dgv_admin.Columns["Horario_horaInicio"].HeaderText = "inicio";
                dgv_admin.Columns["Horario_horaFin"].HeaderText = "Finalizacion";
                dgv_admin.Columns["Horario_estado"].HeaderText = "Estado";
            }

        }
        private void CargarComboHorario()
        {
            using (GestorHorario elHorario = new GestorHorario())
            {
                cbxHorario.DataSource = elHorario.ListarHorario();
                cbxHorario.ValueMember = "Horario_id";
                cbxHorario.DisplayMember = "Horario_dia";
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
            txtHorario_Dia.Text = this.dtHorario.Rows[0]["Horario_dia"].ToString();
            txtHorario_HoraInicio.Text = this.dtHorario.Rows[0]["Horario_horaInicio"].ToString();
            txtHorario_horaFinalizacion.Text = this.dtHorario.Rows[0]["Horario_horaFin"].ToString();
        }
        private void Limpiar()
        {
            txtHorario_Descripccion.Text = "";
            txtHorario_Dia.Text = "";
            txtHorario_HoraInicio.Text = "";
            txtHorario_horaFinalizacion.Text = "";
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
                CargarComboHorario();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacía. Ingrese datos", "Alerta",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            }

        }
        private void txtHorario_Descripccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.verficacionLetras(e);
        }

        private void txtHorario_Dia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.verficacionNumero(e);
        }


    }
}
