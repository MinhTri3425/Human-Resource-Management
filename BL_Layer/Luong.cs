using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.BL_Layer
{
    internal class Luong
    {
        DB db = null;
        int UserID;
        string functionName = null;
        UserMode UserMode = null;
        public Luong(int UserID, string functionName)
        {
            db = new DB();
            this.UserID = UserID;
            this.functionName = functionName;
            UserMode = new UserMode();
        }
        public DataSet LayLuong()
        {
            return db.ExecuteQueryDataSet("select * from Luong", CommandType.Text);
        }
        public DataSet LayLuongTheoNhanVienID(int nhanVienID)
        {
            string sql = $"SELECT * FROM Luong WHERE NhanVienID = {nhanVienID}";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public int LayLuongIDTheoNhanVienID(int nhanVienID)
        {
            string sql = $"SELECT LuongID FROM Luong WHERE NhanVienID = {nhanVienID}";
            DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return Convert.ToInt32(ds.Tables[0].Rows[0]["LuongID"]);
            }
            return -1; // Trả về -1 nếu không tìm thấy
        }
        public DataSet LayLuongTheoTrangThai(string trangThai)
        {
            string sql = $"SELECT * FROM Luong WHERE TrangThai = N'{trangThai}'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public bool ThemLuong(int NhanVienID, int Thang, int Nam, decimal LuongCoBan, decimal PhuCap, decimal TongLuong, string TrangThai, ref string err)//Admin, Accoutants  
        {
            // Check if salary already exists for the given employee, month, and year  
            string checkSql = $"SELECT COUNT(*) FROM Luong WHERE NhanVienID = {NhanVienID} AND Thang = {Thang} AND Nam = {Nam}";
            object result = db.ExecuteScalar(checkSql, CommandType.Text);
            if (Convert.ToInt32(result) > 0)
            {
                err = "Nhân viên này đã có lương vào tháng và năm này.";
                return false;
            }

            if (!UserMode.HasPermission(UserID, functionName, "Add", ref err))
            {
                err = "Bạn không có quyền thêm lương.";
                return false;
            }

            string sqlString = "Insert Into Luong(NhanVienID, Thang, Nam, LuongCoBan, PhuCap, TongLuong, TrangThai) Values(" +
            NhanVienID + "," +
            Thang + "," +
            Nam + "," +
            LuongCoBan + "," +
            PhuCap + ",'" +
            TongLuong + "',N'" +
            TrangThai + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaLuong(int LuongID, ref string err)//Admin, Accoutants
        {
            if (!UserMode.HasPermission(UserID, functionName, "Delete", ref err))
            {
                err = "Bạn không có quyền xóa lương.";
                return false;
            }
            string sqlString = "Delete From Luong Where LuongID=" + LuongID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatTrangThaiLuong(int LuongID, string TrangThai, ref string err)//Admin, Accoutants
        {
            if (!UserMode.HasPermission(UserID, functionName, "Edit", ref err))
            {
                err = "Bạn không có quyền cập nhật trạng thái lương.";
                return false;
            }
            string sqlString = "Update Luong Set TrangThai=N'" +
            TrangThai + "' Where LuongID=" + LuongID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemLuong(string keyword)
        {
            string sql = $"SELECT * FROM Luong WHERE NhanVienID LIKE '%{keyword}%' OR Thang LIKE '%{keyword}%' OR Nam LIKE '%{keyword}%' OR LuongCoBan LIKE '%{keyword}%' OR PhuCap LIKE '%{keyword}%' OR TongLuong LIKE '%{keyword}%' OR TrangThai LIKE N'%{keyword}%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public decimal LayLuongCoBan(int nhanVienID, int thang, int nam)
        {
            string sql = $"SELECT LuongCoBan FROM Luong WHERE NhanVienID = {nhanVienID} AND Thang = {thang} AND Nam = {nam}";
            DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return Convert.ToDecimal(ds.Tables[0].Rows[0]["LuongCoBan"]);
            }
            return 0;
        }

        public decimal LayPhuCap(int nhanVienID, int thang, int nam)
        {
            string sql = $"SELECT PhuCap FROM Luong WHERE NhanVienID = {nhanVienID} AND Thang = {thang} AND Nam = {nam}";
            DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return Convert.ToDecimal(ds.Tables[0].Rows[0]["PhuCap"]);
            }
            return 0;
        }

    }
}
