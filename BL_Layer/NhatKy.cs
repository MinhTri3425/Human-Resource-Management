using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.BL_Layer
{
    internal class NhatKy
    {
        DB db = null;
        int UserID;
        string functionName = null;
        UserMode UserMode = null;
        public NhatKy(int UserID, string functionName)
        {
            db = new DB();
            this.UserID = UserID;
            this.functionName = functionName;
            UserMode = new UserMode();
        }
        public DataSet LayNhatKy()
        {
            return db.ExecuteQueryDataSet("select * from NhatKy", CommandType.Text);
        }
        public DataSet LayNhatKytheoUserID(int UserID)
        {
            string sql = $"SELECT * FROM NhatKy WHERE UserID = {UserID}";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public bool ThemNhatKy(int NhatKyID, int userID, string HanhDong, DateTime ThoiGian, ref string err)
        {
            if (!UserMode.HasPermission(UserID, functionName, "Add", ref err))
            {
                err = "Bạn không có quyền thêm nhật ký.";
                return false;
            }
            string sqlString = "Insert Into NhatKy(UserID, HanhDong, ThoiGian) Values(" +
            userID + ",N'" +
            HanhDong + "','" +
            ThoiGian.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaNhatKy(int NhatKyID, ref string err)
        {
            if (!UserMode.HasPermission(UserID, functionName, "Delete", ref err))
            {
                err = "Bạn không có quyền xóa nhật ký.";
                return false;
            }
            string sqlString = "Delete From NhatKy Where NhatKyID=" + NhatKyID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatNhatKy(int NhatKyID, int userID, string HanhDong, DateTime ThoiGian, ref string err)
        {
            if (!UserMode.HasPermission(UserID, functionName, "Edit", ref err))
            {
                err = "Bạn không có quyền cập nhật nhật ký.";
                return false;
            }
            string sqlString = "Update NhatKy Set UserID=" +
            userID + ",HanhDong=N'" +
            HanhDong + "',ThoiGian='" +
            ThoiGian.ToString("yyyy-MM-dd HH:mm:ss") + "' Where NhatKyID=" + NhatKyID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemNhatKy(string keyword)
        {
            string sql = $"SELECT * FROM NhatKy WHERE UserID LIKE '%{keyword}%' OR HanhDong LIKE N'%{keyword}%' OR ThoiGian LIKE '%{keyword}%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet TimKiemNhatKyTheoThoiGian(DateTime startDate, DateTime endDate)
        {
            string sql = $"SELECT * FROM NhatKy WHERE ThoiGian BETWEEN '{startDate.ToString("yyyy-MM-dd HH:mm:ss")}' AND '{endDate.ToString("yyyy-MM-dd HH:mm:ss")}'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet TimKiemTheoHanhDong(string hanhDong)
        {
            string sql = $"SELECT * FROM NhatKy WHERE HanhDong LIKE N'%{hanhDong}%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
    }
}
