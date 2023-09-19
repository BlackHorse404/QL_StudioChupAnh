using QLStudio_THHQT.BLL;
using System;
using System.Windows.Forms;
using QLStudio_THHQT.DTO;
using QLStudio_THHQT.Ultilities;

namespace QLStudio_THHQT.GUI
{
    public partial class frmAddPhieuDangKy : Form
    {
        PhieuDangKyBL pdkBL = new PhieuDangKyBL();
        public frmAddPhieuDangKy()
        {
            InitializeComponent();
        }

        public void loadcmbDichVu()
        {
            DichVuBL dichVuBL = new DichVuBL();
            cmbDichvu.DataSource = dichVuBL.loadDataDichVu();
            cmbDichvu.DisplayMember = "TENDV";
            cmbDichvu.ValueMember = "MADV";
        }
        //them phieu dang ky
        private void button1_Click(object sender, EventArgs e)
        {
            KhachHangBL khBL = new KhachHangBL();
            string maDV = cmbDichvu.SelectedValue.ToString();
            string maKH = khBL.findMaKHFromName(txt_TenKH.Text);
            if(maKH == string.Empty)//sinh mã tự động khi khách hàng là khách mới
            {
                int count = khBL.countKhachHang() + 1;
                maKH = "KH" + DateTime.Now.ToString("yy") + count.ToString("000000");
                frmAddKhachHang f = new frmAddKhachHang();
                f.txtMakh.Text = maKH;
                f.txtHoten.Text = txt_TenKH.Text;
                f.ShowDialog();
            }

            PhieuDangKy pdk = new PhieuDangKy(txtMadk.Text, dT_NgayDK.Value.Date, txt_TenKH.Text, txt_note.Text, maDV);
            int state = pdkBL.insertPhieuDangKy(pdk, maKH, maDV);
            More.showNotice(state, "Đăng Ký");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddPhieuDangKy_Load(object sender, EventArgs e)
        {
            loadcmbDichVu();
        }
    }
}
