using System;
using System.Windows.Forms;
using QLStudio_THHQT.BLL;
using QLStudio_THHQT.Ultilities;

namespace QLStudio_THHQT.GUI
{
    public partial class frmInformation : Form
    {
        public frmInformation()
        {
            InitializeComponent();
        }

        AccountBL ac = new AccountBL();

        private void frmInformation_Load(object sender, EventArgs e)
        {
            txt_user.Text = ac.getCurrentUser();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(txt_passNew.Text.Length != 0 && txt_passOld.Text.Length != 0)
            {
                //change password
                int s = ac.changePassword(txt_user.Text, txt_passOld.Text, txt_passNew.Text);

                More.showNotice(s, "Đổi mật khẩu");
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
