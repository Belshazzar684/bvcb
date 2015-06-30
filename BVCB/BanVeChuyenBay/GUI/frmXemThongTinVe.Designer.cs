namespace BanVeChuyenBay.GUI
{
    partial class frmXemThongTinVe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXemThongTinVe));
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.btThoat = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaChuyenBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HangVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNguoiDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHanhKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMNDHanhKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoaiHanhKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HuyVe = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Image = global::BanVeChuyenBay.Properties.Resources.Save_icon;
            this.btnLuu.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnLuu.Location = new System.Drawing.Point(352, 377);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(106, 53);
            this.btnLuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuu.TabIndex = 88;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.reflectionLabel1.Location = new System.Drawing.Point(309, 12);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(246, 56);
            this.reflectionLabel1.TabIndex = 87;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i></i><font color=\"#B02B2C\">CHI TIẾT VÉ ĐẶT</font></font></b>" +
    "";
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
            // btThoat
            // 
            this.btThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.Image = global::BanVeChuyenBay.Properties.Resources.Windows_Close_Program_icon;
            this.btThoat.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btThoat.Location = new System.Drawing.Point(582, 377);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(106, 53);
            this.btThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btThoat.TabIndex = 84;
            this.btThoat.Text = "Thoát";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.dataGridView1);
            this.panelEx1.Controls.Add(this.btnLuu);
            this.panelEx1.Controls.Add(this.reflectionLabel1);
            this.panelEx1.Controls.Add(this.PictureBox1);
            this.panelEx1.Controls.Add(this.btThoat);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(950, 441);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChuyenBay,
            this.MaPhieuDat,
            this.HangVe,
            this.TenNguoiDat,
            this.DienThoai,
            this.CMND,
            this.NgayDat,
            this.TenHanhKhach,
            this.CMNDHanhKhach,
            this.DienThoaiHanhKhach,
            this.HuyVe});
            this.dataGridView1.Location = new System.Drawing.Point(4, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 269);
            this.dataGridView1.TabIndex = 90;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // MaChuyenBay
            // 
            this.MaChuyenBay.DataPropertyName = "MaChuyenBay";
            this.MaChuyenBay.HeaderText = "Mã chuyến bay";
            this.MaChuyenBay.Name = "MaChuyenBay";
            this.MaChuyenBay.ReadOnly = true;
            // 
            // MaPhieuDat
            // 
            this.MaPhieuDat.DataPropertyName = "MaPhieuDatCho";
            this.MaPhieuDat.HeaderText = "Mã Phiếu Đặt";
            this.MaPhieuDat.Name = "MaPhieuDat";
            this.MaPhieuDat.ReadOnly = true;
            this.MaPhieuDat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // HangVe
            // 
            this.HangVe.DataPropertyName = "TenHangVe";
            this.HangVe.HeaderText = "Hạng Vé";
            this.HangVe.Name = "HangVe";
            this.HangVe.ReadOnly = true;
            this.HangVe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TenNguoiDat
            // 
            this.TenNguoiDat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNguoiDat.DataPropertyName = "NguoiDat";
            this.TenNguoiDat.HeaderText = "Tên Người Đặt";
            this.TenNguoiDat.Name = "TenNguoiDat";
            this.TenNguoiDat.ReadOnly = true;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DTNguoiDat";
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.ReadOnly = true;
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMNDNguoiDat";
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            // 
            // NgayDat
            // 
            this.NgayDat.DataPropertyName = "NgayDat";
            this.NgayDat.HeaderText = "Ngày Đặt";
            this.NgayDat.Name = "NgayDat";
            this.NgayDat.ReadOnly = true;
            // 
            // TenHanhKhach
            // 
            this.TenHanhKhach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHanhKhach.DataPropertyName = "HanhKhachBay";
            this.TenHanhKhach.HeaderText = "Tên Hành Khách ";
            this.TenHanhKhach.Name = "TenHanhKhach";
            this.TenHanhKhach.ReadOnly = true;
            this.TenHanhKhach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CMNDHanhKhach
            // 
            this.CMNDHanhKhach.DataPropertyName = "CMNDNguoiBay";
            this.CMNDHanhKhach.HeaderText = "CMND Hành Khách";
            this.CMNDHanhKhach.Name = "CMNDHanhKhach";
            this.CMNDHanhKhach.ReadOnly = true;
            this.CMNDHanhKhach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DienThoaiHanhKhach
            // 
            this.DienThoaiHanhKhach.DataPropertyName = "DTNguoiBay";
            this.DienThoaiHanhKhach.HeaderText = "Điện Thoại Hành Khách";
            this.DienThoaiHanhKhach.Name = "DienThoaiHanhKhach";
            this.DienThoaiHanhKhach.ReadOnly = true;
            this.DienThoaiHanhKhach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // HuyVe
            // 
            this.HuyVe.HeaderText = "Hủy vé";
            this.HuyVe.Name = "HuyVe";
            this.HuyVe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // frmXemThongTinVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 441);
            this.Controls.Add(this.panelEx1);
            this.Name = "frmXemThongTinVe";
            this.Text = "XEM THÔNG TIN VÉ";
            this.Load += new System.EventHandler(this.frmXemThongTinVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnLuu;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private DevComponents.DotNetBar.ButtonX btThoat;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuyenBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn HangVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNguoiDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHanhKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMNDHanhKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoaiHanhKhach;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HuyVe;
    }
}