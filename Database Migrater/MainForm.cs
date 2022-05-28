using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Database_Migrater
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public static string sqlname=Login.servername;
        public static string sqldata =Login.database;
        public static string sqluser =Login.username;
        public static string sqlpass =Login.pass;
        public static SqlConnection sqlconn = sqlconnect.sqlconn(sqlname,sqldata,sqluser,sqlpass);
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txt_mysqlpass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_mysqlpass.UseSystemPasswordChar = true;
            }
        }
        public bool checknull(string str)
        {
            if(str == null)
            {
                return true;
            }
            return false;
        }
        private void btn_mysql_Click(object sender, EventArgs e)
        {
            string servername=txt_mysqlserver.Text.ToString();
            string data=txt_mysqldata.Text.ToString();
            string user=txt_mysqluser.Text.ToString();
            string pass=txt_mysqlpass.Text.ToString();
            try
            {
                if(checknull(servername)==false&&checknull(data)==false&&checknull(user)==false&&checknull(pass)==false)
                {
                    label_stat.Text = "CONNECTTING";
                    label_stat.ForeColor = Color.Orange;
                    try
                    {
                        MySqlConnection conn = mysqlconnect.mysqlconn(servername,data,user,pass);
                        conn.Open();
                        
                        if(conn.State == ConnectionState.Open)
                        {
                            groupBox2.Enabled = true;
                            groupBox2.Visible = true;
                            label_stat.Text = "CONNECT SUCCESSED";
                            label_stat.ForeColor = Color.Green;
                        }
                        else
                        {
                            label_stat.Text = "CONNECT FAILED";
                            label_stat.ForeColor = Color.Red;
                            MessageBox.Show("Error");
                        }
                        conn.Close();
                    }
                    catch (Exception exx)
                    {

                        MessageBox.Show(exx.Message);
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select TABLE_NAME from " + sqldata + ".INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME !='sysdiagrams'";
                DataTable dt = sqlconnect.getData(sql, sqlconn);
                for (int i = 1; i < dt.Rows.Count; i++)
                {
                    cbx_table.Items.Add(dt.Rows[i][0].ToString());
                }
                cbx_table.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cbx_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_table.SelectedIndex != 0)
            {
                string tablename = cbx_table.Text.ToString();
                try
                {

                    string sql = @" use " + sqldata + " SELECT * FROM [dbo]." + tablename;
                    DataTable dt = sqlconnect.getData(sql, sqlconn);
                    dgv_MSSQL.DataSource = dt;
                    label_test.Text = tablename;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            
        }
    }
}
