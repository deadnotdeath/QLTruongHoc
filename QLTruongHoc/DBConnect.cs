using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTruongHoc
{
    internal class DBConnect
    {
        public SqlConnection conn;
        public DBConnect() 
        {
            //conn = new SqlConnection(Properties.Settings.Default.connStr);
        }
        public string tableName = "";
        public DataTable Load_Data(string table)
        {
            tableName = table;
            return Load_Data(); /// gvHsinh = name cua data gridview
        }

        public DataTable Load_Data()
        {
            string sqlStr = string.Format("SELECT * FROM {0}", tableName);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
            DataTable dtConNguoi = new DataTable();
            adapter.Fill(dtConNguoi);
            return dtConNguoi; /// gvHsinh = name cua data gridview
        }

        public void ThucThi(String sqlStr)
        {
            try
            {
                // Ket noi
                //conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
