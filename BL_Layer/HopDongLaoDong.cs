using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.BL_Layer
{
    internal class HopDongLaoDong
    {
        DB db = null;
        int UserID;
        string functionName = null;
        UserMode UserMode = null;
        public HopDongLaoDong(int UserID, string functionName)
        {
            db = new DB();
            this.UserID = UserID;
            this.functionName = functionName;
            UserMode = new UserMode();
        }
        public DataSet LayHopDongLaoDong()
        {
            return db.ExecuteQueryDataSet("select * from HopDongLaoDong", CommandType.Text);
        }
        public DataSet LayHopDongTheoPhongBan(int PhongBanID)
        {
            string sqlString = "Select * From HopDongLaoDong Where NhanVienID IN (Select NhanVienID From NhanVien Where PhongBanID=" + PhongBanID + ")";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        public bool ThemHopDongLaoDong(int NhanVienID, string LoaiHopDong, DateTime NgayKy, DateTime NgayHetHan, ref string err)
        {
            if (!UserMode.HasPermission(UserID, functionName, "Add", ref err))
            {
                err = "Bạn không có quyền thêm hợp đồng lao động.";
                return false;
            }
            string sqlString = "Insert Into HopDongLaoDong(NhanVienID, LoaiHopDong, NgayKy, NgayHetHan) Values(" +
            NhanVienID + ",N'" +
            LoaiHopDong + "','" +
            NgayKy.ToString("yyyy-MM-dd") + "','" +
            NgayHetHan.ToString("yyyy-MM-dd") + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaHopDongLaoDong(int HopDongID, ref string err)
        {
            if (!UserMode.HasPermission(UserID, functionName, "Delete", ref err))
            {
                err = "Bạn không có quyền xóa hợp đồng lao động.";
                return false;
            }
            string sqlString = "Delete From HopDongLaoDong Where HopDongID=" + HopDongID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatHopDongLaoDong(int HopDongID, int NhanVienID, string LoaiHopDong, DateTime NgayKy, DateTime NgayHetHan, ref string err)
        {
            if (!UserMode.HasPermission(UserID, functionName, "Edit", ref err))
            {
                err = "Bạn không có quyền cập nhật hợp đồng lao động.";
                return false;
            }
            string sqlString = "Update HopDongLaoDong Set NhanVienID=" +
            NhanVienID + ",LoaiHopDong=N'" +
            LoaiHopDong + "',NgayKy='" +
            NgayKy.ToString("yyyy-MM-dd") + "',NgayHetHan='" +
            NgayHetHan.ToString("yyyy-MM-dd") + "' Where HopDongID=" + HopDongID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool GiaHanHopDong(int HopDongID, DateTime NgayMoi, ref string err)
        {
            if (!UserMode.HasPermission(UserID, functionName, "Edit", ref err))
            {
                err = "Bạn không có quyền gia hạn hợp đồng.";
                return false;
            }

            string sql = $"UPDATE HopDongLaoDong SET NgayHetHan = '{NgayMoi:yyyy-MM-dd}' WHERE HopDongID = {HopDongID}";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public DataSet LayHopDongSapHetHan()
        {
            string sql = "SELECT * FROM HopDongLaoDong WHERE DATEDIFF(day, GETDATE(), NgayHetHan) <= 30";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet LayHopDongDaHetHan()
        {
            string sql = "SELECT * FROM HopDongLaoDong WHERE NgayHetHan < GETDATE()";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet TimKiemHopDong(string keyword)
        {
            string sql = $"SELECT * FROM HopDongLaoDong WHERE LoaiHopDong LIKE N'%{keyword}%' OR NhanVienID IN (SELECT NhanVienID FROM NhanVien WHERE HoTen LIKE N'%{keyword}%')";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet TimKiemHopDongTheoNhanVien(int NhanVienID)
        {
            string sql = $"SELECT * FROM HopDongLaoDong WHERE NhanVienID = {NhanVienID}";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
    }
}
