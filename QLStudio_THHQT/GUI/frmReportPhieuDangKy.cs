using System;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Windows.Forms;
using QLStudio_THHQT.GUI.Report;

namespace QLStudio_THHQT.GUI
{
    public partial class frmReportPhieuDangKy : Form
    {
        public frmReportPhieuDangKy()
        {
            InitializeComponent();
        }

        private void frmReportPhieuDangKy_Load(object sender, EventArgs e)
        {
            rptPhieuDangKy rpt = new rptPhieuDangKy();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
