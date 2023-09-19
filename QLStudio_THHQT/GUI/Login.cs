using System;
using System.Windows.Forms;
using QLStudio_THHQT.DAL;
using System.Data.SqlClient;
using QLStudio_THHQT.Ultilities;

namespace QLStudio_THHQT.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = btn_login;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_pass.Text.Length == 0 && txt_username.Text.Length == 0)
            {
                txt_username_Leave(txt_username, e);
                txt_pass_Leave(txt_pass, e);
                return;
            }
            if (chk_master.Checked)
                DBconfig.DBname = "master";
            DBconfig.username = txt_username.Text;
            DBconfig.password = txt_pass.Text;

            SqlConnection conn = DBconfig.getConnection();
            try
            {
                conn.Open();
                this.Hide();
                frmMain f = new frmMain();
                f.Closed += (s, args) => this.Close();
                f.Show();
            }
            catch(SqlException err)
            {
                More.showNoticeErrorFromSQL(err.Number);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            if (txt_username.Text.Length == 0)
                errorProvider1.SetError((Control)sender, "Không được để trống trường này !");
            else
                errorProvider1.Clear();
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text.Length == 0)
                errorProvider1.SetError((Control)sender, "Không được để trống trường này !");
            else
                errorProvider1.Clear();
        }

        private void scanQR_Click(object sender, EventArgs e)
        {
            ScanQRCode f = new ScanQRCode();
            f.ShowDialog();
        }
    }
}
