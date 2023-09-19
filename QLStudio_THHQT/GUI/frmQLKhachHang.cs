using System;
using System.Data;
using System.Windows.Forms;
using QLStudio_THHQT.BLL;
using QLStudio_THHQT.Ultilities;
using QLStudio_THHQT.DTO;

namespace QLStudio_THHQT.GUI
{
    public partial class frmQLKhachHang : Form
    {
        KhachHangBL KhachHangBL = new KhachHangBL();
        public frmQLKhachHang()
        {
            InitializeComponent();
        }
        public void loadGridView()
        {
            DataTable t = KhachHangBL.loadDataKhachHang();
            if (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
            }
            dataGridView1.DataSource = t;

            if(t != null)
            {
                try
                {
                    txtMakh.DataBindings.Clear();
                    txtHoten.DataBindings.Clear();
                    txtGioitinh.DataBindings.Clear();
                    txtDiachi.DataBindings.Clear();
                    txtSDT.DataBindings.Clear();
                    dT_NgaySinh.DataBindings.Clear();

                    txtMakh.DataBindings.Add("text", t, "MAKH");
                    txtHoten.DataBindings.Add("text", t, "HOTEN");
                    txtGioitinh.DataBindings.Add("text", t, "GIOITINH");
                    dT_NgaySinh.DataBindings.Add("value", t, "NGAYSINH");
                    txtSDT.DataBindings.Add("text", t, "SDT");
                    txtDiachi.DataBindings.Add("text", t, "DIACHI");
                }
                catch
                {

                }
                
            }
            
        }
        private void frmQLKhachHang_Load(object sender, EventArgs e)
        {
            loadGridView();
            groupSuaTTKH.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddKhachHang adkh = new frmAddKhachHang();
            adkh.ShowDialog();
            loadGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            groupSuaTTKH.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string temp = More.getValueFromColumn("MaKH", dataGridView1);
            DialogResult t = More.ConfirmDelete(temp);//thong báo xac nhận
            if (t == DialogResult.Yes)
            {
                More.showNotice(KhachHangBL.deleteKhachHang(temp), "Xóa khách hàng: " + temp);
                loadGridView();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KhachHang dv = new KhachHang(
                txtMakh.Text,
                txtHoten.Text,
                txtGioitinh.Text,
                dT_NgaySinh.Value.Date,
                txtSDT.Text,
                txtDiachi.Text
            );
            int state = KhachHangBL.updateKhachHang(dv);
            More.showNotice(state, "Cập nhật thông tin");
            if (state != -1)
                loadGridView();
        }
    }
}
