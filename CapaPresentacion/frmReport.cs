using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace CapaPresentacion
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }


        private void frmReport_Load(object sender, EventArgs e)
        {

        }

        private void btn_profeosr_Click(object sender, EventArgs e)
        {
            ReportDocument miReport = new ReportDocument();
            miReport.Load(@"..\..\cvrProfesor.rpt");
            crvReportes.ReportSource = miReport;
        }

        private void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            ReportDocument miReport = new ReportDocument();
            miReport.Load(@"..\..\BuscarEstudiante.rpt");
            miReport.SetParameterValue("@Estudiante_nombre", textBuscar.Text);
            crvReportes.ReportSource = miReport;
        }

    }
}
