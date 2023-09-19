using System;
using QLStudio_THHQT.Ultilities;
using System.Windows.Forms;
using QLStudio_THHQT.BLL;
using QLStudio_THHQT.DTO;

namespace QLStudio_THHQT.GUI
{
    public partial class frmAddNhanVien : Form
    {
        NhanVienBL nhanVienBL = new NhanVienBL();
        public frmAddNhanVien()
        {
            InitializeComponent();
        }
        public void loadcbBMaql()
        {
            
            cbBMaql.DataSource = nhanVienBL.loadDataNhanVien();
            cbBMaql.DisplayMember = "TENNV";
            cbBMaql.ValueMember = "MANV";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nv = new NhanVien(txtManv.Text, txtHoten.Text, txtSDT.Text, txtDiaChi.Text,
                    txtGioitinh.Text, txtChucvu.Text, cbBMaql.SelectedValue.ToString(), dateTimePicker1.Value);
                int i = nhanVienBL.insertNhanVien(nv);
                More.showNotice(i, "Thêm Nhân Viên");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex != null ? ex.Message : "Lỗi !");
            }
        }

        private void frmAddNhanVien_Load(object sender, EventArgs e)
        {
            loadcbBMaql();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
