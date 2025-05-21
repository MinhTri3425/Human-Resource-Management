using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.BL_Layer
{
    internal class UserMode
    {
        DB db = null;
        public UserMode()
        {
            db = new DB();
        }
        public bool HasPermission(int userID, string functionName, string permissionType, ref string err)
        {
            try
            {
                // Chuyển loại quyền thành tên cột tương ứng
                string column = null;
                switch (permissionType)
                {
                    case "View":
                        column = "CanView";
                        break;
                    case "Add":
                        column = "CanAdd";
                        break;
                    case "Edit":
                        column = "CanEdit";
                        break;
                    case "Delete":
                        column = "CanDelete";
                        break;
                    case "Export":
                        column = "CanExport";
                        break;
                    default:
                        err = "Loại quyền không hợp lệ.";
                        return false;
                }
                if (column == null)
                {
                    err = "Loại quyền không hợp lệ.";
                    return false;
                }

                string query = $@"
                SELECT COUNT(*) 
                FROM Users u
                JOIN RolePermissions rp ON u.RoleID = rp.RoleID
                JOIN Permissions p ON rp.PermissionID = p.PermissionID
                WHERE u.UserID = {userID}
                    AND p.FunctionName = N'{functionName}'
                    AND p.{column} = 1";

                DataSet ds = db.ExecuteQueryDataSet(query, CommandType.Text);
                int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

                return count > 0;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
    }
}
