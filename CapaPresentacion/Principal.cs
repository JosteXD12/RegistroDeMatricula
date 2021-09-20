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
        public Principal()
        {
            InitializeComponent();
        }

        private void gestorToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmEstudiante GesFrmEstudiante = new FrmEstudiante();

            GesFrmEstudiante.ShowDialog();
        }

        private void gestorProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfesor GesFrmprofesor = new FrmProfesor();

            GesFrmprofesor.ShowDialog();
        }

        private void gestorToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void aulaAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAula GesFrmAula = new frmAula();

                        GesFrmAula.ShowDialog();
        }

        private void gestorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHorario GesFrmHorario = new frmHorario();

            GesFrmHorario.ShowDialog();
        }

        private void gestorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmGrupo GesFrmGrupo = new frmGrupo();

            GesFrmGrupo.ShowDialog();
        }

        private void gestorCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCurso GesFrmCurso = new frmCurso();

            GesFrmCurso.ShowDialog();
        }
    }
}
