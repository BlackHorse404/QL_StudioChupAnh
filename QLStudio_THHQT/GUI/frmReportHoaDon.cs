using System;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Windows.Forms;
using QLStudio_THHQT.GUI.Report;

namespace QLStudio_THHQT.GUI
{
    public partial class frmReportHoaDon : Form
    {
        public frmReportHoaDon()
        {
            InitializeComponent();
        }

        private void frmReportHoaDon_Load(object sender, EventArgs e)
        {
            rptHoaDon rpt = new rptHoaDon();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
