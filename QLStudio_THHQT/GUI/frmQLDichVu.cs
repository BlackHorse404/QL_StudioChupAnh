using System;
using System.Windows.Forms;
using QLStudio_THHQT.BLL;
using QLStudio_THHQT.Ultilities;
using QLStudio_THHQT.DTO;
using System.Data;
namespace QLStudio_THHQT.GUI
{
    public partial class frmQLDichVu : Form
    {
        DichVuBL dichVuBL = new DichVuBL();
        public frmQLDichVu()
        {
            InitializeComponent();
        }
        public void loadGirdView()
        {
            DataTable t = dichVuBL.loadDataDichVu();
            if (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
            }
            dataGridView1.DataSource = t;
            if(t != null)
            {
                txtMadv.DataBindings.Clear();
                txtMota.DataBindings.Clear();
                txtTendv.DataBindings.Clear();
                txtGia.DataBindings.Clear();
                try
                {
                    txtGia.DataBindings.Add("text", t, "GIA");
                    txtMadv.DataBindings.Add("text", t, "MADV");
                    txtTendv.DataBindings.Add("text", t, "TENDV");
                    txtMota.DataBindings.Add("text", t, "Mota");
                }
                catch { }
            }
        }

        private void frmQLDichVu_Load(object sender, EventArgs e)
        {
            loadGirdView();
            groupBoxSuaThongTin.Enabled = false;
            btn_Save.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddDichVu addv = new frmAddDichVu();
            addv.ShowDialog();
            loadGirdView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maDV = More.getValueFromColumn("MaDV", dataGridView1);
            DialogResult t = More.ConfirmDelete(maDV);//thong báo xac nhận
            if (t == DialogResult.Yes)
            {
                More.showNotice(dichVuBL.deleteDichVu(maDV), "Xóa dịch Vụ: "+maDV);
                loadGirdView();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            groupBoxSuaThongTin.Enabled = true;
            btn_Save.Enabled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            DichVu dv = new DichVu(txtMadv.Text, txtTendv.Text, txtMota.Text, float.Parse(txtGia.Text));
            int state = dichVuBL.updateDichVu(dv);
            More.showNotice(state, "Cập nhật dịch vụ");
            if(state != -1) 
                loadGirdView();
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            More.checkKeyPressIsNum(e);
        }
    }
}
