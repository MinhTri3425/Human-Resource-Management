﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.BL_Layer
{
    internal class NhanVien
    {
        DB db = null;
        UserMode UserMode = null;
        int UserID;
        string functionName = null;
        public NhanVien(int UserID, string functionName)
        {
            db = new DB();
            UserMode = new UserMode();
            this.UserID = UserID;
            this.functionName = functionName;
        }
        public int LayNhanVienIDtheoUserID(ref string err)
        {
            string sql = $"SELECT NhanVienID FROM Users WHERE UserID = {UserID}";
            DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);

            if (ds.Tables[0].Rows.Count > 0)
            {
                return Convert.ToInt32(ds.Tables[0].Rows[0]["NhanVienID"]);
            }
            else
            {
                err = "Không tìm thấy nhân viên tương ứng với UserID.";
                return -1; // hoặc giá trị mặc định khác tùy bạn
            }
        }
        public DataSet LayNhanVien()//Admin, HR
        {
            return db.ExecuteQueryDataSet("select * from NhanVien", CommandType.Text);
        }

        public DataSet LayNhanVienTheoID(int NhanVienID)//Admin, HR, Manager
        {
            string sql = $"SELECT * FROM NhanVien WHERE NhanVienID = {NhanVienID}";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet LayNhanVienTheoPhongBanID(int PhongBanID)//Admin, HR
        {
            string sql = $"SELECT * FROM NhanVien WHERE PhongBanID = {PhongBanID}";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public bool ThemNhanVien(string HoTen, DateTime NgaySinh, string CMND, string MaSoThue, int PhongBanID, int ChucVuID, string TrangThai, ref string err)//Admin, HR
        {
            if (!UserMode.HasPermission(UserID, functionName, "Add", ref err))
            {
                err = "Bạn không có quyền thêm nhân viên.";
                return false;
            }
            string sqlString = "Insert Into NhanVien(HoTen, NgaySinh, CMND, MaSoThue, PhongBanID, ChucVuID, TrangThai) Values(N'" +
            HoTen + "','" +
            NgaySinh.ToString("yyyy-MM-dd") + "',N'" +
            CMND + "',N'" +
            MaSoThue + "'," +
            PhongBanID + "," +
            ChucVuID + ",N'" +
            TrangThai + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaNhanVien(int NhanVienID, ref string err)//Admin, HR
        {
            if (!UserMode.HasPermission(UserID, functionName, "Delete", ref err))
            {
                err = "Bạn không có quyền xóa nhân viên.";
                return false;
            }
            string sqlString = "Delete From NhanVien Where NhanVienID=" + NhanVienID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatNhanVien(int NhanVienID, string HoTen, DateTime NgaySinh, string CMND, string MaSoThue, int PhongBanID, int ChucVuID, string TrangThai, ref string err)//Admin, HR
        {
            if (!UserMode.HasPermission(UserID, functionName, "Edit", ref err))
            {
                err = "Bạn không có quyền cập nhật nhân viên.";
                return false;
            }
            string sqlString = "Update NhanVien Set HoTen=N'" + HoTen +
            "', NgaySinh='" + NgaySinh.ToString("yyyy-MM-dd") +
            "', CMND=N'" + CMND +
            "', MaSoThue=N'" + MaSoThue +
            "', PhongBanID=" + PhongBanID +
            ", ChucVuID=" + ChucVuID +
            ", TrangThai=N'" + TrangThai +
            "' Where NhanVienID=" + NhanVienID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemNhanVien(string keyword)//Admin, HR
        {
            string sql = $"SELECT * FROM NhanVien WHERE HoTen LIKE N'%{keyword}%' OR CMND LIKE N'%{keyword}%' OR MaSoThue LIKE N'%{keyword}%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet LayNhanVienTheoTrangThai(string trangThai)
        {
            string sql = $"SELECT * FROM NhanVien WHERE TrangThai = N'{trangThai}'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public bool NhanVienDaCoTaiKhoan(int nhanVienID)
        {
            string sql = $"SELECT COUNT(*) FROM Users WHERE NhanVienID = {nhanVienID}";
            var ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
            int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            return count > 0;
        }
        public int TongNhanVienTheoPhongBan(int phongBanID, ref string err)
        {
            try
            {
                string sql = $"SELECT COUNT(*) FROM NhanVien WHERE PhongBanID = {phongBanID}";
                object result = db.ExecuteScalar(sql, CommandType.Text);
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                err = "Lỗi khi lấy tổng số nhân viên theo phòng ban: " + ex.Message;
                return 0;
            }
        }
        public int TongNhanVien(ref string err)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM NhanVien";
                object result = db.ExecuteScalar(sql, CommandType.Text);
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                err = "Lỗi khi lấy tổng số nhân viên: " + ex.Message;
                return 0;
            }
        }
        public int TongNhanVienCungPhongBan(int phongBanID, ref string err)
        {
            try
            {
                string sql = $"SELECT COUNT(*) FROM NhanVien WHERE PhongBanID = {phongBanID}";
                object result = db.ExecuteScalar(sql, CommandType.Text);
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                err = "Lỗi khi lấy tổng số nhân viên trong phòng ban: " + ex.Message;
                return 0;
            }
        }
        public bool NhanVienIDDaTonTai(int nhanVienID, ref string err)
        {
            try
            {
                string sql = $"SELECT COUNT(*) FROM NhanVien WHERE NhanVienID = {nhanVienID}";
                object result = db.ExecuteScalar(sql, CommandType.Text);
                return Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                err = "Lỗi khi kiểm tra nhân viên ID: " + ex.Message;
                return false;
            }
        }
        public DataSet TimKiemNhanVienCungPhongBan(int phongBanID, string keyword)
        {
            string sql = $@"
            SELECT * 
            FROM NhanVien 
            WHERE PhongBanID = {phongBanID} 
            AND (HoTen LIKE N'%{keyword}%' OR CMND LIKE N'%{keyword}%' OR MaSoThue LIKE N'%{keyword}%')";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public bool NhanVienCoCungPhongBan(int nhanVienID, int phongBanID, ref string err)
        {
            try
            {
                string sql = $"SELECT COUNT(*) FROM NhanVien WHERE NhanVienID = {nhanVienID} AND PhongBanID = {phongBanID}";
                object result = db.ExecuteScalar(sql, CommandType.Text);
                return Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                err = "Lỗi khi kiểm tra nhân viên có cùng phòng ban: " + ex.Message;
                return false;
            }
        }
        public DataSet LayTatCaNhanVienChuaCoUser(ref string err)
        {
            try
            {
                string sql = @"
                SELECT NhanVienID 
                FROM NhanVien 
                WHERE NhanVienID NOT IN (SELECT NhanVienID FROM Users)";
                return db.ExecuteQueryDataSet(sql, CommandType.Text);
            }
            catch (Exception ex)
            {
                err = "Lỗi khi lấy tất cả nhân viên chưa có User: " + ex.Message;
                return null;
            }
        }
    }
}
