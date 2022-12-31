namespace Thanh.HeThong
{
    partial class FrmGiaoDienChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiaoDienChinh));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ngườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQuanTriNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFileKey = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDanhSachKey = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plChinh = new System.Windows.Forms.Panel();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ngườiDùngToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ngườiDùngToolStripMenuItem
            // 
            this.ngườiDùngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmQuanTriNguoiDung,
            this.tsmThoat});
            this.ngườiDùngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ngườiDùngToolStripMenuItem.Image")));
            this.ngườiDùngToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ngườiDùngToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ngườiDùngToolStripMenuItem.Name = "ngườiDùngToolStripMenuItem";
            this.ngườiDùngToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ngườiDùngToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.ngườiDùngToolStripMenuItem.Text = "Người dùng";
            this.ngườiDùngToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsmQuanTriNguoiDung
            // 
            this.tsmQuanTriNguoiDung.Name = "tsmQuanTriNguoiDung";
            this.tsmQuanTriNguoiDung.Size = new System.Drawing.Size(224, 26);
            this.tsmQuanTriNguoiDung.Text = "Quản trị";
            this.tsmQuanTriNguoiDung.Click += new System.EventHandler(this.tsmQuanTriNguoiDung_Click);
            // 
            // tsmThoat
            // 
            this.tsmThoat.Name = "tsmThoat";
            this.tsmThoat.Size = new System.Drawing.Size(224, 26);
            this.tsmThoat.Text = "Thoát";
            this.tsmThoat.Click += new System.EventHandler(this.tsmDangXuat_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFileKey,
            this.tsmDanhSachKey,
            this.danhSáchFileToolStripMenuItem});
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 24);
            this.toolStripMenuItem1.Text = "Từ khóa";
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsmFileKey
            // 
            this.tsmFileKey.Name = "tsmFileKey";
            this.tsmFileKey.Size = new System.Drawing.Size(224, 26);
            this.tsmFileKey.Text = "Tải lên";
            this.tsmFileKey.Click += new System.EventHandler(this.tsmFileKey_Click);
            // 
            // tsmDanhSachKey
            // 
            this.tsmDanhSachKey.Name = "tsmDanhSachKey";
            this.tsmDanhSachKey.Size = new System.Drawing.Size(224, 26);
            this.tsmDanhSachKey.Text = "Danh sách key";
            this.tsmDanhSachKey.Click += new System.EventHandler(this.tsmTaiLenFileTuKhoa_Click);
            // 
            // danhSáchFileToolStripMenuItem
            // 
            this.danhSáchFileToolStripMenuItem.Name = "danhSáchFileToolStripMenuItem";
            this.danhSáchFileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.danhSáchFileToolStripMenuItem.Text = "Danh sách file";
            this.danhSáchFileToolStripMenuItem.Click += new System.EventHandler(this.danhSáchFileToolStripMenuItem_Click);
            // 
            // plChinh
            // 
            this.plChinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plChinh.Location = new System.Drawing.Point(0, 33);
            this.plChinh.Margin = new System.Windows.Forms.Padding(4);
            this.plChinh.Name = "plChinh";
            this.plChinh.Size = new System.Drawing.Size(1264, 690);
            this.plChinh.TabIndex = 1;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripMenuItem2.Size = new System.Drawing.Size(108, 24);
            this.toolStripMenuItem2.Text = "Nhãn hiệu";
            this.toolStripMenuItem2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem3.Text = "Tải lên";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem4.Text = "Danh sách key";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem5.Text = "Danh sách file";
            // 
            // FrmGiaoDienChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 724);
            this.Controls.Add(this.plChinh);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGiaoDienChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao diện chính";
            this.Load += new System.EventHandler(this.FrmGiaoDienChinh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ngườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmQuanTriNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem tsmThoat;
        private System.Windows.Forms.Panel plChinh;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmFileKey;
        private System.Windows.Forms.ToolStripMenuItem tsmDanhSachKey;
        private System.Windows.Forms.ToolStripMenuItem danhSáchFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
    }
}