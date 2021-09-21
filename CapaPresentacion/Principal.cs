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
    public partial class Principal : Form
    {
        string Nombre;
        string Area;
        public Principal(DataTable datos)
        {
            this.Nombre = datos.Rows[0]["Usuario_nombre"].ToString();
            this.Area = datos.Rows[0]["Usuario_area"].ToString();


            InitializeComponent();
        }

        private void NodoHijo(object FormNodoHijo)
        {
            if(this.Ventana_Muestra.Controls.Count > 0)
            {
                this.Ventana_Muestra.Controls.RemoveAt(0);
               
            }
            Form fh = FormNodoHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Ventana_Muestra.Controls.Add(fh);
            this.Ventana_Muestra.Tag = fh;
            fh.Show();
        }
        private void PicBox_Profesor_Click(object sender, EventArgs e)
        {
            NodoHijo(new FrmProfesor(Area));
        }

        private void pictureBox_Estudiante_Click_1(object sender, EventArgs e)
        {
            NodoHijo(new FrmEstudiante(Area));
        }

        private void pictureBox_Curso_Click_1(object sender, EventArgs e)
        {
            NodoHijo(new frmCurso(Area));
        }

        private void pictureBox_Grupo_Click_1(object sender, EventArgs e)
        {
            NodoHijo(new frmGrupo(Area));
        }

        private void pictureBox_Aula_Click_1(object sender, EventArgs e)
        {
            NodoHijo(new frmAula(Area));
        }

        private void pictureBox_Horario_Click_1(object sender, EventArgs e)
        {
            frmHorario GesFrmHorario = new frmHorario();

            GesFrmHorario.ShowDialog();
        }

        private void pictureBox_Matricula_Click_1(object sender, EventArgs e)
        {

        }
        private void pictureBox_Reportes_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_logout_Click_1(object sender, EventArgs e)
        { 
            M_Modulos.Enabled = false;
            Ventana_Muestra.Visible = false;
            InicioSesion inse = new InicioSesion();
            inse.ShowDialog();
           
        }

        private void lblPicbox_profesor_Click(object sender, EventArgs e)
        {

        }

        private void label_Estudiante_Click(object sender, EventArgs e)
        {

        }

        private void label_Curso_Click(object sender, EventArgs e)
        {

        }

        private void label_Grupo_Click(object sender, EventArgs e)
        {

        }

        private void label_Aula_Click(object sender, EventArgs e)
        {

        }

        private void label_Horario_Click(object sender, EventArgs e)
        {

        }

        private void label_Matricula_Click(object sender, EventArgs e)
        {

        }

        private void label_Reporte_Click(object sender, EventArgs e)
        {

        }

        private void label_LogOut_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
