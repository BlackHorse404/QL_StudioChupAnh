using System;
using System.Windows.Forms;
using QLStudio_THHQT.GUI;
using QLStudio_THHQT.BLL;
using QLStudio_THHQT.Ultilities;

namespace QLStudio_THHQT.GUI
{
    public partial class frmQLPhieuDangKy : Form
    {
        PhieuDangKyBL PhieuDangKyBL = new PhieuDangKyBL();
        public frmQLPhieuDangKy()
        {
            InitializeComponent();
        }
        public void loadGridView()
        {
            dataGridView1.DataSource = PhieuDangKyBL.loadDataPhieuDangKy();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void frmQLPhieuDangKy_Load(object sender, EventArgs e)
        {
            loadGridView();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddPhieuDangKy adpdk = new frmAddPhieuDangKy();
            adpdk.ShowDialog();
            loadGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string temp = More.getValueFromColumn("MADK", dataGridView1);
            DialogResult t = More.ConfirmDelete(temp);//thong báo xac nhận
            if (t == DialogResult.Yes)
            {
                More.showNotice(PhieuDangKyBL.deletePhieuDangKy(temp), "Xóa Phiếu đăng ký: " + temp);
                loadGridView();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmReportPhieuDangKy f = new frmReportPhieuDangKy();
            f.ShowDialog();
        }
    }
}
