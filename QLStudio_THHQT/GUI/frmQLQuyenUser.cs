using System;
using System.Data;
using System.Windows.Forms;
using QLStudio_THHQT.BLL;
using System.Linq;
using QLStudio_THHQT.DTO;

namespace QLStudio_THHQT.GUI
{
    public partial class frmQLQuyenUser : Form
    {
        public frmQLQuyenUser()
        {
            InitializeComponent();
        }
        AccountBL ac = new AccountBL();

        private void resetAllCheckBox()
        {
            // xem
            chk_xemDV.Checked = false;
            chk_xemHD.Checked = false;
            chk_xemNV.Checked = false;
            chk_xemKH.Checked = false;
            chk_xemPDK.Checked = false;
            // xóa
            chk_xoaDV.Checked = false;
            chk_xoaHD.Checked = false;
            chk_xoaNV.Checked = false;
            chk_xoaKH.Checked = false;
            chk_xoaPDK.Checked = false;
            // sủa
            chk_suaDV.Checked = false;
            chk_suaHD.Checked = false;
            chk_suaNV.Checked = false;
            chk_suaKH.Checked = false;
            chk_suaPDK.Checked = false;
        }

        private void loadWhichRoleOf(string userpick)
        {
            //nhom quyen Admin
            if (ac.getStateRoleOf(userpick, "RoleAdmin") == 1)
                chk_NQAdmin.Checked = true;
            else
                chk_NQAdmin.Checked = false;
            //nhom quyen KeToan
            if (ac.getStateRoleOf(userpick, "RoleKeToan") == 1)
                chk_NQKeToan.Checked = true;
            else
                chk_NQKeToan.Checked = false;
            //nhom quyen NhanVien
            if (ac.getStateRoleOf(userpick, "RoleNV") == 1)
                chk_NQNhanVien.Checked = true;
            else
                chk_NQNhanVien.Checked = false;
        }

        private void loadAllPermission(string userPick)
        {
            //quyền xem
            checkedPermission(userPick, "GetTableDichVu", chk_xemDV2);
            checkedPermission(userPick, "GetTableHoaDon", chk_xemHD2);
            checkedPermission(userPick, "GetTableKhachHang", chk_xemKH2);
            checkedPermission(userPick, "GetTablePhieuDangKy", chk_xemPDK2);
            checkedPermission(userPick, "GetTableNhanVien", chk_xemNV2);
            //quyền xóa
            checkedPermission(userPick, "DeleteDichVu", chk_xoaDV2);
            checkedPermission(userPick, "DeleteHoaDon", chk_xoaHD2);
            checkedPermission(userPick, "DeleteKhachHang", chk_xoaKH2);
            checkedPermission(userPick, "DeletePhieuDangKy", chk_xoaPDK2);
            checkedPermission(userPick, "DeleteNhanVien", chk_xoaNV2);
            //quyền sửa
            checkedPermission(userPick, "UpdateDichVu", chk_suaDV2);
            checkedPermission(userPick, "UpdateHoaDon", chk_suaHD2);
            checkedPermission(userPick, "UpdateKhachHang", chk_suaKH2);
            checkedPermission(userPick, "UpdatePhieuDangKy", chk_suaPDK2);
            checkedPermission(userPick, "UpdateNhanVien", chk_suaNV2);
        }

        private void frmQLQuyenUser_Load(object sender, EventArgs e)
        {
            //load combobox userlogin tab 1
            //DataTable t = ac.getAllUserOfDB();
            cB_TaiKhoan.DataSource = ac.getAllUserOfDB();
            cB_TaiKhoan.DisplayMember = "username";
            cB_TaiKhoan.ValueMember = "username";
            //load comboBox userlogin tab 2 
            if(cB_TaiKhoan.Items.Count != 0)
            {
                cb_TaiKhoan2.DataSource = ac.getAllUserOfDB();
                cb_TaiKhoan2.DisplayMember = "username";
                cb_TaiKhoan2.ValueMember = "username";
            }
            //load comboBox userlogin tab 2 
            if (cB_TaiKhoan.Items.Count != 0 && cb_TaiKhoan2.Items.Count != 0)
            {
                cb_TK3.DataSource = ac.getAllUserOfDB();
                cb_TK3.DisplayMember = "username";
                cb_TK3.ValueMember = "username";
            }

            radioRevoke.Checked = true;
        }

