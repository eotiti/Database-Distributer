using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Migrater
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string servername ;
        public static string database ;
        public static string username ;
        public static string pass;
        private void button1_Click(object sender, EventArgs e)
        {
            servername=txt_server.Text.ToString();
            database=txt_data.Text.ToString();
            username=txt_username.Text.ToString();
            pass = txt_pass.Text.ToString();
            try
            {
                SqlConnection conn=sqlconnect.sqlconn(servername,database,username,pass);
                conn.Open();
                if(conn.State.Equals(ConnectionState.Open))
                {
                    this.Hide();
                    MainForm mainf = new MainForm();
                    mainf.ShowDialog();
                    MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG");
                }
                else
                {
                    MessageBox.Show("ERRO");
                }
                conn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
