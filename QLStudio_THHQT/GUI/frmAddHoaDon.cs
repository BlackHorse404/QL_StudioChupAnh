using System;
using System.Windows.Forms;
using QLStudio_THHQT.BLL;
using QLStudio_THHQT.DTO;
using QLStudio_THHQT.Ultilities;


namespace QLStudio_THHQT.GUI
{
    public partial class frmAddHoaDon : Form
    {
        HoaDonBL HoaDonBL = new HoaDonBL();
        public frmAddHoaDon()
        {
            InitializeComponent();
        }

        public void loadcmbNhanVien()
        {
            NhanVienBL nhanVienBL = new NhanVienBL();
            cmbNhanvien.DataSource = nhanVienBL.loadDataNhanVien();
            cmbNhanvien.DisplayMember = "HOTEN";
            cmbNhanvien.ValueMember = "MANV";
        }
        public void loadcmbDichVu()
        {
            DichVuBL dichVuBL = new DichVuBL();
            cmbDichvu.DataSource = dichVuBL.loadDataDichVu();
            cmbDichvu.DisplayMember = "TENDV";
            cmbDichvu.ValueMember = "MADV";
        }
        public void loadcmbKhachHang()
        {
            KhachHangBL khachHangBL = new KhachHangBL();
            cmbKhachHang.DataSource = khachHangBL.loadDataKhachHang();
            cmbKhachHang.DisplayMember = "HOTEN";
            cmbKhachHang.ValueMember = "MAKH";
        }
        private void frmAddHoaDon_Load(object sender, EventArgs e)
        {
            loadcmbDichVu();
            loadcmbKhachHang();
            loadcmbNhanVien();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon(txtMahd.Text, dateTimePicker1.Value, cmbNhanvien.SelectedValue.ToString());
            int i = HoaDonBL.insertHoaDon(hd, cmbKhachHang.SelectedValue.ToString(), cmbDichvu.SelectedValue.ToString());
            More.showNotice(i, "Thêm Hóa Đơn");
        }
    }
}
