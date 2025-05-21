using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.BL_Layer
{
    internal class PhongBan
    {
        DB db = null;
        int UserID;
        string functionName = null;
        UserMode UserMode = null;
        public PhongBan(int UserID, string functionName)
        {
            db = new DB();
            this.UserID = UserID;
            this.functionName = functionName;
            UserMode = new UserMode();
        }
        public int LayPhongBanIDTheoUserID(ref string err)
        {
            string sql = @"SELECT NhanVien.PhongBanID FROM NhanVien
                   INNER JOIN Users u ON NhanVien.NhanVienID = u.NhanVienID
                   WHERE u.UserID = " + UserID;

            DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return Convert.ToInt32(ds.Tables[0].Rows[0]["PhongBanID"]);
            }
            else
            {
                err = "Không tìm thấy phòng ban của người dùng.";
                return -1; // hoặc giá trị mặc định khác
            }
        }
        public DataSet LayPhongBan()//Admin
        {
            return db.ExecuteQueryDataSet("select * from PhongBan", CommandType.Text);
        }

        public bool ThemPhongBan(string TenPhongBan, ref string err)//Admin
        {
            if (!UserMode.HasPermission(UserID, functionName, "Add", ref err))
            {
                err = "Bạn không có quyền thêm phòng ban.";
                return false;
            }
            string sqlString = "Insert Into PhongBan(TenPhongBan) Values(N'" +
            TenPhongBan + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool KiemTraPhongBanDangSuDung(int PhongBanID)
        {
            string sql = $"SELECT COUNT(*) FROM NhanVien WHERE PhongBanID = {PhongBanID}";
            object result = db.ExecuteScalar(sql, CommandType.Text);
            return result != null && int.TryParse(result.ToString(), out int count) && count > 0;
        }

        public bool XoaPhongBan(int PhongBanID, ref string err)//Admin
        {
            if (!UserMode.HasPermission(UserID, functionName, "Delete", ref err))
            {
                err = "Bạn không có quyền xóa phòng ban.";
                return false;
            }
            if (KiemTraPhongBanDangSuDung(PhongBanID))
            {
                err = "Phòng ban đang được sử dụng, không thể xoá.";
                return false;
            }
            string sqlString = "Delete From PhongBan Where PhongBanID=" + PhongBanID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatPhongBan(int PhongBanID, string TenPhongBan, ref string err)//Admin
        {
            if (!UserMode.HasPermission(UserID, functionName, "Edit", ref err))
            {
                err = "Bạn không có quyền cập nhật phòng ban.";
                return false;
            }
            string sqlString = "Update PhongBan Set TenPhongBan=N'" +
            TenPhongBan + "' Where PhongBanID=" + PhongBanID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemPhongBanTheoTen(string keyword)//Admin
        {
            string sql = $"SELECT * FROM PhongBan WHERE TenPhongBan LIKE N'%{keyword}%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
    }
}
