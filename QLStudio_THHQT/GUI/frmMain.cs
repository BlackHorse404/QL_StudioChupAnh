using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using QLStudio_THHQT.Ultilities;
using System.Windows.Forms;
using QLStudio_THHQT.DAL;

namespace QLStudio_THHQT.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void qLDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLDichVu f = new frmQLDichVu();
            f.MdiParent = this;
            f.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLHoaDon f = new frmQLHoaDon();
            f.MdiParent = this;
            f.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLKhachHang f = new frmQLKhachHang();
            f.MdiParent = this;
            f.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLNhanVien f = new frmQLNhanVien();
            f.MdiParent = this;
            try { 
                f.Show();
            }
            catch { }
            if(More.flag)
            {
                f.Close();
                More.flag = false;
            }
        }

        private void phiếuĐăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLPhieuDangKy f = new frmQLPhieuDangKy();
            f.MdiParent = this;
            f.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //change background MdiContainer
            foreach (Control control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = Color.White;
                    break;
                }
            }
        }

        private void tạoTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegister f = new frmRegister();
            f.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformation f = new frmInformation();
            f.MdiParent = this;
            f.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFindSanPham f = new frmFindSanPham();
            f.MdiParent = this;
            f.Show();
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFindNhanVien f = new frmFindNhanVien();
            f.MdiParent = this;
            f.Show();
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFindKhachHang f = new frmFindKhachHang();
            f.MdiParent = this;
            f.Show();
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFindHoaDon f = new frmFindHoaDon();
            f.MdiParent = this;
            f.Show();
        }

        private void dịchVụMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDichVuMoi f = new frmDichVuMoi();
            f.MdiParent = this;
            f.Show();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLQuyenUser f = new frmQLQuyenUser();
            f.ShowDialog();
        }

        private void nhậpXuấtDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExportData f = new frmExportData();
            f.ShowDialog();
        }

        private void saoLưuCSDLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaoLuu_PhucHoi f = new SaoLuu_PhucHoi();
            f.ShowDialog();
        }
    }
}
