﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy thông tin sản phẩm từ nguồn dữ liệu nào đó
            string tenSanPham = "bắp cải";
            string thongTinSanPham = "Cây bắp cải hay cải bắp (Brassica oleracea nhóm Capitata) là một loại rau chủ lực trong họ Cải. Cải bắp là cây thân thảo, thời gian sống khoảng 2 năm và là cây có hoa thuộc nhóm hai là mầm, hình dáng cầu đặc trưng.";
            decimal giaSanPham = 10;
            string luuY = "An toàn";


            // Hiển thị thông tin lên các control tương ứng
            textBox2.Text = tenSanPham;
            textBox3.Text = thongTinSanPham;
            textBox7.Text = giaSanPham.ToString();
            textBox6.Text = luuY;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Lấy thông tin sản phẩm từ nguồn dữ liệu nào đó
            string tenSanPham = "cải bẹ";
            string thongTinSanPham = "Cây bắp cải hay cải bắp (Brassica oleracea nhóm Capitata) là một loại rau chủ lực trong họ Cải. Cải bắp là cây thân thảo, thời gian sống khoảng 2 năm và là cây có hoa thuộc nhóm hai là mầm, hình dáng cầu đặc trưng.";
            decimal giaSanPham = 20;
            string luuY = "An toàn";


            // Hiển thị thông tin lên các control tương ứng
            textBox2.Text = tenSanPham;
            textBox3.Text = thongTinSanPham;
            textBox7.Text = giaSanPham.ToString();
            textBox6.Text = luuY;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Lấy thông tin sản phẩm từ nguồn dữ liệu nào đó
            string tenSanPham = "dâu";
            string thongTinSanPham = "Cây bắp cải hay cải bắp (Brassica oleracea nhóm Capitata) là một loại rau chủ lực trong họ Cải. Cải bắp là cây thân thảo, thời gian sống khoảng 2 năm và là cây có hoa thuộc nhóm hai là mầm, hình dáng cầu đặc trưng.";
            decimal giaSanPham = 30;
            string luuY = "An toàn";


            // Hiển thị thông tin lên các control tương ứng
            textBox2.Text = tenSanPham;
            textBox3.Text = thongTinSanPham;
            textBox7.Text = giaSanPham.ToString();
            textBox6.Text = luuY;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Lấy thông tin sản phẩm từ nguồn dữ liệu nào đó
            string tenSanPham = "Rau Củ Các Loại Một Ít";
            string thongTinSanPham = "chủ lực trong họ Cải. Cải bắp là cây thân thảo, thời gian sống khoảng 2 năm và là cây có hoa thuộc nhóm hai là mầm, hình dáng cầu đặc trưng.";
            decimal giaSanPham = 40;
            string luuY = "An toàn";


            // Hiển thị thông tin lên các control tương ứng
            textBox2.Text = tenSanPham;
            textBox3.Text = thongTinSanPham;
            textBox7.Text = giaSanPham.ToString();
            textBox6.Text = luuY;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Lấy thông tin sản phẩm từ nguồn dữ liệu nào đó
            string tenSanPham = "thịt ";
            string thongTinSanPham = "Cây bắp cải hay cải bắp (Brassica oleracea nhóm Capitata) là một loại rau chủ lực trong họ Cải. Cải bắp là cây thân thảo, thời gian sống khoảng 2 năm và là cây có hoa thuộc nhóm hai là mầm, hình dáng cầu đặc trưng.";
            decimal giaSanPham = 50;
            string luuY = "Ăn Chín";


            // Hiển thị thông tin lên các control tương ứng
            textBox2.Text = tenSanPham;
            textBox3.Text = thongTinSanPham;
            textBox7.Text = giaSanPham.ToString();
            textBox6.Text = luuY;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Lấy thông tin sản phẩm từ nguồn dữ liệu nào đó
            string tenSanPham = "gà";
            string thongTinSanPham = "Thịt gà được biết đến là loại thịt giàu đạm nhưng ít chất béo nên rất tốt cho những ai muốn phát triển cơ bắp hay giảm cân lâu dài. Thịt gà dồi dào loại axit amin tryptophan giúp làm tăng nồng độ serotonin trong não bộ của bạn, nếu ăn thường xuyên sẽ cải thiện tâm trạng và giảm căng thẳng.";
            decimal giaSanPham = 60;
            string luuY = "Ăn Chín";


            // Hiển thị thông tin lên các control tương ứng
            textBox2.Text = tenSanPham;
            textBox3.Text = thongTinSanPham;
            textBox7.Text = giaSanPham.ToString();
            textBox6.Text = luuY;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string tenSanPham = "Đầy Đủ loại";
            string thongTinSanPham = "chứa nhiều dưỡng chất bổ ích nên ăn";
            decimal giaSanPham = 80;
            string luuY = "An Toàn";


            textBox2.Text = tenSanPham;
            textBox3.Text = thongTinSanPham;
            textBox7.Text = giaSanPham.ToString();
            textBox6.Text = luuY;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string tenSanPham = "Cherry";
            string thongTinSanPham = "chứa nhiều dưỡng chất bổ ích nên ăn";
            decimal giaSanPham = 90;
            string luuY = "An Toàn";


            textBox2.Text = tenSanPham;
            textBox3.Text = thongTinSanPham;
            textBox7.Text = giaSanPham.ToString();
            textBox6.Text = luuY;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tenSanPham = "Vải";
            string thongTinSanPham = "chứa nhiều dưỡng chất bổ ích nên ăn";
            decimal giaSanPham = 100;
            string luuY = "An Toàn";


            textBox2.Text = tenSanPham;
            textBox3.Text = thongTinSanPham;
            textBox7.Text = giaSanPham.ToString();
            textBox6.Text = luuY;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string tenSanPham = "Cam";
            string thongTinSanPham = "chứa nhiều dưỡng chất bổ ích nên ăn";
            decimal giaSanPham = 110;
            string luuY = "An Toàn";


            textBox2.Text = tenSanPham;
            textBox3.Text = thongTinSanPham;
            textBox7.Text = giaSanPham.ToString();
            textBox6.Text = luuY;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string tenSanPham = "Nho";
            string thongTinSanPham = "chứa nhiều dưỡng chất bổ ích nên ăn";
            decimal giaSanPham = 120;
            string luuY = "An Toàn";


            textBox2.Text = tenSanPham;
            textBox3.Text = thongTinSanPham;
            textBox7.Text = giaSanPham.ToString();
            textBox6.Text = luuY;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {





























































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các textBox
            string tenSanPham = textBox2.Text;
            string thongTinSanPham = textBox3.Text;
            string giaSanPham = textBox7.Text;
            string luuY = textBox6.Text;

            // Lưu thông tin vào file text
            string filePath = "D:\\muaA.txt.txt"; // Đường dẫn tới file lưu thông tin
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Tên sản phẩm: " + tenSanPham);
                writer.WriteLine("Thông tin sản phẩm: " + thongTinSanPham);
                writer.WriteLine("Giá sản phẩm: " + giaSanPham);
                writer.WriteLine("Lưu ý: " + luuY);
            }


            Thongtinnguoimua helo = new Thongtinnguoimua();
            helo.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form1 hel=new Form1();
            hel.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string tenSanPham = "Ổi";
            string thongTinSanPham = "chứa nhiều dưỡng chất bổ ích nên ăn";
            decimal giaSanPham = 130;
            string luuY = "An Toàn";


            textBox2.Text = tenSanPham;
            textBox3.Text = thongTinSanPham;
            textBox7.Text = giaSanPham.ToString();
            textBox6.Text = luuY;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string tenSanPham = "Cải Đắng";
            string thongTinSanPham = "chứa nhiều dưỡng chất bổ ích nên ăn ";
            decimal giaSanPham = 140;
            string luuY = "An Toàn";


            textBox2.Text = tenSanPham;
            textBox3.Text = thongTinSanPham;
            textBox7.Text = giaSanPham.ToString();
            textBox6.Text = luuY;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string tenSanPham = "Thực Phẩm Nhập Khẩu Không phun Thuốc";
            string thongTinSanPham = "chứa nhiều dưỡng chất bổ ích nên ăn";
            decimal giaSanPham = 150;
            string luuY = "An Toàn";


            textBox2.Text = tenSanPham;
            textBox3.Text = thongTinSanPham;
            textBox7.Text = giaSanPham.ToString();
            textBox6.Text = luuY;
        }
    }
}
