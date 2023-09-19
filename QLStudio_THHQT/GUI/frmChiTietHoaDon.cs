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

namespace QLStudio_THHQT.GUI
{
    public partial class frmChiTietHoaDon : Form
    {
        public string maHD { get; set; }
        public frmChiTietHoaDon()
        {
            InitializeComponent();
            
        }

        HoaDonBL hd = new HoaDonBL();

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            if(maHD != null && maHD != string.Empty)
            {
                DataTable t = hd.loadDataCTHD(maHD);
                if (t != null && t.Rows.Count != 0)
                {
                    lb_tenKH.Text = t.Rows[0]["TENKH"].ToString();
                    lb_MaHD.Text = t.Rows[0]["MAHD"].ToString();
                    lb_NgayLap.Text = DateTime.Parse(t.Rows[0]["NGAYLAPHD"].ToString()).ToString("d");
                    lb_TenNV.Text = t.Rows[0]["TENNV"].ToString();

                    foreach (DataRow r in t.Rows)
                    {
                        txt_TenDV.Text += r["TENDV"].ToString() + Environment.NewLine;
                        txt_Gia.Text += r["GIA"].ToString() + " VNĐ" + Environment.NewLine;
                    }
                }
            }
            txt_Gia.Select(0, 0);
            txt_TenDV.Select(0, 0);
        }
    }
}
