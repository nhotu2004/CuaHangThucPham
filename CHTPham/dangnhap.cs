﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CHTPham
{
    public partial class dangnhap : Form
     
       
    {
        SqlConnection sqlcon = null;

        public dangnhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sqlcon == null) 
            {
                sqlcon = new SqlConnection(@"Data Source=LAB1-MAY04\MISASME2022;Initial Catalog=DANGNHAP;Integrated Security=True"); 
            }
            if (sqlcon.State == ConnectionState.Closed)
            {     
                sqlcon.Open();
            }
            string tk = textBox1.Text.Trim();
            string mk = textBox2.Text.Trim();

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "SELECT * FROM nguoidungtaikhoan WHERE Nguoidung = '"+ tk +"' AND Matkhaunguoidung = '" + mk + "'";

            sqlcmd.Connection = sqlcon;

            SqlDataReader data = sqlcmd.ExecuteReader();
            if (data.Read() == true)
            {
                MessageBox.Show("Đăng Nhập Thành Công");
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}