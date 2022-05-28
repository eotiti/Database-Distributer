using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Database_Migrater
{
    internal class sqlconnect
    {
        public static SqlConnection sqlconn(string server,string database,string user,string pass)
        {
            SqlConnection sqlcon = new  SqlConnection(@"Data Source="+server+";Initial Catalog="+database+";User ID="+user+";Password="+pass+";");
            return sqlcon;
        }
        public static DataTable getData(string sql,SqlConnection conn)
        {
            conn.Open();
            SqlDataAdapter adap = new SqlDataAdapter(sql, conn);
            SqlCommandBuilder cmd = new SqlCommandBuilder(adap);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
            return dt;
        }
        
    }
}
