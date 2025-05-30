﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.BL_Layer
{
    internal class NghiPhep
    {
        DB db = null;
        int UserID;
        string functionName = null;
        UserMode UserMode = null;
        public NghiPhep(int UserID, string functionName)
        {
            db = new DB();
            this.UserID = UserID;
            this.functionName = functionName;
            UserMode = new UserMode();
        }
        public DataSet LayNghiPhep()
        {
            return db.ExecuteQueryDataSet("select * from NghiPhep", CommandType.Text);
        }
        public DataSet LayNghiPhepTheoNhanVienID(int nhanVienID)
        {
            string sql = $"SELECT * FROM NghiPhep WHERE NhanVienID = {nhanVienID}";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public bool ThemNghiPhep(int NhanVienID, DateTime NgayBatDau, DateTime NgayKetThuc, string Loai, string TrangThai, ref string err)
        {
            if (!UserMode.HasPermission(UserID, functionName, "Add", ref err))
            {
                err = "Bạn không có quyền thêm nghỉ phép.";
                return false;
            }
            string sqlString = "Insert Into NghiPhep(NhanVienID, NgayBatDau, NgayKetThuc, Loai, TrangThai) Values(" +
            NhanVienID + ",'" +
            NgayBatDau.ToString("yyyy-MM-dd") + "','" +
            NgayKetThuc.ToString("yyyy-MM-dd") + "',N'" +
            Loai + "',N'" +
            TrangThai + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaNghiPhep(int NghiPhepID, ref string err)
        {
            if (!UserMode.HasPermission(UserID, functionName, "Delete", ref err))
            {
                err = "Bạn không có quyền xóa nghỉ phép.";
                return false;
            }
            string sqlString = "Delete From NghiPhep Where NghiPhepID=" + NghiPhepID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatNghiPhep(int NghiPhepID, int NhanVienID, DateTime NgayBatDau, DateTime NgayKetThuc, string Loai, string TrangThai, ref string err)
        {
            if (!UserMode.HasPermission(UserID, functionName, "Edit", ref err))
            {
                err = "Bạn không có quyền cập nhật nghỉ phép.";
                return false;
            }
            string sqlString = "Update NghiPhep Set NhanVienID=" +
            NhanVienID + ",NgayBatDau='" +
            NgayBatDau.ToString("yyyy-MM-dd") + "',NgayKetThuc='" +
            NgayKetThuc.ToString("yyyy-MM-dd") + "',Loai=N'" +
            Loai + "',TrangThai=N'" +
            TrangThai + "' Where NghiPhepID=" + NghiPhepID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemNghiPhep(string keyword)
        {
            string sql = $"SELECT * FROM NghiPhep WHERE NhanVienID LIKE '%{keyword}%' OR NgayBatDau LIKE '%{keyword}%' OR NgayKetThuc LIKE '%{keyword}%' OR Loai LIKE N'%{keyword}%' OR TrangThai LIKE N'%{keyword}%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet LayNghiPhepTheoTrangThai(string trangThai)
        {
            string sql = $"SELECT * FROM NghiPhep WHERE TrangThai = N'{trangThai}'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public string LayLoaiNghiPhep(int nhanVienID)
        {
            string sql = $@"
            SELECT DISTINCT Loai 
            FROM NghiPhep 
            WHERE NhanVienID = {nhanVienID}";
            DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
            if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0]["Loai"] != DBNull.Value)
            {
                return ds.Tables[0].Rows[0]["Loai"].ToString();
            }
            return string.Empty;
        }
        public decimal LayTongSoNgayNghiPhep(int nhanVienID)
        {
            string sql = $@"
            SELECT 
            SUM(DATEDIFF(DAY, NgayBatDau, NgayKetThuc) + 1) AS TongSoNgayNghiPhep 
            FROM NghiPhep 
            WHERE NhanVienID = {nhanVienID}";

            DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);

            if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0]["TongSoNgayNghiPhep"] != DBNull.Value)
            {
                return Convert.ToDecimal(ds.Tables[0].Rows[0]["TongSoNgayNghiPhep"]);
            }

            return 0;
        }
        public string LayTrangThaiNghiPhep(int nhanVienID)
        {
            string sql = $@"
            SELECT DISTINCT TrangThai 
            FROM NghiPhep 
            WHERE NhanVienID = {nhanVienID}";
            DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
            if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0]["TrangThai"] != DBNull.Value)
            {
                return ds.Tables[0].Rows[0]["TrangThai"].ToString();
            }
            return string.Empty;
        }
        public string LayTrangThaiNghiPhepTheoNghiPhepID(int nghiPhepID)
        {
            string sql = $"SELECT TrangThai FROM NghiPhep WHERE NghiPhepID = {nghiPhepID}";
            DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
            if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0]["TrangThai"] != DBNull.Value)
            {
                return ds.Tables[0].Rows[0]["TrangThai"].ToString();
            }
            return string.Empty;
        }
        public DataSet LayNghiPhepTheoPhongBanID(int phongBanID)
        {
            string sql = @"
            SELECT np.*
            FROM NghiPhep np
            INNER JOIN NhanVien nv ON np.NhanVienID = nv.NhanVienID
            WHERE nv.PhongBanID = " + phongBanID;

            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet TimKiemNghiPhepTheoTenNhanVienCungPhongBan(int phongBanID, string keyword)
        {
            string sql = $@"
            SELECT np.*
            FROM NghiPhep np
            INNER JOIN NhanVien nv ON np.NhanVienID = nv.NhanVienID
            WHERE nv.PhongBanID = {phongBanID} 
            AND (nv.HoTen LIKE N'%{keyword}%' OR nv.CMND LIKE '%{keyword}%' OR nv.MaSoThue LIKE '%{keyword}%')";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet LayNghiPhepTheoTrangThaiCungPhongBan(int phongBanID, string trangThai)
        {
            string sql = $@"
            SELECT np.*
            FROM NghiPhep np
            INNER JOIN NhanVien nv ON np.NhanVienID = nv.NhanVienID
            WHERE nv.PhongBanID = {phongBanID} 
            AND np.TrangThai = N'{trangThai}'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public bool CapNhatTrangThaiNghiPhep(int nghiPhepID, string trangThai, ref string err)
        {
            if (!UserMode.HasPermission(UserID, functionName, "Edit", ref err))
            {
                err = "Bạn không có quyền cập nhật trạng thái nghỉ phép.";
                return false;
            }
            string sqlString = "Update NghiPhep Set TrangThai=N'" +
            trangThai + "' Where NghiPhepID=" + nghiPhepID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
