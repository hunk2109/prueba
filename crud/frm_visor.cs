using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud
{
    public partial class frm_visor : Form
    {
        public frm_visor(string nombre_reporte)
        {
            try {
                InitializeComponent();
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(nombre_reporte);
                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_visor_Load(object sender, EventArgs e)
        {

        }
    }
}
