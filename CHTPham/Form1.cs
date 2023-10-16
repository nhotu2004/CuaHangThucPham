using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHTPham
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void    cỬAHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangnhap cc= new dangnhap();
            cc.Show();
            this.Hide();
        }

        private void kIỂMTRAĐƠNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kiemtrathucpham hello = new Kiemtrathucpham();
            hello.Show();
            this.Hide();
        }

        private void kIỂMTRATHỰCPHẨMBÁNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongtinnguoimua ha = new Thongtinnguoimua();
            ha.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void cẬPNHÂPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa Có Bản Cập Nhập  Mới", "Thành Công", MessageBoxButtons.OK);
        }
    }
}
