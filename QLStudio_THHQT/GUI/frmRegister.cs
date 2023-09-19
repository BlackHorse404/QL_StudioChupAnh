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

namespace QLStudio_THHQT.GUI
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        AccountBL ac = new AccountBL();

        private void btn_Create_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string passw = txt_password.Text;
            string reTypePass = txt_retypePassword.Text;

            int state = 0;
            //tao account
            if(chkBox_ChangePassFirstLogin.Checked)
            {
                state = ac.createAccountChangePassword(username, passw);
            }
            else
            {
                state = ac.createAccount(username, passw);
            }

            //phan quyen
            if (rd_QuanTri.Checked)
            {
                state = ac.AddRoleAdmin(username);
            }
            else if (rd_KeToan.Checked)
            {
                state = ac.AddRoleKeToan(username);
            }
            else if (rd_NhanVien.Checked)
            {
                state = ac.AddRoleNhanVien(username);
            }

            //thong bao
            More.showNotice(state, "Tạo Tài Khoản");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            if (txt_username.Text.Length == 0)
                errorProvider1.SetError(c, "Không được bỏ trống !");
            else
                errorProvider1.Clear();
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            if (txt_password.Text.Length == 0)
                errorProvider1.SetError(c, "Không được bỏ trống !");
            else
                errorProvider1.Clear();
        }

        private void txt_retypePassword_Leave(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            if (txt_retypePassword.Text.Length == 0)
                errorProvider1.SetError(c, "Không được bỏ trống !");
            else if (!txt_retypePassword.Text.Equals(txt_password.Text))
                errorProvider1.SetError(c, "Không khớp mật khẩu !");
            else
                errorProvider1.Clear();
        }
    }
}
