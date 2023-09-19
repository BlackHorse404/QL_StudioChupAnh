using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLStudio_THHQT.DAL;
using System.Data;

namespace QLStudio_THHQT.BLL
{
    public class AccountBL
    {
        private Controls_DAL da = new Controls_DAL();
        public int createAccount(string username, string password)
        {
            string sql = string.Format("exec dbo.createAccount '{0}', '{1}'", username, password);
            return da.ExecProcedureNonQuery(sql);
        }

        public int createAccountChangePassword(string username, string password)
        {
            string sql = string.Format("exec dbo.createAccountMustChange '{0}', '{1}'", username, password);
            return da.ExecProcedureNonQuery(sql);
        }

        public int AddRoleAdmin(string username)
        {
            string sql = string.Format("exec dbo.CapQuyenAdmin '{0}'", username);
            return da.ExecProcedureNonQuery(sql);
        }
        public int AddRoleKeToan(string username)
        {
            string sql = string.Format("exec dbo.CapQuyenKeToan '{0}'", username);
            return da.ExecProcedureNonQuery(sql);
        }
        public int AddRoleNhanVien(string username)
        {
            string sql = string.Format("exec dbo.CapQuyenNhanVien '{0}'", username);
            return da.ExecProcedureNonQuery(sql);
        }

        public string getCurrentUser()
        {
            DataTable t = da.ExecProcedureNotPar("getUserCurrent");
            return t.Rows[0][0].ToString();
        }

        public int changePassword(string username, string passOld, string passNew)
        {
            string sql = string.Format("exec dbo.changePassword '{0}','{1}',{2}",passOld, passNew, username);
            return da.ExecProcedureNonQuery(sql);
        }

        public DataTable getAllUserOfDB()
        {
            string sql = "exec getAllUserOfDB 'QL_Studio'";
            return da.ExecProcedureQuery(sql);
        }

        public int getMapPermission(string username, string nameProc)
        {
            return da.ExecProcedureGetReturnValue("checkMapPermission", nameProc, username);
        }

        public int grantQuyen(string username, string procQuyen)
        {
            return da.ExecProcedureNonQuery(string.Format("exec " + procQuyen + " '{0}'", username));
        }
        public int revokeQuyen(string username, string procQuyen)
        {
            return da.ExecProcedureNonQuery(string.Format("exec " + procQuyen + " '{0}'", username));
        }
        public int denyQuyen(string username, string procQuyen)
        {
            return da.ExecProcedureNonQuery(string.Format("exec " + procQuyen + " '{0}'", username));
        }

        public int addRoleMember(string username, string roleName)
        {
            return da.ExecProcedureNonQuery(string.Format("sp_addrolemember '{0}','{1}'", roleName, username));
        }
        public int dropRoleMember(string username, string roleName)
        {
            return da.ExecProcedureNonQuery(string.Format("sp_droprolemember '{0}','{1}'", roleName, username));
        }

        public int getStateRoleOf(string username, string roleName)
        {
            return da.ExecProcCheckMemberIsOfRole("checkMemberIsOfRole", username, roleName);
        }
    }
}
