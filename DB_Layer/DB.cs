using System;
using System.Data;
using System.Data.SqlClient;

namespace QLNS
{
    internal class DB
    {
        string ConnStr = "Data Source=(local);Initial Catalog=QLNS;Integrated Security=True";

        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            using (SqlCommand comm = new SqlCommand(strSQL, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(comm))
            {
                comm.CommandType = ct;
                DataSet ds = new DataSet();
                conn.Open();
                da.Fill(ds);
                return ds;
            }
        }

        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnStr))
                using (SqlCommand comm = new SqlCommand(strSQL, conn))
                {
                    comm.CommandType = ct;
                    conn.Open();
                    comm.ExecuteNonQuery();
                    return true;
                }
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public object ExecuteScalar(string sqlString, CommandType commandType)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnStr))
                using (SqlCommand comm = new SqlCommand(sqlString, conn))
                {
                    comm.CommandType = commandType;
                    conn.Open();
                    return comm.ExecuteScalar();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
