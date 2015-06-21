namespace BanVeChuyenBay.GUI
{
    partial class frmThemSanBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemSanBay));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.cbThanhPho = new System.Windows.Forms.ComboBox();
            this.cbQuocGia = new System.Windows.Forms.ComboBox();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnTaoMoi = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btThoat = new DevComponents.DotNetBar.ButtonX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTenSanBay = new System.Windows.Forms.TextBox();
            this.txtMaSanBay = new System.Windows.Forms.TextBox();
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
            this.panelEx1.Controls.Add(this.cbThanhPho);
            this.panelEx1.Controls.Add(this.cbQuocGia);
            this.panelEx1.Controls.Add(this.btnThem);
            this.panelEx1.Controls.Add(this.btnTaoMoi);
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.Controls.Add(this.label4);
            this.panelEx1.Controls.Add(this.btThoat);
            this.panelEx1.Controls.Add(this.reflectionLabel1);
            this.panelEx1.Controls.Add(this.PictureBox1);
            this.panelEx1.Controls.Add(this.txtTenSanBay);
            this.panelEx1.Controls.Add(this.txtMaSanBay);
            this.panelEx1.Controls.Add(this.Label3);
            this.panelEx1.Controls.Add(this.Label2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(548, 348);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // cbThanhPho
            // 
            this.cbThanhPho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThanhPho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbThanhPho.FormattingEnabled = true;
            this.cbThanhPho.Location = new System.Drawing.Point(216, 234);
            this.cbThanhPho.Name = "cbThanhPho";
            this.cbThanhPho.Size = new System.Drawing.Size(216, 27);
            this.cbThanhPho.TabIndex = 95;
            // 
            // cbQuocGia
            // 
            this.cbQuocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuocGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbQuocGia.FormattingEnabled = true;
            this.cbQuocGia.Location = new System.Drawing.Point(216, 194);
            this.cbQuocGia.Name = "cbQuocGia";
            this.cbQuocGia.Size = new System.Drawing.Size(216, 27);
            this.cbQuocGia.TabIndex = 94;
            this.cbQuocGia.SelectedIndexChanged += new System.EventHandler(this.cbQuocGia_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Image = global::BanVeChuyenBay.Properties.Resources.Actions_list_add_icon;
            this.btnThem.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnThem.Location = new System.Drawing.Point(73, 288);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 37);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 91;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTaoMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTaoMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaoMoi.Image = global::BanVeChuyenBay.Properties.Resources.create_icon;
            this.btnTaoMoi.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnTaoMoi.Location = new System.Drawing.Point(216, 288);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(110, 37);
            this.btnTaoMoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTaoMoi.TabIndex = 90;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(77, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Thành Phố:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(77, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "Quốc Gia:";
            // 
            // btThoat
            // 
            this.btThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.Image = global::BanVeChuyenBay.Properties.Resources.Windows_Close_Program_icon;
            this.btThoat.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btThoat.Location = new System.Drawing.Point(370, 288);
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
            this.reflectionLabel1.Location = new System.Drawing.Point(194, 35);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(217, 56);
            this.reflectionLabel1.TabIndex = 88;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i></i><font color=\"#B02B2C\">THÊM SÂN BAY</font></font></b>";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(77, 35);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(88, 56);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 42;
            this.PictureBox1.TabStop = false;
            // 
            // txtTenSanBay
            // 
            this.txtTenSanBay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenSanBay.ForeColor = System.Drawing.Color.Blue;
            this.txtTenSanBay.Location = new System.Drawing.Point(217, 154);
            this.txtTenSanBay.Name = "txtTenSanBay";
            this.txtTenSanBay.Size = new System.Drawing.Size(216, 26);
            this.txtTenSanBay.TabIndex = 38;
            // 
            // txtMaSanBay
            // 
            this.txtMaSanBay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSanBay.ForeColor = System.Drawing.Color.Blue;
            this.txtMaSanBay.Location = new System.Drawing.Point(217, 114);
            this.txtMaSanBay.Name = "txtMaSanBay";
            this.txtMaSanBay.Size = new System.Drawing.Size(216, 26);
            this.txtMaSanBay.TabIndex = 37;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Label3.Location = new System.Drawing.Point(77, 157);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(114, 23);
            this.Label3.TabIndex = 36;
            this.Label3.Text = "Tên Sân Bay:";
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Label2.Location = new System.Drawing.Point(77, 117);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(106, 23);
            this.Label2.TabIndex = 35;
            this.Label2.Text = "Mã Sân Bay:";
            // 
            // frmThemSanBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 348);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmThemSanBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Sân Bay";
            this.Load += new System.EventHandler(this.frmThemSanBay_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.TextBox txtTenSanBay;
        internal System.Windows.Forms.TextBox txtMaSanBay;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.ButtonX btnTaoMoi;
        private DevComponents.DotNetBar.ButtonX btThoat;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbThanhPho;
        private System.Windows.Forms.ComboBox cbQuocGia;
    }
}