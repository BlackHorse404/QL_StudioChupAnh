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
using QLStudio_THHQT.DTO;

namespace QLStudio_THHQT.GUI
{
    public partial class frmAddDichVu : Form
    {
        DichVuBL DichVuBL = new DichVuBL();
        public frmAddDichVu()
        {
            InitializeComponent();
        }

        //btn hủy
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //btn thêm
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DichVu dv = new DichVu(txtMadv.Text, txtTendv.Text, txtMota.Text, (float)Convert.ToInt32(txtGia.Text));
                int i = DichVuBL.insertDichVu(dv);
                if (i != -1)
                {
                    MessageBox.Show("Thêm Thành Công!");
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex != null ? ex.Message : "Lỗi !");
            }
        }

        private void frmAddDichVu_Load(object sender, EventArgs e)
        {
            txtMadv.Text = DichVuBL.getMaTuDong();
        }
    }
}
