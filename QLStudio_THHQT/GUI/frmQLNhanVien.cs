using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLStudio_THHQT.BLL;
using QLStudio_THHQT.Ultilities;

namespace QLStudio_THHQT
{
    public partial class frmQLNhanVien : Form
    {
        NhanVienBL nvbl = new NhanVienBL();
        public frmQLNhanVien()
        {
            InitializeComponent();
        }

        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nvbl.loadDataNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int state = nvbl.insertNhanVien();
                More.showNotice(state, "Thêm nhân viên");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
