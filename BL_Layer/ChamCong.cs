using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.BL_Layer
{
    internal class ChamCong
    {
        DB db = null;
        int UserID;
        string functionName = null;
        UserMode UserMode = null;
        public ChamCong(int UserID, string functionName)
        {
            db = new DB();
            this.UserID = UserID;
            this.functionName = functionName;
            UserMode = new UserMode();
        }
        public DataSet LayChamCong()
        {
            return db.ExecuteQueryDataSet("select * from ChamCong", CommandType.Text);
        }
        public DataSet LayChamCongTheoNhanVienID(int nhanVienID)//Employee
        {
            string sql = $"SELECT * FROM ChamCong WHERE NhanVienID = {nhanVienID}";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet LayChamCongTheoPhongBanID(int phongBanID)//Admin, Accoutants
        {
            string sql = $"SELECT * FROM ChamCong WHERE NhanVienID IN (SELECT NhanVienID FROM NhanVien WHERE PhongBanID = {phongBanID})";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public bool ThemChamCong(int NhanVienID, DateTime Ngay, string GioVao, string GioRa, string TrangThai, ref string err)//Admin, Accoutants
        {
            if (!UserMode.HasPermission(UserID, functionName, "Add", ref err))
            {
                err = "Bạn không có quyền thêm chấm công.";
                return false;
            }
            string sqlString = "Insert Into ChamCong(NhanVienID, Ngay, GioVao, GioRa, TrangThai) Values(" +
            NhanVienID + ",N'" +
            Ngay.ToString("yyyy-MM-dd") + "','" +
            GioVao + "','" +
            GioRa + "',N'" +
            TrangThai + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaChamCong(int ChamCongID, ref string err)//Admin, Accoutants
        {
            if (!UserMode.HasPermission(UserID, functionName, "Delete", ref err))
            {
                err = "Bạn không có quyền xóa chấm công.";
                return false;
            }
            string sqlString = "Delete From ChamCong Where ChamCongID=" + ChamCongID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public decimal TinhTongGioLamTrongThang(int nhanVienID, int thang, int nam)
        {
            string sql = $@"
        SELECT GioVao, GioRa 
        FROM ChamCong 
        WHERE NhanVienID = {nhanVienID} 
            AND MONTH(Ngay) = {thang} 
            AND YEAR(Ngay) = {nam}";

            DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);

            decimal tongGio = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (row["GioVao"] != DBNull.Value && row["GioRa"] != DBNull.Value)
                {
                    // Ép kiểu chính xác sang TimeSpan vì kiểu `time` trong SQL Server tương ứng TimeSpan trong .NET
                    TimeSpan gioVao = (TimeSpan)row["GioVao"];
                    TimeSpan gioRa = (TimeSpan)row["GioRa"];

                    // Chỉ cộng nếu giờ ra sau giờ vào
                    if (gioRa > gioVao)
                    {
                        TimeSpan thoiGianLam = gioRa - gioVao;
                        tongGio += (decimal)thoiGianLam.TotalHours;
                    }
                }
            }

            return tongGio;
        }
        public DataSet TimKiemChamCongCungPhongBan(int phongBanID, string keyword)
        {
            string sql = $@"
            SELECT * 
            FROM ChamCong 
            WHERE NhanVienID IN (SELECT NhanVienID FROM NhanVien WHERE PhongBanID = {phongBanID}) 
            AND (NhanVienID LIKE '%{keyword}%' OR Ngay LIKE '%{keyword}%' OR GioVao LIKE '%{keyword}%' OR GioRa LIKE '%{keyword}%' OR TrangThai LIKE N'%{keyword}%')";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);

        }
    }
}