        private void checkedPermission(string userPick, string nameProc, CheckBox chk)
        {
            if (ac.getMapPermission(userPick, nameProc) == 1)
            {
                chk.Checked = true;
                chk.BackColor = System.Drawing.Color.Yellow;
            }
            else
            {
                chk.Checked = false;
                chk.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            resetAllCheckBox();
        }

        private void cb_TaiKhoan2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_TaiKhoan2.Items.Count != 0 && !cb_TaiKhoan2.SelectedValue.ToString().Equals("System.Data.DataRowView"))
            {
                string userPick = cb_TaiKhoan2.SelectedValue.ToString();
                //load map quyen
                loadAllPermission(userPick);
                loadWhichRoleOf(userPick);
            }
        }

        private void btn_ClearNhomQuyen_Click(object sender, EventArgs e)
        {
            chk_NQAdmin.Checked = false;
            chk_NQKeToan.Checked = false;
            chk_NQNhanVien.Checked = false;
        }

        private void btn_cancel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SaveNQ_Click(object sender, EventArgs e)
        {
            try
            {
                //add|remove nhom quyen admin
                string username = cb_TaiKhoan2.SelectedValue.ToString();
                if (chk_NQAdmin.Checked)
                    ac.addRoleMember(username, "roleAdmin");
                else
                    ac.dropRoleMember(username, "roleAdmin");

                //add|remove nhom quyen ketoan
                if (chk_NQKeToan.Checked)
                    ac.addRoleMember(username, "roleKeToan");
                else
                    ac.dropRoleMember(username, "roleKeToan");

                //add|remove nhom quyen nhanvien
                if (chk_NQNhanVien.Checked)
                    ac.addRoleMember(username, "roleNV");
                else
                    ac.dropRoleMember(username, "roleNV");
            }
            catch
            {

            }
        }

        private void btn_SaveQuyenRieng_Click(object sender, EventArgs e)
        {
            try
            {
                string username = cB_TaiKhoan.SelectedValue.ToString();
                if (radioRevoke.Checked == true)
                {
                    //
                    if (chk_suaDV.Checked)
                        ac.grantQuyen(username, "quyenSuaNhanVien");
                    else
                        ac.revokeQuyen(username, "ThuQuyenSuaNhanVien");
                    //
                    if (chk_suaHD.Checked)
                        ac.grantQuyen(username, "quyenSuaHoaDon");
                    else
                        ac.revokeQuyen(username, "ThuQuyenSuaHoaDon");
                    //
                    if (chk_suaKH.Checked)
                        ac.grantQuyen(username, "quyenSuaKhachHang");
                    else
                        ac.revokeQuyen(username, "ThuQuyenSuaKhachHang");
                    //
                    if (chk_suaPDK.Checked)
                        ac.grantQuyen(username, "quyenSuaPhieuDangKy");
                    else
                        ac.revokeQuyen(username, "ThuQuyenSuaPhieuDangKy");
                    //
                    if (chk_suaNV.Checked)
                        ac.grantQuyen(username, "quyenSuaNhanVien");
                    else
                        ac.revokeQuyen(username, "ThuQuyenSuaNhanVien");
                }
                else if (radioDeny.Checked == true)
                {
                    //
                    if (chk_suaDV.Checked)
                        ac.grantQuyen(username, "ChanQuyenSuaDichVu");
                    else
                        ac.revokeQuyen(username, "ThuQuyenSuaDichVu");
                    //
                    if (chk_suaHD.Checked)
                        ac.grantQuyen(username, "ChanQuyenSuaHoaDon");
                    else
                        ac.revokeQuyen(username, "ThuQuyenSuaHoaDon");
                    //
                    if (chk_suaKH.Checked)
                        ac.grantQuyen(username, "ChanQuyenSuaKhachHang");
                    else
                        ac.revokeQuyen(username, "ThuQuyenSuaKhachHang");
                    //
                    if (chk_suaPDK.Checked)
                        ac.grantQuyen(username, "ChanQuyenSuaPhieuDangKy");
                    else
                        ac.revokeQuyen(username, "ThuQuyenSuaPhieuDangKy");
                    //
                    if (chk_suaNV.Checked)
                        ac.grantQuyen(username, "ChanQuyenSuaNhanVien");
                    else
                        ac.revokeQuyen(username, "ThuQuyenSuaNhanVien");
                }
            }
            catch
            {

            }
            
        }

    }
}
