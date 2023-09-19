﻿using System;
using QLStudio_THHQT.BLL;
using System.Windows.Forms;

namespace QLStudio_THHQT.GUI
{
    public partial class frmFindSanPham : Form
    {
        public frmFindSanPham()
        {
            InitializeComponent();
        }

        DichVuBL dv = new DichVuBL();

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
            }
            string searchString = txt_search.Text;
            dataGridView1.DataSource = dv.searchDichVu(searchString);
        }
    }
}
