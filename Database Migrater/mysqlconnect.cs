using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace Database_Migrater
{
    internal class mysqlconnect
    {
        public static MySqlConnection mysqlconn(string server, string database, string username, string pass)
        {
            MySqlConnection mysqlcon = new MySqlConnection("server=" + server + ";user id=" + username + ";password=" + pass + ";oldguids=True;connectiontimeout=9999;database=" + database + ";port=3306;connectionreset=True");
            return mysqlcon;
        }
        public DataTable mytable(string sql, MySqlConnection conn)
        {
            conn.Open();
            MySqlDataAdapter adap = new MySqlDataAdapter(sql, conn);
            MySqlCommandBuilder cmd = new MySqlCommandBuilder(adap);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
            return dt;
        }
        public static void excutemysql(string sql, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
    }
}
