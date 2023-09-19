using System;
using System.IO;
using QLStudio_THHQT.BLL;
using QLStudio_THHQT.Ultilities;
using System.Windows.Forms;

namespace QLStudio_THHQT.GUI
{
    public partial class frmExportData : Form
    {
        public frmExportData()
        {
            InitializeComponent();
        }

        ImportExportData ie = new ImportExportData();

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_path.Text = openFileDialog1.FileName;
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\";      
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.FileName = cb_Table.SelectedItem.ToString() + "_DataExport";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_path.Text = saveFileDialog1.FileName;
                    int state = ie.exportData(cb_Table.SelectedItem.ToString(), saveFileDialog1.FileName);
                if (state == 1)
                    More.showNotice(state, "Xuất Xong Dữ Liệu Ra Đường Dẫn: " + txt_path.Text);
            }

        }

        private void frmExportData_Load(object sender, EventArgs e)
        {
            cb_Table.Items.Add("HOADON");
            cb_Table.Items.Add("DICHVU");
            cb_Table.Items.Add("NHANVIEN");
            cb_Table.Items.Add("KHACHHANG");
            cb_Table.Items.Add("PHIEUDANGKY");

            btn_browse.Enabled = false;
            btn_NhapData.Text = "Mở Khóa Nhập File";

            cb_Table.SelectedIndex = 0;
        }

        private void btn_NhapData_Click(object sender, EventArgs e)
        {
            if(btn_browse.Enabled == true && txt_path.Text != string.Empty)
            {
                int state = ie.importData(cb_Table.SelectedItem.ToString(), txt_path.Text);
                More.showNotice(state, "Nhập Dữ Liệu Từ File !");
            }
            else
            {
                btn_NhapData.Text = "Nhập Dữ Liệu File";
                btn_browse.Enabled = true;
            }
        }
    }
}
