using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Data;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.BL_Layer
{
    internal class CongTrinh
    {
        DB db = null;
        int UserID;
        string functionName = null;
        UserMode UserMode = null;
        public CongTrinh(int UserID, string functionName)
        {
            db = new DB();
            this.UserID = UserID;
            this.functionName = functionName;
            UserMode = new UserMode();
        }
        public DataSet LayCongTrinh()//Admin
        {
            return db.ExecuteQueryDataSet("select * from CongTrinh", CommandType.Text);
        }

        public bool ThemCongTrinh(string TenCongTrinh, int PhongBanID, string DiaDiem, DateTime NgayBatDau, DateTime NgayKetThuc, ref string err)//Admin, Manager
        {
            if (!UserMode.HasPermission(UserID, functionName, "Add", ref err))
            {
                err = "Bạn không có quyền thêm công trình.";
                return false;
            }
            string sqlString = "Insert Into CongTrinh(TenCongTrinh, PhongBanID, DiaDiem, NgayBatDau, NgayKetThuc) Values(N'" +
            TenCongTrinh + "'," +
            PhongBanID + ",N'" +
            DiaDiem + "','" +
            NgayBatDau.ToString("yyyy-MM-dd") + "','" +
            NgayKetThuc.ToString("yyyy-MM-dd") + "')'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaCongTrinh(int CongTrinhID, ref string err)//Admin, Manager
        {
            if (!UserMode.HasPermission(UserID, functionName, "Delete", ref err))
            {
                err = "Bạn không có quyền xóa công trình.";
                return false;
            }
            string sqlString = "Delete From CongTrinh Where CongTrinhID=" + CongTrinhID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatCongTrinh(int CongTrinhID, string TenCongTrinh, int PhongBanID, string DiaDiem, DateTime NgayBatDau, DateTime NgayKetThuc, ref string err)//Admin, Manager
        {
            if (!UserMode.HasPermission(UserID, functionName, "Edit", ref err))
            {
                err = "Bạn không có quyền cập nhật công trình.";
                return false;
            }
            string sqlString = "Update CongTrinh Set TenCongTrinh=N'" +
            TenCongTrinh + "',PhongBanID=" + PhongBanID + ",DiaDiem=N'" + DiaDiem + "',NgayBatDau='" + NgayBatDau.ToString("yyyy-MM-dd") + "',NgayKetThuc='" + NgayKetThuc.ToString("yyyy-MM-dd") +
            "' Where CongTrinhID=" + CongTrinhID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemCongTrinh(string keyword)//Admin, Manager
        {
            string sql = $"SELECT * FROM CongTrinh WHERE TenCongTrinh LIKE N'%{keyword}%' OR DiaDiem LIKE N'%{keyword}%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet LayCongTrinhTheoPhongBan(int phongBanID)//Manager, Employee
        {
            string sql = $"SELECT * FROM CongTrinh WHERE PhongBanID = {phongBanID}";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet LayCongTrinhDangHoatDong()
        {
            string sql = $"SELECT * FROM CongTrinh WHERE NgayKetThuc >= GETDATE()";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public int TongCongTrinh(ref string err)
        {
            string sql = "SELECT COUNT(*) FROM CongTrinh";
            DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            }
            else
            {
                err = "Không tìm thấy dữ liệu.";
                return 0;
            }
        }
        public int TongCongTrinhTheoPhongBan(int phongBanID, ref string err)
        {
            string sql = $"SELECT COUNT(*) FROM CongTrinh WHERE PhongBanID = {phongBanID}";
            DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            }
            else
            {
                err = "Không tìm thấy dữ liệu.";
                return 0;
            }
        }
        public DataSet TimKiemCongTrinhCungPhongBan(int phongBanID, string keyword)
        {
            string sql = $"SELECT * FROM CongTrinh WHERE PhongBanID = {phongBanID} AND TenCongTrinh LIKE N'%{keyword}%' OR DiaDiem LIKE N'%{keyword}%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);

        }
        public bool CongTrinhIDDaTonTai(int congTrinhID, ref string err)
        {
            string sql = $"SELECT COUNT(*) FROM CongTrinh WHERE CongTrinhID = {congTrinhID}";
            DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
            if (ds.Tables[0].Rows.Count > 0 && Convert.ToInt32(ds.Tables[0].Rows[0][0]) > 0)
            {
                return true; // Công trình đã tồn tại
            }
            else
            {
                err = "Công trình không tồn tại.";
                return false; // Công trình không tồn tại
            }
        }
        public bool CongTrinhCoCungPhongBan(int congTrinhID, int phongBanID, ref string err)
        {
            string sql = $"SELECT COUNT(*) FROM CongTrinh WHERE CongTrinhID = {congTrinhID} AND PhongBanID = {phongBanID}";
            DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
            if (ds.Tables[0].Rows.Count > 0 && Convert.ToInt32(ds.Tables[0].Rows[0][0]) > 0)
            {
                return true; // Công trình thuộc phòng ban
            }
            else
            {
                err = "Công trình không thuộc phòng ban này.";
                return false; // Công trình không thuộc phòng ban này
            }
        }
        public string LayTenCongTrinhTheoID(int congTrinhID)
        {
            string sql = $"SELECT TenCongTrinh FROM CongTrinh WHERE CongTrinhID = {congTrinhID}";
            DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0].Rows[0]["TenCongTrinh"].ToString();
            }

            return "--";
        }
    }
}
