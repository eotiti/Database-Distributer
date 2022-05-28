
namespace Database_Migrater
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbx_table = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_phantan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_test = new System.Windows.Forms.Label();
            this.dgv_MSSQL = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_stat = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txt_mysqlserver = new System.Windows.Forms.TextBox();
            this.btn_mysql = new System.Windows.Forms.Button();
            this.txt_mysqluser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mysqlpass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mysqldata = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MSSQL)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_table
            // 
            this.cbx_table.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbx_table.FormattingEnabled = true;
            this.cbx_table.Items.AddRange(new object[] {
            "-- Chọn bảng --"});
            this.cbx_table.Location = new System.Drawing.Point(156, 41);
            this.cbx_table.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_table.Name = "cbx_table";
            this.cbx_table.Size = new System.Drawing.Size(288, 30);
            this.cbx_table.TabIndex = 1;
            this.cbx_table.SelectedIndexChanged += new System.EventHandler(this.cbx_table_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "MS SQL TABLE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(1411, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "ĐIều kiện phân tán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(314, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "PHÂN TÁN TỚI MYSQL";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.richTextBox1.Location = new System.Drawing.Point(1328, 95);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(400, 198);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // btn_phantan
            // 
            this.btn_phantan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_phantan.Location = new System.Drawing.Point(1464, 324);
            this.btn_phantan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_phantan.Name = "btn_phantan";
            this.btn_phantan.Size = new System.Drawing.Size(157, 47);
            this.btn_phantan.TabIndex = 9;
            this.btn_phantan.Text = "Disintegrate";
            this.btn_phantan.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label_test);
            this.groupBox2.Controls.Add(this.dgv_MSSQL);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbx_table);
            this.groupBox2.Controls.Add(this.btn_phantan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 441);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1886, 602);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MS SQLSERVER";
            this.groupBox2.Visible = false;
            // 
            // label_test
            // 
            this.label_test.AutoSize = true;
            this.label_test.Location = new System.Drawing.Point(469, 53);
            this.label_test.Name = "label_test";
            this.label_test.Size = new System.Drawing.Size(32, 16);
            this.label_test.TabIndex = 11;
            this.label_test.Text = "test";
            // 
            // dgv_MSSQL
            // 
            this.dgv_MSSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MSSQL.Location = new System.Drawing.Point(11, 95);
            this.dgv_MSSQL.Name = "dgv_MSSQL";
            this.dgv_MSSQL.RowHeadersWidth = 51;
            this.dgv_MSSQL.RowTemplate.Height = 24;
            this.dgv_MSSQL.Size = new System.Drawing.Size(1277, 478);
            this.dgv_MSSQL.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label_stat);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.txt_mysqlserver);
            this.groupBox1.Controls.Add(this.btn_mysql);
            this.groupBox1.Controls.Add(this.txt_mysqluser);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_mysqlpass);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_mysqldata);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(933, 354);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MYSQL SERVER";
            // 
            // label_stat
            // 
            this.label_stat.AutoSize = true;
            this.label_stat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stat.Location = new System.Drawing.Point(548, 263);
            this.label_stat.Name = "label_stat";
            this.label_stat.Size = new System.Drawing.Size(0, 29);
            this.label_stat.TabIndex = 13;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(564, 206);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 20);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Hiện";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txt_mysqlserver
            // 
            this.txt_mysqlserver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mysqlserver.Location = new System.Drawing.Point(260, 45);
            this.txt_mysqlserver.Name = "txt_mysqlserver";
            this.txt_mysqlserver.Size = new System.Drawing.Size(288, 30);
            this.txt_mysqlserver.TabIndex = 11;
            this.txt_mysqlserver.Text = "db4free.net";
            // 
            // btn_mysql
            // 
            this.btn_mysql.Location = new System.Drawing.Point(294, 247);
            this.btn_mysql.Name = "btn_mysql";
            this.btn_mysql.Size = new System.Drawing.Size(187, 69);
            this.btn_mysql.TabIndex = 10;
            this.btn_mysql.Text = "CONNECT TO MYSQL";
            this.btn_mysql.UseVisualStyleBackColor = true;
            this.btn_mysql.Click += new System.EventHandler(this.btn_mysql_Click);
            // 
            // txt_mysqluser
            // 
            this.txt_mysqluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mysqluser.Location = new System.Drawing.Point(260, 147);
            this.txt_mysqluser.Name = "txt_mysqluser";
            this.txt_mysqluser.Size = new System.Drawing.Size(288, 30);
            this.txt_mysqluser.TabIndex = 9;
            this.txt_mysqluser.Text = "thanhtri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(166, 202);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Password";
            // 
            // txt_mysqlpass
            // 
            this.txt_mysqlpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mysqlpass.Location = new System.Drawing.Point(260, 196);
            this.txt_mysqlpass.Name = "txt_mysqlpass";
            this.txt_mysqlpass.Size = new System.Drawing.Size(288, 30);
            this.txt_mysqlpass.TabIndex = 7;
            this.txt_mysqlpass.Text = "tri123456";
            this.txt_mysqlpass.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(171, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Database";
            // 
            // txt_mysqldata
            // 
            this.txt_mysqldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mysqldata.Location = new System.Drawing.Point(260, 99);
            this.txt_mysqldata.Name = "txt_mysqldata";
            this.txt_mysqldata.Size = new System.Drawing.Size(288, 30);
            this.txt_mysqldata.TabIndex = 5;
            this.txt_mysqldata.Text = "quanlytro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(166, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(145, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Server name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DATABASE DISTRIBUTER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MSSQL)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbx_table;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_phantan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_MSSQL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_mysql;
        private System.Windows.Forms.TextBox txt_mysqluser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_mysqlpass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_mysqldata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txt_mysqlserver;
        private System.Windows.Forms.Label label_stat;
        private System.Windows.Forms.Label label_test;
    }
}

