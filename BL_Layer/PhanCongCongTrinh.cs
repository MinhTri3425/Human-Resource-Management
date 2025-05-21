using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.BL_Layer
{
    internal class PhanCongCongTrinh
    {
        DB db = null;
        int UserID;
        string functionName = null;
        UserMode UserMode = null;
        public PhanCongCongTrinh(int  UserID, string functionName)
        {
            db = new DB();
            this.UserID = UserID;
            this.functionName = functionName;
            UserMode = new UserMode();
        }
        public DataSet LayPhanCongCongTrinh()
        {
            return db.ExecuteQueryDataSet("select * from PhanCongCongTrinh", CommandType.Text);
        }
        public bool ThemPhanCongCongTrinh(int NhanVienID, int CongTrinhID, DateTime NgayPhanCong, string Loai, string TrangThai, ref string err)//Manager, Employee
        {
            if (!UserMode.HasPermission(UserID, functionName, "Add", ref err))
            {
                err = "Bạn không có quyền thêm phân công công trình.";
                return false;
            }
            string sqlString = "Insert Into PhanCongCongTrinh Values(" +
            NhanVienID + "," +
            CongTrinhID + "," +
            "'" + NgayPhanCong.ToString("yyyy-MM-dd") + "',N'" +
            Loai + "',N'" +
            TrangThai + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaPhanCongCongTrinh(int NhanVienID, int CongTrinhID, ref string err)//Manager, Employee
        {
            if (!UserMode.HasPermission(UserID, functionName, "Delete", ref err))
            {
                err = "Bạn không có quyền xóa phân công công trình.";
                return false;
            }
            string sqlString = "Delete From PhanCongCongTrinh Where NhanVienID=" + NhanVienID + " and CongTrinhID=" + CongTrinhID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatPhanCongCongTrinh(int NhanVienID, int CongTrinhID, DateTime NgayPhanCong, string Loai, string TrangThai, ref string err)////Manager, Employee
        {
            if (!UserMode.HasPermission(UserID, functionName, "Edit", ref err))
            {
                err = "Bạn không có quyền cập nhật phân công công trình.";
                return false;
            }
            string sqlString = "Update PhanCongCongTrinh Set NhanVienID=" +
            NhanVienID + ",CongTrinhID=" +
            CongTrinhID + ",NgayPhanCong='" +
            NgayPhanCong.ToString("yyyy-MM-dd") + "',Loai=N'" +
            Loai + "',TrangThai=N'" +
            TrangThai + "' Where NhanVienID=" + NhanVienID + " and CongTrinhID=" + CongTrinhID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemPhanCongCongTrinh(string keyword)
        {
            string sql = $"SELECT * FROM PhanCongCongTrinh WHERE NhanVienID LIKE '%{keyword}%' OR CongTrinhID LIKE '%{keyword}%' OR NgayPhanCong LIKE '%{keyword}%' OR Loai LIKE N'%{keyword}%' OR TrangThai LIKE N'%{keyword}%'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
    }
}
