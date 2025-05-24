using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.BL_Layer
{
    internal class TangCa
    {
        DB db = null;
        int UserID;
        string functionName = null;
        UserMode UserMode = null;
        public TangCa(int UserID, string functionName)
        {
            db = new DB();
            this.UserID = UserID;
            this.functionName = functionName;
            UserMode = new UserMode();
        }
        public DataSet LayTangCa()
        {
            return db.ExecuteQueryDataSet("select * from TangCa", CommandType.Text);
        }
        public DataSet LayTangCaTheoNhanVienID(int nhanVienID)
        {
            string sql = $"SELECT * FROM TangCa WHERE NhanVienID = {nhanVienID}";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public bool ThemTangCa(int NhanVienID, DateTime NgayTangCa, string GioBatDau, string GioKetThuc, string LoaiTangCa, string HinhThuc, string TrangThai, ref string err)//Admin, Accoutants
        {
            if (!UserMode.HasPermission(UserID, functionName, "Add", ref err))
            {
                err = "Bạn không có quyền thêm tăng ca.";
                return false;
            }
            string sqlString = "Insert Into TangCa(NhanVienID, NgayTangCa, GioBatDau, GioKetThuc, LoaiTangCa, HinhThuc, TrangThai) Values(" +
            NhanVienID + ",'" +
            NgayTangCa.ToString("yyyy-MM-dd") + "','" +
            GioBatDau + "','" +
            GioKetThuc + "',N'" +
            LoaiTangCa + "',N'" +
            HinhThuc + "',N'" +
            TrangThai + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaTangCa(int TangCaID, ref string err)//Admin, Accoutants
        {
            if (!UserMode.HasPermission(UserID, functionName, "Delete", ref err))
            {
                err = "Bạn không có quyền xóa tăng ca.";
                return false;
            }
            string sqlString = "Delete From TangCa Where TangCaID=" + TangCaID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatTangCa(int TangCaID, int NhanVienID, DateTime NgayTangCa, string GioBatDau, string GioKetThuc, string LoaiTangCa, string HinhThuc, string TrangThai, ref string err)//Admin, Accoutants
        {
            if (!UserMode.HasPermission(UserID, functionName, "Edit", ref err))
            {
                err = "Bạn không có quyền cập nhật tăng ca.";
                return false;
            }
            string sqlString = "Update TangCa Set NhanVienID=" +
            NhanVienID + ",NgayTangCa='" +
            NgayTangCa.ToString("yyyy-MM-dd") + "',GioBatDau='" +
            GioBatDau + "',GioKetThuc='" +
            GioKetThuc + "',LoaiTangCa=N'" +
            LoaiTangCa + "',HinhThuc=N'" +
            HinhThuc + "',TrangThai=N'" +
            TrangThai + "' Where TangCaID=" + TangCaID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemTangCa(string keyword)
        {
            string sql = $"SELECT * FROM TangCa WHERE NhanVienID LIKE '%{keyword}%' OR NgayTangCa LIKE '%{keyword}%' OR GioBatDau LIKE '%{keyword}%' OR GioKetThuc LIKE '%{keyword}%' OR LoaiTangCa LIKE N'%{keyword}%' OR HinhThuc LIKE N'%{keyword}%' OR TrangThai LIKE N'%{keyword}%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet LayTangCaTheoTrangThai(string trangThai)
        {
            string sql = $"SELECT * FROM TangCa WHERE TrangThai = N'{trangThai}'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public decimal LayTongGioTangCa(int nhanVienID)
        {
            string sql = $"SELECT SUM(DATEDIFF(MINUTE, GioBatDau, GioKetThuc)) / 60.0 AS TongGioTangCa FROM TangCa WHERE NhanVienID = {nhanVienID}";
            DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
            if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0]["TongGioTangCa"] != DBNull.Value)
            {
                return Convert.ToDecimal(ds.Tables[0].Rows[0]["TongGioTangCa"]);
            }
            return 0;
        }
        public string LayHinhThucTangCa(int nhanVienID)
        {
            string sql = $"SELECT DISTINCT HinhThuc FROM TangCa WHERE NhanVienID = {nhanVienID}";
            DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
            if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0]["HinhThuc"] != DBNull.Value)
            {
                return ds.Tables[0].Rows[0]["HinhThuc"].ToString();
            }
            return string.Empty;
        }
    }
}
