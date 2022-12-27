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
            this.plChinh = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ngườiDùngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 24);
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
            this.ngườiDùngToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.ngườiDùngToolStripMenuItem.Text = "Người dùng";
            this.ngườiDùngToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsmQuanTriNguoiDung
            // 
            this.tsmQuanTriNguoiDung.Name = "tsmQuanTriNguoiDung";
            this.tsmQuanTriNguoiDung.Size = new System.Drawing.Size(180, 22);
            this.tsmQuanTriNguoiDung.Text = "Quản trị";
            this.tsmQuanTriNguoiDung.Click += new System.EventHandler(this.tsmQuanTriNguoiDung_Click);
            // 
            // tsmThoat
            // 
            this.tsmThoat.Name = "tsmThoat";
            this.tsmThoat.Size = new System.Drawing.Size(180, 22);
            this.tsmThoat.Text = "Thoát";
            this.tsmThoat.Click += new System.EventHandler(this.tsmDangXuat_Click);
            // 
            // plChinh
            // 
            this.plChinh.Location = new System.Drawing.Point(0, 27);
            this.plChinh.Name = "plChinh";
            this.plChinh.Size = new System.Drawing.Size(948, 561);
            this.plChinh.TabIndex = 1;
            // 
            // FrmGiaoDienChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 588);
            this.Controls.Add(this.plChinh);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
    }
}