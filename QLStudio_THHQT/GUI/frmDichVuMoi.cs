using QLStudio_THHQT.BLL;
using System.Windows.Forms;
using System;

namespace QLStudio_THHQT.GUI
{
    public partial class frmDichVuMoi : Form
    {
        public frmDichVuMoi()
        {
            InitializeComponent();
        }

        DichVuBL dv = new DichVuBL();
        private void frmDichVuMoi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dv.TopDichVuMoi();
        }
    }
}
