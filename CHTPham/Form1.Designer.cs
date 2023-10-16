namespace CHTPham
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cỬAHÀNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kIỂMTRAĐƠNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kIỂMTRATHỰCPHẨMBÁNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cẬPNHÂPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cỬAHÀNGToolStripMenuItem,
            this.kIỂMTRAĐƠNToolStripMenuItem,
            this.kIỂMTRATHỰCPHẨMBÁNToolStripMenuItem,
            this.cẬPNHÂPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cỬAHÀNGToolStripMenuItem
            // 
            this.cỬAHÀNGToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cỬAHÀNGToolStripMenuItem.Name = "cỬAHÀNGToolStripMenuItem";
            this.cỬAHÀNGToolStripMenuItem.Size = new System.Drawing.Size(93, 21);
            this.cỬAHÀNGToolStripMenuItem.Text = "CỬA HÀNG ";
            this.cỬAHÀNGToolStripMenuItem.Click += new System.EventHandler(this.cỬAHÀNGToolStripMenuItem_Click);
            // 
            // kIỂMTRAĐƠNToolStripMenuItem
            // 
            this.kIỂMTRAĐƠNToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kIỂMTRAĐƠNToolStripMenuItem.Name = "kIỂMTRAĐƠNToolStripMenuItem";
            this.kIỂMTRAĐƠNToolStripMenuItem.Size = new System.Drawing.Size(297, 21);
            this.kIỂMTRAĐƠNToolStripMenuItem.Text = "Kiểm Tra Thực Phẩm Và Địa Chỉ Người Dùng";
            this.kIỂMTRAĐƠNToolStripMenuItem.Click += new System.EventHandler(this.kIỂMTRAĐƠNToolStripMenuItem_Click);
            // 
            // kIỂMTRATHỰCPHẨMBÁNToolStripMenuItem
            // 
            this.kIỂMTRATHỰCPHẨMBÁNToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kIỂMTRATHỰCPHẨMBÁNToolStripMenuItem.Name = "kIỂMTRATHỰCPHẨMBÁNToolStripMenuItem";
            this.kIỂMTRATHỰCPHẨMBÁNToolStripMenuItem.Size = new System.Drawing.Size(158, 21);
            this.kIỂMTRATHỰCPHẨMBÁNToolStripMenuItem.Text = "Thông Tin Người Mua";
            this.kIỂMTRATHỰCPHẨMBÁNToolStripMenuItem.Click += new System.EventHandler(this.kIỂMTRATHỰCPHẨMBÁNToolStripMenuItem_Click);
            // 
            // cẬPNHÂPToolStripMenuItem
            // 
            this.cẬPNHÂPToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cẬPNHÂPToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cẬPNHÂPToolStripMenuItem.Name = "cẬPNHÂPToolStripMenuItem";
            this.cẬPNHÂPToolStripMenuItem.Size = new System.Drawing.Size(86, 21);
            this.cẬPNHÂPToolStripMenuItem.Text = "CẬP NHÂP";
            this.cẬPNHÂPToolStripMenuItem.Click += new System.EventHandler(this.cẬPNHÂPToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CHTPham.Properties.Resources.thuc_pham_sach;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 423);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cỬAHÀNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kIỂMTRAĐƠNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kIỂMTRATHỰCPHẨMBÁNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cẬPNHÂPToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

