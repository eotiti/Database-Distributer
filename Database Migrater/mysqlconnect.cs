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
        public static MySqlConnection mysqlconn(string server,string database, string username,string pass)
        {
            MySqlConnection mysqlcon = new MySqlConnection("server="+server+ ";user id="+username+";password="+pass+";oldguids=True;connectiontimeout=9999;database="+database+";port=3306;connectionreset=True");
            return mysqlcon;
        }
    }
}
