using System;
using System.Data;
using QLStudio_THHQT.Ultilities;
using System.Windows.Forms;
using QLStudio_THHQT.BLL;
using System.Drawing;
using System.IO;
using QLStudio_THHQT.DTO;

namespace QLStudio_THHQT.GUI
{
    public partial class frmQLHoaDon : Form
    {
        HoaDonBL HoaDonBL = new HoaDonBL();
        public frmQLHoaDon()
        {
            InitializeComponent();
        }
        public void loadGridView()
        {
            if(dataGridView1.Rows.Count != 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
            }
            DataTable t = HoaDonBL.loadDataHoaDon();
            dataGridView1.DataSource = t;
            dataGridView1.Refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddHoaDon adhd = new frmAddHoaDon();
            adhd.ShowDialog();
            loadGridView();
        }

        private void frmQLHoaDon_Load(object sender, EventArgs e)
        {
            loadGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maHD = More.getValueFromColumn("MaHD", dataGridView1);
            DialogResult t = More.ConfirmDelete(maHD);//thong báo xac nhận
            if (t == DialogResult.Yes)
            {
                More.showNotice(HoaDonBL.deleteHoaDon(maHD), "Xóa hóa đơn: " + maHD);
                loadGridView();
            }
        }

        //img buttons for datagridview
        Image img = Image.FromFile(Path.GetFullPath(@"..\..\images\info.png"));
        Image img2 = Image.FromFile(Path.GetFullPath(@"..\..\images\btn_Edit.png"));
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = img.Width / 20;
                var h = img.Height / 20;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) /2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) /2;

                e.Graphics.DrawImage(img, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)//details
            {
                string temp = More.getValueFromColumn("MAHD", dataGridView1);
                frmChiTietHoaDon f = new frmChiTietHoaDon();
                f.maHD = temp;
                f.ShowDialog();
            }
        }

        private void btn_In_Click(object sender, EventArgs e)
        {
            frmReportHoaDon f = new frmReportHoaDon();
            f.ShowDialog();
        }
    }
}
