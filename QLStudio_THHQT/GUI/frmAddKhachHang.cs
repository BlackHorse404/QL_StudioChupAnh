using System;
using System.Windows.Forms;
using QLStudio_THHQT.BLL;
using QLStudio_THHQT.Ultilities;
using QLStudio_THHQT.DTO;

namespace QLStudio_THHQT.GUI
{
    public partial class frmAddKhachHang : Form
    {
        KhachHangBL KhachHangBL = new KhachHangBL();
        public frmAddKhachHang()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang kh = new KhachHang(txtMakh.Text, txtHoten.Text, txtGioitinh.Text, dateTimePicker1.Value, txtSDT.Text, txtDiachi.Text);
                int i = KhachHangBL.insertKhachHang(kh);
                More.showNotice(i, "Thêm Thông Tin Khách Hàng");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex != null ? ex.Message : "Lỗi !");
            }
        }
    }
}
