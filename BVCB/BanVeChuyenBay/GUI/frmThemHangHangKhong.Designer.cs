﻿namespace BanVeChuyenBay.GUI
{
    partial class frmThemHangHangKhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemHangHangKhong));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btThoat = new DevComponents.DotNetBar.ButtonX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnThem);
            this.panelEx1.Controls.Add(this.btThoat);
            this.panelEx1.Controls.Add(this.reflectionLabel1);
            this.panelEx1.Controls.Add(this.PictureBox1);
            this.panelEx1.Controls.Add(this.txtTenHang);
            this.panelEx1.Controls.Add(this.txtMaHang);
            this.panelEx1.Controls.Add(this.Label3);
            this.panelEx1.Controls.Add(this.Label2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(509, 256);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Image = global::BanVeChuyenBay.Properties.Resources.Actions_list_add_icon;
            this.btnThem.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnThem.Location = new System.Drawing.Point(120, 203);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 37);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 91;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btThoat
            // 
            this.btThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.Image = global::BanVeChuyenBay.Properties.Resources.Windows_Close_Program_icon;
            this.btThoat.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btThoat.Location = new System.Drawing.Point(312, 203);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(99, 37);
            this.btThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btThoat.TabIndex = 89;
            this.btThoat.Text = "Thoát";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.reflectionLabel1.Location = new System.Drawing.Point(129, 35);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(380, 56);
            this.reflectionLabel1.TabIndex = 88;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i></i><font color=\"#B02B2C\">THÊM HÃNG HÀNG KHÔNG</font></font" +
    "></b>";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(12, 35);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(88, 56);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 42;
            this.PictureBox1.TabStop = false;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenHang.ForeColor = System.Drawing.Color.Blue;
            this.txtTenHang.Location = new System.Drawing.Point(217, 154);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(216, 26);
            this.txtTenHang.TabIndex = 38;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHang.ForeColor = System.Drawing.Color.Blue;
            this.txtMaHang.Location = new System.Drawing.Point(217, 114);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.ReadOnly = true;
            this.txtMaHang.Size = new System.Drawing.Size(216, 26);
            this.txtMaHang.TabIndex = 37;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Label3.Location = new System.Drawing.Point(77, 157);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(114, 23);
            this.Label3.TabIndex = 36;
            this.Label3.Text = "Tên Hãng:";
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Label2.Location = new System.Drawing.Point(77, 117);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(106, 23);
            this.Label2.TabIndex = 35;
            this.Label2.Text = "Mã Hãng:";
            // 
            // frmThemHangHangKhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 256);
            this.Controls.Add(this.panelEx1);
            this.Name = "frmThemHangHangKhong";
            this.Text = "THÊM HÃNG HÀNG KHÔNG";
            this.Load += new System.EventHandler(this.frmThemHangHangKhong_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.ButtonX btThoat;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.TextBox txtTenHang;
        internal System.Windows.Forms.TextBox txtMaHang;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
    }
}