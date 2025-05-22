using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.BL_Layer
{
    internal class ChucVu
    {
        DB db = null;
        int UserID;
        string functionName = null;
        UserMode UserMode = null;
        public ChucVu(int UserID, string functionName)
        {
            db = new DB();
            this.UserID = UserID;
            this.functionName = functionName;
            UserMode = new UserMode();
        }
        public int LayChucVuIDtheoUserID(ref string err)
        {
            string sql = @"SELECT NhanVien.ChucVuID FROM NhanVien
                   INNER JOIN Users u ON NhanVien.NhanVienID = u.NhanVienID
                   WHERE u.UserID = " + UserID;

            DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return Convert.ToInt32(ds.Tables[0].Rows[0]["ChucVuID"]);
            }
            else
            {
                err = "Không tìm thấy chức vụ của người dùng.";
                return -1; // hoặc int? null nếu cần nullable
            }
        }
        public DataSet LayChucVu()//Admin
        {
            return db.ExecuteQueryDataSet("select * from ChucVu", CommandType.Text);
        }
        public String LayTenChucVuTheoID(int ChucVuID)//Admin
        {
            string sql = $"SELECT TenChucVu FROM ChucVu WHERE ChucVuID = {ChucVuID}";
            DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0].Rows[0]["TenChucVu"].ToString();
            }
            else
            {
                return null;
            }
        }
        public bool ThemChucVu(string TenChucVu, ref string err)//Admin
        {
            if (!UserMode.HasPermission(UserID, functionName, "Add", ref err))
            {
                err = "Bạn không có quyền thêm chức vụ.";
                return false;
            }
            string sqlString = "Insert Into ChucVu(TenChucVu) Values(N'" +
            TenChucVu + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool KiemTraChucVuDangSuDung(int ChucVuID)
        {
            string sqlString = $"SELECT COUNT(*) FROM NhanVien WHERE ChucVuID = {ChucVuID}";
            int count = (int)db.ExecuteScalar(sqlString, CommandType.Text);
            return count > 0;
        }
        public bool XoaChucVu(int ChucVuID, ref string err)//Admin
        {
            if (!UserMode.HasPermission(UserID, functionName, "Delete", ref err))
            {
                err = "Bạn không có quyền xóa chức vụ.";
                return false;
            }
            if (KiemTraChucVuDangSuDung(ChucVuID))
            {
                err = "Chức vụ đang được sử dụng, không thể xoá.";
                return false;
            }
            string sqlString = "Delete From ChucVu Where ChucVuID=" + ChucVuID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatChucVu(int ChucVuID, string TenChucVu, ref string err)//Admin
        {
            if (!UserMode.HasPermission(UserID, functionName, "Edit", ref err))
            {
                err = "Bạn không có quyền cập nhật chức vụ.";
                return false;
            }
            string sqlString = "Update ChucVu Set TenChucVu=N'" +
            TenChucVu + "' Where ChucVuID=" + ChucVuID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemChucVu(string keyword)//Admin
        {
            string sqlString = $"SELECT * FROM ChucVu WHERE TenChucVu LIKE N'%{keyword}%'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

    }
}
