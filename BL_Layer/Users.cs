using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.BL_Layer
{
    internal class Users
    {
        DB db = null;
        UserMode UserMode = null;
        int UserID;
        string functionName = null;
        public Users(int userID, string functionName)
        {
            db = new DB();
            UserMode = new UserMode();
            UserID = userID;
            this.functionName = functionName;
        }
        public Users()
        {
            db = new DB();
            UserMode = new UserMode();
        }
        public DataSet LayUsers()
        {
            return db.ExecuteQueryDataSet("select * from Users", CommandType.Text);
        }
        public DataSet LayUsersTheoID(int UserID)
        {
            string sql = $"SELECT * FROM Users WHERE UserID = {UserID}";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public bool ThemUsers(int UserID, string Username, string PasswordHash, int RoleID, int NhanVienID, ref string err)
        {
            if (!UserMode.HasPermission(UserID, functionName, "Add", ref err))
            {
                err = "Bạn không có quyền thêm User.";
                return false;
            }
            string sqlString = "Insert Into Users(Username, PasswordHash, RoleID, NhanVienID) Values(N'" +
            Username + "','" +
            PasswordHash + "'," +
            RoleID + "," +
            NhanVienID + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaUsers(int UserID, int userid, ref string err)
        {
            if (!UserMode.HasPermission(UserID, functionName, "Delete", ref err))
            {
                err = "Bạn không có quyền xóa User.";
                return false;
            }
            string sqlString = "Delete From Users Where UserID=" + userid;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatUsers(int UserID, int userid, string Username, string PasswordHash, ref string err)
        {
            if (!UserMode.HasPermission(UserID, functionName, "Edit", ref err))
            {
                err = "Bạn không có quyền cập nhật User.";
                return false;
            }
            string sqlString = null;
            if (PasswordHash == null || PasswordHash == "")
            {
                sqlString = "Update Users Set Username=N'" + Username + "' Where UserID =" + userid;
            }
            else
            {
                sqlString = "Update Users Set Username=N'" + Username + "',PasswordHash=N'" + PasswordHash + "' Where UserID =" + userid;
            }
            
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }
        public bool DangNhap(string username, string plainPassword, ref int userID, ref int roleID, ref string err)
        {
            string hashedPassword = HashPassword(plainPassword);
            string sql = $"SELECT UserID, RoleID FROM Users WHERE Username = N'{username}' AND PasswordHash = N'{hashedPassword}'";
            DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
            if (ds.Tables[0].Rows.Count > 0)
            {
                userID = Convert.ToInt32(ds.Tables[0].Rows[0]["UserID"]);
                roleID = Convert.ToInt32(ds.Tables[0].Rows[0]["RoleID"]);
                return true;
            }
            else
            {
                err = "Tài khoản hoặc mật khẩu không đúng.";
                return false;
            }
        }

        public int LayUserIDTheoUsername(string username, ref string err)
        {
            string sql = $"SELECT UserID FROM Users WHERE Username = N'{username}'";
            DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return Convert.ToInt32(ds.Tables[0].Rows[0]["UserID"]);
            }
            else
            {
                err = "Không tìm thấy User tương ứng với Username.";
                return -1; // hoặc giá trị mặc định khác tùy bạn
            }
        }
        public DataSet LayUsersTheoRoleID(string roleID)
        {
            string sql = $"SELECT * FROM Users WHERE RoleID = {roleID}";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet TimKiemUsers(string keyword)
        {
            string sql = $"SELECT * FROM Users WHERE Username LIKE N'%{keyword}%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
    }
}
