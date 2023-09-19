using System;
using System.Windows.Forms;
using QLStudio_THHQT.BLL;
using QLStudio_THHQT.Ultilities;
using QLStudio_THHQT.DAL;

namespace QLStudio_THHQT.GUI
{
    public partial class SaoLuu_PhucHoi : Form
    {
        public SaoLuu_PhucHoi()
        {
            InitializeComponent();
        }

        DBSystemBL db = new DBSystemBL();

        private void btn_SaoLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog file = new SaveFileDialog();
                file.InitialDirectory = @"C:\";
                file.RestoreDirectory = true;
                file.Title = "Browse save backup file as";
                file.DefaultExt = "bak";
                file.CheckPathExists = true;
                file.FilterIndex = 2;
                file.AddExtension = false;
                file.CreatePrompt = false;
                if (file.ShowDialog() == DialogResult.OK)
                {
                    string path = file.FileName;
                    //MessageBox.Show(path);
                    More.showNotice(db.backupDB(path),"Sao Lưu");
                }
            }
            catch { }
        }

        private void btn_PhucHoiCSDL_Click(object sender, EventArgs e)
        {
            if(!(DBconfig.username.Equals("sa") && DBconfig.DBname.Equals("master")))
            {
                More.showMessageError("Vui lòng đăng nhập quyền system admin và sử dụng Database Name là Master  khi phục hồi !");
            }
            else
            {
                try
                {
                    OpenFileDialog openFile = new OpenFileDialog();
                    openFile.ShowDialog();
                    openFile.RestoreDirectory = true;
                    openFile.Title = "Browse backup full File - BAK";
                    string path = openFile.FileName;
                    //MessageBox.Show(path);
                    if(path != string.Empty && path != null)
                    {
                        More.showNotice(db.restoreDB(path), "Phục Hồi");
                    }
                }
                catch
                {

                }
                
            }
        }
    }
}
