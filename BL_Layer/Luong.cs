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
        public bool ThemLuong(int NhanVienID, int Thang, int Nam, decimal LuongCoBan, decimal PhuCap, decimal TongLuong, string TrangThai, ref string err)//Admin, Accoutants
        {
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
        public bool CapNhatLuong(int LuongID, int NhanVienID, int Thang, int Nam, decimal HeSoLuong, decimal PhuCap, decimal TongLuong, string TrangThai, ref string err)//Admin, Accoutants
        {
            if (!UserMode.HasPermission(UserID, functionName, "Edit", ref err))
            {
                err = "Bạn không có quyền cập nhật lương.";
                return false;
            }
            string sqlString = "Update Luong Set NhanVienID=" +
            NhanVienID + ",Thang=" +
            Thang + ",Nam=" +
            Nam + ",LuongCoBan=" +
            HeSoLuong + ",PhuCap=" +
            PhuCap + ",TongLuong='" +
            TongLuong + "',TrangThai=N'" +
            TrangThai + "' Where LuongID=" + LuongID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemLuongTheoThangNam(int thang, int nam)
        {
            string sql = $"SELECT * FROM Luong WHERE Thang = {thang} AND Nam = {nam}";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
    }
}
