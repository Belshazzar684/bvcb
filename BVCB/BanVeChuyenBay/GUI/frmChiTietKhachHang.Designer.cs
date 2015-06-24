﻿namespace BanVeChuyenBay.GUI
{
    partial class frmChiTietKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietKhachHang));
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btThoat = new DevComponents.DotNetBar.ButtonX();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDanhSachChuyenBay = new System.Windows.Forms.ComboBox();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.DienThoaiHanhKhach = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.CMNDHanhKhach = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.TenHanhKhach = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HangVe = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.MaPhieuDat = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.TenNguoiDat = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Image = global::BanVeChuyenBay.Properties.Resources.Save_icon;
            this.btnLuu.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnLuu.Location = new System.Drawing.Point(291, 437);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(106, 53);
            this.btnLuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuu.TabIndex = 88;
            this.btnLuu.Text = "Lưu";
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.reflectionLabel1.Location = new System.Drawing.Point(235, 12);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(335, 56);
            this.reflectionLabel1.TabIndex = 87;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i></i><font color=\"#B02B2C\">CHI TIẾT KHÁCH HÀNG</font></font>" +
    "</b>";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNguoiDat,
            this.MaPhieuDat,
            this.HangVe,
            this.CMND,
            this.DienThoai,
            this.NgayDat,
            this.TenHanhKhach,
            this.CMNDHanhKhach,
            this.DienThoaiHanhKhach});
            this.dataGridView1.Location = new System.Drawing.Point(3, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 269);
            this.dataGridView1.TabIndex = 3;
            // 
            // btThoat
            // 
            this.btThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.Image = global::BanVeChuyenBay.Properties.Resources.Windows_Close_Program_icon;
            this.btThoat.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btThoat.Location = new System.Drawing.Point(431, 437);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(106, 53);
            this.btThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btThoat.TabIndex = 84;
            this.btThoat.Text = "Thoát";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(70, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(88, 56);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 86;
            this.PictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(269, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Khách hàng:";
            // 
            // cbDanhSachChuyenBay
            // 
            this.cbDanhSachChuyenBay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDanhSachChuyenBay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbDanhSachChuyenBay.FormattingEnabled = true;
            this.cbDanhSachChuyenBay.Location = new System.Drawing.Point(368, 87);
            this.cbDanhSachChuyenBay.Name = "cbDanhSachChuyenBay";
            this.cbDanhSachChuyenBay.Size = new System.Drawing.Size(187, 27);
            this.cbDanhSachChuyenBay.TabIndex = 0;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnLuu);
            this.panelEx1.Controls.Add(this.reflectionLabel1);
            this.panelEx1.Controls.Add(this.PictureBox1);
            this.panelEx1.Controls.Add(this.label2);
            this.panelEx1.Controls.Add(this.dataGridView1);
            this.panelEx1.Controls.Add(this.btThoat);
            this.panelEx1.Controls.Add(this.cbDanhSachChuyenBay);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(950, 514);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 6;
            // 
            // DienThoaiHanhKhach
            // 
            this.DienThoaiHanhKhach.HeaderText = "Điện Thoại Hành Khách";
            this.DienThoaiHanhKhach.Name = "DienThoaiHanhKhach";
            this.DienThoaiHanhKhach.ReadOnly = true;
            // 
            // CMNDHanhKhach
            // 
            this.CMNDHanhKhach.HeaderText = "CMND Hành Khách";
            this.CMNDHanhKhach.Name = "CMNDHanhKhach";
            this.CMNDHanhKhach.ReadOnly = true;
            // 
            // TenHanhKhach
            // 
            this.TenHanhKhach.HeaderText = "Tên Hành Khách ";
            this.TenHanhKhach.Name = "TenHanhKhach";
            this.TenHanhKhach.ReadOnly = true;
            // 
            // NgayDat
            // 
            this.NgayDat.HeaderText = "Ngày Đặt";
            this.NgayDat.Name = "NgayDat";
            this.NgayDat.ReadOnly = true;
            // 
            // DienThoai
            // 
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.ReadOnly = true;
            // 
            // CMND
            // 
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            // 
            // HangVe
            // 
            this.HangVe.HeaderText = "Hạng Vé";
            this.HangVe.Name = "HangVe";
            this.HangVe.ReadOnly = true;
            // 
            // MaPhieuDat
            // 
            this.MaPhieuDat.HeaderText = "Mã Phiếu Đặt";
            this.MaPhieuDat.Name = "MaPhieuDat";
            this.MaPhieuDat.ReadOnly = true;
            // 
            // TenNguoiDat
            // 
            this.TenNguoiDat.HeaderText = "Tên Khách Hàng";
            this.TenNguoiDat.Name = "TenNguoiDat";
            this.TenNguoiDat.ReadOnly = true;
            // 
            // frmChiTietKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 514);
            this.Controls.Add(this.panelEx1);
            this.Name = "frmChiTietKhachHang";
            this.Text = "CHI TIẾT KHÁCH HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnLuu;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevComponents.DotNetBar.ButtonX btThoat;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDanhSachChuyenBay;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn TenNguoiDat;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn MaPhieuDat;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn HangVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn TenHanhKhach;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn CMNDHanhKhach;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn DienThoaiHanhKhach;
    }
}