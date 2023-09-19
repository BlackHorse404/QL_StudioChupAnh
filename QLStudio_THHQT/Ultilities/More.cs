using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLStudio_THHQT.Ultilities
{
    public static class More
    {
        public static bool flag = false;
        public static void showNotice(int state, string nameAction)
        {
            if(state == 1)
            {
                MessageBox.Show(nameAction + " thành công !","Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else{
                MessageBox.Show(nameAction + " không thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DialogResult ConfirmDelete(string displayName)
        {
            return MessageBox.Show("Bạn chắc chắn muốn xóa: " + displayName + " ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static string getValueFromColumn(string columnName, DataGridView dgv)
        {
            int index = dgv.CurrentRow.Index;
            return dgv.Rows[index].Cells[columnName].Value.ToString();
        }

        public static void checkKeyPressIsNum(KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void showMessageError(string mess)
        {
            MessageBox.Show(mess, "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void showNoticeErrorFromSQL(int numErr)
        {
            if(numErr == 229)
            {
                MessageBox.Show("Bạn không đước phép sử dụng chức năng này !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                flag = true;
            }
            else if(numErr == 18456)
            {
                MessageBox.Show("Đăng nhập thất bại !" + Environment.NewLine + "Kiểm tra lại username và password !","Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                showMessageError("Lỗi Bất Định !");
            }
        }

        public static void closeForm(Form f)
        {
            f.Close();
        }
    }
}
