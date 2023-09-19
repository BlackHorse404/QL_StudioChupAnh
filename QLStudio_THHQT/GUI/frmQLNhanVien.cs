using System;
using System.Data;
using System.Windows.Forms;
using QLStudio_THHQT.BLL;
using QLStudio_THHQT.Ultilities;
using QLStudio_THHQT.DTO;

namespace QLStudio_THHQT.GUI
{
    public partial class frmQLNhanVien : Form
    {
        NhanVienBL nvbl = new NhanVienBL();
        public frmQLNhanVien()
        {
            InitializeComponent();
        }

        public void loadGridView()
        {
            DataTable t = nvbl.loadDataNhanVien();
            if (More.flag)
            {
                this.DestroyHandle();
                return;
            }
            cbBMaql.DataSource = t;
            cbBMaql.DisplayMember = "MANV";
            cbBMaql.ValueMember = "MANV";

            if (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
            }
            dataGridView1.DataSource = t;
            if(t != null)
            {
                txtManv.DataBindings.Clear();
                txtChucvu.DataBindings.Clear();
                txtDiaChi.DataBindings.Clear();
                txtGioitinh.DataBindings.Clear();
                txtHoten.DataBindings.Clear();
                txtSDT.DataBindings.Clear();
                dT_ns.DataBindings.Clear();

                txtManv.DataBindings.Add("text", t, "MANV");
                txtChucvu.DataBindings.Add("text", t, "CHUCVU");
                txtDiaChi.DataBindings.Add("text", t, "DIACHI");
                txtGioitinh.DataBindings.Add("text", t, "GIOITINH");
                txtHoten.DataBindings.Add("text", t, "HOTEN");
                txtSDT.DataBindings.Add("text", t, "SDT");
            }
            
            try
            {
                dT_ns.DataBindings.Add("value", t, "NGAYSINH");
            }
            catch
            {}
            
        }
        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            loadGridView();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddNhanVien f = new frmAddNhanVien();
            f.ShowDialog();
            loadGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNV = More.getValueFromColumn("MaNV", dataGridView1);
            DialogResult t = More.ConfirmDelete(maNV);//thong báo xac nhận
            if (t == DialogResult.Yes)
            {
                More.showNotice(nvbl.deleteNhanVien(maNV), "Xóa nhân viên: " + maNV);
                loadGridView();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btn_luu.Enabled = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien(
                txtManv.Text,
                txtHoten.Text,
                txtSDT.Text,
                txtDiaChi.Text,
                txtGioitinh.Text,
                txtChucvu.Text,
                cbBMaql.SelectedValue.ToString(),
                DateTime.Parse(dT_ns.Value.ToString())
            );
            int state = nvbl.updateNhanVien(nv);
            More.showNotice(state, "Cập nhật nhân viên");
            if (state != -1)
                loadGridView();
        }
    }
}
