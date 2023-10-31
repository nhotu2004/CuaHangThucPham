using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHTPham
{
    public partial class Kiemtrathucpham : Form
    {
        public Kiemtrathucpham()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Đường dẫn tới file chứa thông tin
            string filePath = "D:\\muaA.txt.txt";

            // Kiểm tra sự tồn tại của file
            if (File.Exists(filePath))
            {
                // Đọc nội dung của file
                string[] lines = File.ReadAllLines(filePath);

                // Kiểm tra số lượng dòng trong file
                if (lines.Length >= 4)
                {
                    // Lấy thông tin từ file
                    string tenSanPham = lines[0];
                    string thongTinSanPham = lines[1];
                    string gioiThieuSanPham = lines[2];
                    string giaSanPham = lines[3];

                    // Hiển thị thông tin lên các textBox
                    textBox2.Text = tenSanPham;
                    textBox3.Text = thongTinSanPham;
                    textBox4.Text = gioiThieuSanPham;
                    textBox8.Text = giaSanPham;
                }
                else
                {
                    // Nếu file không có đầy đủ thông tin
                    MessageBox.Show("File không đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Nếu file không tồn tại
                MessageBox.Show("File không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Đường dẫn tới file chứa thông tin
            string filePath = "D:\\luuAA.txt.txt";

            // Kiểm tra sự tồn tại của file
            if (File.Exists(filePath))
            {
                // Đọc nội dung của file
                string[] lines = File.ReadAllLines(filePath);

                // Kiểm tra số lượng dòng trong file
                if (lines.Length >= 3)
                {
                    // Lấy thông tin từ file
                    string  ten = lines[0];
                    string diachi = lines[1];
                    string sdt = lines[2];
                   

                    // Hiển thị thông tin lên các textBox
                    textBox5.Text = ten;
                    textBox6.Text = diachi;
                    textBox7.Text = sdt;
                   
                }
                else
                {
                    // Nếu file không có đầy đủ thông tin
                    MessageBox.Show("File không đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hàng Của Bạn Đang  Đóng Gói ", "Thành Công", MessageBoxButtons.OK );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 hel = new Form1();
            hel.Show();
            this.Hide();
        }
    }
}