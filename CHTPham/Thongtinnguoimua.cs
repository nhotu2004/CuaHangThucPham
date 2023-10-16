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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CHTPham
{
    public partial class Thongtinnguoimua : Form
    {
        public Thongtinnguoimua()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Lấy thông tin từ các textBox
            string tennguoinhan = textBox1.Text;
            string diachinhanhang = textBox2.Text;
            string diachilienlac = textBox3.Text;
          


            // Lưu thông tin vào file text
            string filePath = "E:\\db.txt"; // Đường dẫn tới file lưu thông tin
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(" " + tennguoinhan);
                writer.WriteLine(" " + diachinhanhang);
                writer.WriteLine(" " + diachilienlac);
                

            }
            Kiemtrathucpham j = new Kiemtrathucpham();
            j.Show();   
            this.Hide();    
        }
    }
}
