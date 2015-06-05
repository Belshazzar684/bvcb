namespace BanVeChuyenBay.GUI
{
    partial class frmTraCuuChuyenBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuChuyenBay));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupTimKiem = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.chbTinhTrang = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chbGiaVe = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chbNgayKhoiHanh = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chbSanBayDen = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chbSanBayDi = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chbMaChuyenBay = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.rbtnHetGhe = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.rbtnConGhe = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.lblTinhTrangGhe = new System.Windows.Forms.Label();
            this.lblGiaVeMin = new System.Windows.Forms.Label();
            this.lblGiaVeMax = new System.Windows.Forms.Label();
            this.txtGiaVeMax = new DevComponents.Editors.IntegerInput();
            this.txtGiaVeMin = new DevComponents.Editors.IntegerInput();
            this.lblGiaVe = new System.Windows.Forms.Label();
            this.txtMaChuyenBay = new System.Windows.Forms.TextBox();
            this.lblMaChuyenBay = new System.Windows.Forms.Label();
            this.txtTenSanBayDen = new System.Windows.Forms.TextBox();
            this.txtTenSanBayDi = new System.Windows.Forms.TextBox();
            this.lblSanBayDi = new System.Windows.Forms.Label();
            this.lblSanBayDen = new System.Windows.Forms.Label();
            this.btThoat = new DevComponents.DotNetBar.ButtonX();
            this.cbSanBayDi = new System.Windows.Forms.ComboBox();
            this.btnTim = new DevComponents.DotNetBar.ButtonX();
            this.cbSanBayDen = new System.Windows.Forms.ComboBox();
            this.lblNgayKhoiHanh = new System.Windows.Forms.Label();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgwDSChuyenBay = new System.Windows.Forms.DataGridView();
            this.MaChuyenBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanBayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanBayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianKhoiHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoGheTrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            this.groupTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaVeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaVeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDSChuyenBay)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupTimKiem);
            this.panelEx1.Controls.Add(this.reflectionLabel1);
            this.panelEx1.Controls.Add(this.PictureBox1);
            this.panelEx1.Controls.Add(this.groupPanel2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1200, 567);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // groupTimKiem
            // 
            this.groupTimKiem.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupTimKiem.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupTimKiem.Controls.Add(this.chbTinhTrang);
            this.groupTimKiem.Controls.Add(this.chbGiaVe);
            this.groupTimKiem.Controls.Add(this.chbNgayKhoiHanh);
            this.groupTimKiem.Controls.Add(this.chbSanBayDen);
            this.groupTimKiem.Controls.Add(this.chbSanBayDi);
            this.groupTimKiem.Controls.Add(this.chbMaChuyenBay);
            this.groupTimKiem.Controls.Add(this.rbtnHetGhe);
            this.groupTimKiem.Controls.Add(this.rbtnConGhe);
            this.groupTimKiem.Controls.Add(this.lblTinhTrangGhe);
            this.groupTimKiem.Controls.Add(this.lblGiaVeMin);
            this.groupTimKiem.Controls.Add(this.lblGiaVeMax);
            this.groupTimKiem.Controls.Add(this.txtGiaVeMax);
            this.groupTimKiem.Controls.Add(this.txtGiaVeMin);
            this.groupTimKiem.Controls.Add(this.lblGiaVe);
            this.groupTimKiem.Controls.Add(this.txtMaChuyenBay);
            this.groupTimKiem.Controls.Add(this.lblMaChuyenBay);
            this.groupTimKiem.Controls.Add(this.txtTenSanBayDen);
            this.groupTimKiem.Controls.Add(this.txtTenSanBayDi);
            this.groupTimKiem.Controls.Add(this.lblSanBayDi);
            this.groupTimKiem.Controls.Add(this.lblSanBayDen);
            this.groupTimKiem.Controls.Add(this.btThoat);
            this.groupTimKiem.Controls.Add(this.cbSanBayDi);
            this.groupTimKiem.Controls.Add(this.btnTim);
            this.groupTimKiem.Controls.Add(this.cbSanBayDen);
            this.groupTimKiem.Controls.Add(this.lblNgayKhoiHanh);
            this.groupTimKiem.Controls.Add(this.lblTuNgay);
            this.groupTimKiem.Controls.Add(this.lblDenNgay);
            this.groupTimKiem.Controls.Add(this.dtpDenNgay);
            this.groupTimKiem.Controls.Add(this.dtpTuNgay);
            this.groupTimKiem.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupTimKiem.Location = new System.Drawing.Point(747, 93);
            this.groupTimKiem.Name = "groupTimKiem";
            this.groupTimKiem.Size = new System.Drawing.Size(441, 380);
            // 
            // 
            // 
            this.groupTimKiem.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupTimKiem.Style.BackColorGradientAngle = 90;
            this.groupTimKiem.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupTimKiem.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupTimKiem.Style.BorderBottomWidth = 1;
            this.groupTimKiem.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupTimKiem.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupTimKiem.Style.BorderLeftWidth = 1;
            this.groupTimKiem.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupTimKiem.Style.BorderRightWidth = 1;
            this.groupTimKiem.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupTimKiem.Style.BorderTopWidth = 1;
            this.groupTimKiem.Style.CornerDiameter = 4;
            this.groupTimKiem.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupTimKiem.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupTimKiem.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupTimKiem.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupTimKiem.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupTimKiem.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupTimKiem.TabIndex = 0;
            this.groupTimKiem.Text = "Tìm kiếm";
            // 
            // chbTinhTrang
            // 
            // 
            // 
            // 
            this.chbTinhTrang.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chbTinhTrang.CheckSignSize = new System.Drawing.Size(15, 15);
            this.chbTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTinhTrang.Location = new System.Drawing.Point(16, 273);
            this.chbTinhTrang.Name = "chbTinhTrang";
            this.chbTinhTrang.Size = new System.Drawing.Size(15, 15);
            this.chbTinhTrang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chbTinhTrang.TabIndex = 13;
            // 
            // chbGiaVe
            // 
            // 
            // 
            // 
            this.chbGiaVe.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chbGiaVe.CheckSignSize = new System.Drawing.Size(15, 15);
            this.chbGiaVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbGiaVe.Location = new System.Drawing.Point(14, 213);
            this.chbGiaVe.Name = "chbGiaVe";
            this.chbGiaVe.Size = new System.Drawing.Size(15, 15);
            this.chbGiaVe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chbGiaVe.TabIndex = 10;
            // 
            // chbNgayKhoiHanh
            // 
            // 
            // 
            // 
            this.chbNgayKhoiHanh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chbNgayKhoiHanh.CheckSignSize = new System.Drawing.Size(15, 15);
            this.chbNgayKhoiHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbNgayKhoiHanh.Location = new System.Drawing.Point(14, 145);
            this.chbNgayKhoiHanh.Name = "chbNgayKhoiHanh";
            this.chbNgayKhoiHanh.Size = new System.Drawing.Size(15, 15);
            this.chbNgayKhoiHanh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chbNgayKhoiHanh.TabIndex = 7;
            // 
            // chbSanBayDen
            // 
            // 
            // 
            // 
            this.chbSanBayDen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chbSanBayDen.CheckSignSize = new System.Drawing.Size(15, 15);
            this.chbSanBayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbSanBayDen.Location = new System.Drawing.Point(14, 104);
            this.chbSanBayDen.Name = "chbSanBayDen";
            this.chbSanBayDen.Size = new System.Drawing.Size(15, 15);
            this.chbSanBayDen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chbSanBayDen.TabIndex = 5;
            // 
            // chbSanBayDi
            // 
            // 
            // 
            // 
            this.chbSanBayDi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chbSanBayDi.CheckSignSize = new System.Drawing.Size(15, 15);
            this.chbSanBayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbSanBayDi.Location = new System.Drawing.Point(14, 63);
            this.chbSanBayDi.Name = "chbSanBayDi";
            this.chbSanBayDi.Size = new System.Drawing.Size(15, 15);
            this.chbSanBayDi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chbSanBayDi.TabIndex = 3;
            // 
            // chbMaChuyenBay
            // 
            // 
            // 
            // 
            this.chbMaChuyenBay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chbMaChuyenBay.CheckSignSize = new System.Drawing.Size(15, 15);
            this.chbMaChuyenBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMaChuyenBay.Location = new System.Drawing.Point(14, 23);
            this.chbMaChuyenBay.Name = "chbMaChuyenBay";
            this.chbMaChuyenBay.Size = new System.Drawing.Size(15, 15);
            this.chbMaChuyenBay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chbMaChuyenBay.TabIndex = 1;
            // 
            // rbtnHetGhe
            // 
            // 
            // 
            // 
            this.rbtnHetGhe.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbtnHetGhe.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.rbtnHetGhe.CheckSignSize = new System.Drawing.Size(15, 15);
            this.rbtnHetGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHetGhe.Location = new System.Drawing.Point(277, 270);
            this.rbtnHetGhe.Name = "rbtnHetGhe";
            this.rbtnHetGhe.Size = new System.Drawing.Size(105, 23);
            this.rbtnHetGhe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbtnHetGhe.TabIndex = 15;
            this.rbtnHetGhe.Text = "Hết Ghế";
            // 
            // rbtnConGhe
            // 
            // 
            // 
            // 
            this.rbtnConGhe.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbtnConGhe.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.rbtnConGhe.Checked = true;
            this.rbtnConGhe.CheckSignSize = new System.Drawing.Size(15, 15);
            this.rbtnConGhe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rbtnConGhe.CheckValue = "Y";
            this.rbtnConGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnConGhe.Location = new System.Drawing.Point(138, 270);
            this.rbtnConGhe.Name = "rbtnConGhe";
            this.rbtnConGhe.Size = new System.Drawing.Size(109, 23);
            this.rbtnConGhe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbtnConGhe.TabIndex = 14;
            this.rbtnConGhe.Text = "Còn Ghế Trống";
            // 
            // lblTinhTrangGhe
            // 
            this.lblTinhTrangGhe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTinhTrangGhe.Location = new System.Drawing.Point(37, 270);
            this.lblTinhTrangGhe.Name = "lblTinhTrangGhe";
            this.lblTinhTrangGhe.Size = new System.Drawing.Size(95, 23);
            this.lblTinhTrangGhe.TabIndex = 0;
            this.lblTinhTrangGhe.Text = "Tình Trạng:";
            // 
            // lblGiaVeMin
            // 
            this.lblGiaVeMin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGiaVeMin.Location = new System.Drawing.Point(44, 233);
            this.lblGiaVeMin.Name = "lblGiaVeMin";
            this.lblGiaVeMin.Size = new System.Drawing.Size(50, 23);
            this.lblGiaVeMin.TabIndex = 0;
            this.lblGiaVeMin.Text = "From:";
            // 
            // lblGiaVeMax
            // 
            this.lblGiaVeMax.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGiaVeMax.Location = new System.Drawing.Point(239, 233);
            this.lblGiaVeMax.Name = "lblGiaVeMax";
            this.lblGiaVeMax.Size = new System.Drawing.Size(32, 23);
            this.lblGiaVeMax.TabIndex = 0;
            this.lblGiaVeMax.Text = "To:";
            // 
            // txtGiaVeMax
            // 
            // 
            // 
            // 
            this.txtGiaVeMax.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtGiaVeMax.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGiaVeMax.ButtonCalculator.Tooltip = "";
            this.txtGiaVeMax.ButtonClear.Tooltip = "";
            this.txtGiaVeMax.ButtonCustom.Tooltip = "";
            this.txtGiaVeMax.ButtonCustom2.Tooltip = "";
            this.txtGiaVeMax.ButtonDropDown.Tooltip = "";
            this.txtGiaVeMax.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtGiaVeMax.ButtonFreeText.Tooltip = "";
            this.txtGiaVeMax.Increment = 1000;
            this.txtGiaVeMax.Location = new System.Drawing.Point(277, 233);
            this.txtGiaVeMax.MinValue = 0;
            this.txtGiaVeMax.Name = "txtGiaVeMax";
            this.txtGiaVeMax.ShowUpDown = true;
            this.txtGiaVeMax.Size = new System.Drawing.Size(120, 20);
            this.txtGiaVeMax.TabIndex = 12;
            // 
            // txtGiaVeMin
            // 
            // 
            // 
            // 
            this.txtGiaVeMin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtGiaVeMin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGiaVeMin.ButtonCalculator.Tooltip = "";
            this.txtGiaVeMin.ButtonClear.Tooltip = "";
            this.txtGiaVeMin.ButtonCustom.Tooltip = "";
            this.txtGiaVeMin.ButtonCustom2.Tooltip = "";
            this.txtGiaVeMin.ButtonDropDown.Tooltip = "";
            this.txtGiaVeMin.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtGiaVeMin.ButtonFreeText.Tooltip = "";
            this.txtGiaVeMin.Increment = 1000;
            this.txtGiaVeMin.Location = new System.Drawing.Point(100, 233);
            this.txtGiaVeMin.MinValue = 0;
            this.txtGiaVeMin.Name = "txtGiaVeMin";
            this.txtGiaVeMin.ShowUpDown = true;
            this.txtGiaVeMin.Size = new System.Drawing.Size(120, 20);
            this.txtGiaVeMin.TabIndex = 11;
            this.txtGiaVeMin.ValueChanged += new System.EventHandler(this.txtGiaVeMin_ValueChanged);
            // 
            // lblGiaVe
            // 
            this.lblGiaVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGiaVe.Location = new System.Drawing.Point(35, 210);
            this.lblGiaVe.Name = "lblGiaVe";
            this.lblGiaVe.Size = new System.Drawing.Size(111, 23);
            this.lblGiaVe.TabIndex = 0;
            this.lblGiaVe.Text = "Giá Vé(VNĐ):";
            // 
            // txtMaChuyenBay
            // 
            this.txtMaChuyenBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaChuyenBay.Location = new System.Drawing.Point(169, 17);
            this.txtMaChuyenBay.MaxLength = 10;
            this.txtMaChuyenBay.Name = "txtMaChuyenBay";
            this.txtMaChuyenBay.Size = new System.Drawing.Size(200, 24);
            this.txtMaChuyenBay.TabIndex = 2;
            this.txtMaChuyenBay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaChuyenBay_KeyPress);
            // 
            // lblMaChuyenBay
            // 
            this.lblMaChuyenBay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaChuyenBay.Location = new System.Drawing.Point(35, 20);
            this.lblMaChuyenBay.Name = "lblMaChuyenBay";
            this.lblMaChuyenBay.Size = new System.Drawing.Size(128, 23);
            this.lblMaChuyenBay.TabIndex = 0;
            this.lblMaChuyenBay.Text = "Mã Chuyến Bay:";
            // 
            // txtTenSanBayDen
            // 
            this.txtTenSanBayDen.Location = new System.Drawing.Point(231, 101);
            this.txtTenSanBayDen.Name = "txtTenSanBayDen";
            this.txtTenSanBayDen.ReadOnly = true;
            this.txtTenSanBayDen.Size = new System.Drawing.Size(187, 20);
            this.txtTenSanBayDen.TabIndex = 0;
            // 
            // txtTenSanBayDi
            // 
            this.txtTenSanBayDi.Location = new System.Drawing.Point(231, 57);
            this.txtTenSanBayDi.Name = "txtTenSanBayDi";
            this.txtTenSanBayDi.ReadOnly = true;
            this.txtTenSanBayDi.Size = new System.Drawing.Size(187, 20);
            this.txtTenSanBayDi.TabIndex = 0;
            // 
            // lblSanBayDi
            // 
            this.lblSanBayDi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSanBayDi.Location = new System.Drawing.Point(35, 60);
            this.lblSanBayDi.Name = "lblSanBayDi";
            this.lblSanBayDi.Size = new System.Drawing.Size(97, 23);
            this.lblSanBayDi.TabIndex = 0;
            this.lblSanBayDi.Text = "Sân Bay Đi:";
            // 
            // lblSanBayDen
            // 
            this.lblSanBayDen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSanBayDen.Location = new System.Drawing.Point(35, 100);
            this.lblSanBayDen.Name = "lblSanBayDen";
            this.lblSanBayDen.Size = new System.Drawing.Size(103, 23);
            this.lblSanBayDen.TabIndex = 0;
            this.lblSanBayDen.Text = "Sân Bay Đến:";
            // 
            // btThoat
            // 
            this.btThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.Image = global::BanVeChuyenBay.Properties.Resources.Windows_Close_Program_icon;
            this.btThoat.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btThoat.Location = new System.Drawing.Point(250, 311);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(88, 37);
            this.btThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btThoat.TabIndex = 18;
            this.btThoat.Text = "Thoát";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // cbSanBayDi
            // 
            this.cbSanBayDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSanBayDi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSanBayDi.ForeColor = System.Drawing.Color.Blue;
            this.cbSanBayDi.Location = new System.Drawing.Point(138, 55);
            this.cbSanBayDi.Name = "cbSanBayDi";
            this.cbSanBayDi.Size = new System.Drawing.Size(87, 25);
            this.cbSanBayDi.TabIndex = 4;
            this.cbSanBayDi.SelectedIndexChanged += new System.EventHandler(this.cbSanBayDi_SelectedIndexChanged);
            this.cbSanBayDi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbSanBayDi_MouseClick);
            // 
            // btnTim
            // 
            this.btnTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.Image = global::BanVeChuyenBay.Properties.Resources.Zoom_icon;
            this.btnTim.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnTim.Location = new System.Drawing.Point(97, 311);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(82, 37);
            this.btnTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTim.TabIndex = 16;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cbSanBayDen
            // 
            this.cbSanBayDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSanBayDen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSanBayDen.ForeColor = System.Drawing.Color.Blue;
            this.cbSanBayDen.Location = new System.Drawing.Point(138, 98);
            this.cbSanBayDen.Name = "cbSanBayDen";
            this.cbSanBayDen.Size = new System.Drawing.Size(87, 25);
            this.cbSanBayDen.TabIndex = 6;
            this.cbSanBayDen.SelectedIndexChanged += new System.EventHandler(this.cbSanBayDen_SelectedIndexChanged);
            this.cbSanBayDen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbSanBayDen_MouseClick);
            // 
            // lblNgayKhoiHanh
            // 
            this.lblNgayKhoiHanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayKhoiHanh.Location = new System.Drawing.Point(35, 142);
            this.lblNgayKhoiHanh.Name = "lblNgayKhoiHanh";
            this.lblNgayKhoiHanh.Size = new System.Drawing.Size(134, 23);
            this.lblNgayKhoiHanh.TabIndex = 0;
            this.lblNgayKhoiHanh.Text = "Ngày Khởi Hành:";
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTuNgay.Location = new System.Drawing.Point(44, 170);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(50, 23);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "From:";
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDenNgay.Location = new System.Drawing.Point(239, 170);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(32, 23);
            this.lblDenNgay.TabIndex = 0;
            this.lblDenNgay.Text = "To:";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(277, 168);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(120, 20);
            this.dtpDenNgay.TabIndex = 9;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(100, 168);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(120, 20);
            this.dtpTuNgay.TabIndex = 8;
            this.dtpTuNgay.ValueChanged += new System.EventHandler(this.dtpTuNgay_ValueChanged);
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.reflectionLabel1.Location = new System.Drawing.Point(430, 24);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(317, 56);
            this.reflectionLabel1.TabIndex = 0;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i></i><font color=\"#B02B2C\">TRA CỨU CHUYẾN BAY</font></font><" +
    "/b>";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(121, 24);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(88, 56);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 53;
            this.PictureBox1.TabStop = false;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.dgwDSChuyenBay);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(12, 93);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(729, 380);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 0;
            this.groupPanel2.Text = "Danh sách chuyến bay";
            // 
            // dgwDSChuyenBay
            // 
            this.dgwDSChuyenBay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDSChuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDSChuyenBay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChuyenBay,
            this.SanBayDi,
            this.SanBayDen,
            this.ThoiGianKhoiHanh,
            this.ThoiGianBay,
            this.SoGheTrong,
            this.GiaVe});
            this.dgwDSChuyenBay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwDSChuyenBay.Location = new System.Drawing.Point(0, 0);
            this.dgwDSChuyenBay.Name = "dgwDSChuyenBay";
            this.dgwDSChuyenBay.Size = new System.Drawing.Size(723, 359);
            this.dgwDSChuyenBay.TabIndex = 17;
            // 
            // MaChuyenBay
            // 
            this.MaChuyenBay.DataPropertyName = "MaChuyenBay";
            this.MaChuyenBay.HeaderText = "Mã Chuyến Bay";
            this.MaChuyenBay.Name = "MaChuyenBay";
            this.MaChuyenBay.ReadOnly = true;
            // 
            // SanBayDi
            // 
            this.SanBayDi.DataPropertyName = "SanBayDi";
            this.SanBayDi.HeaderText = "Sân Bay Đi";
            this.SanBayDi.Name = "SanBayDi";
            this.SanBayDi.ReadOnly = true;
            this.SanBayDi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SanBayDi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SanBayDen
            // 
            this.SanBayDen.DataPropertyName = "SanBayDen";
            this.SanBayDen.HeaderText = "Sân Bay Đến";
            this.SanBayDen.Name = "SanBayDen";
            this.SanBayDen.ReadOnly = true;
            this.SanBayDen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SanBayDen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ThoiGianKhoiHanh
            // 
            this.ThoiGianKhoiHanh.DataPropertyName = "KhoiHanh";
            this.ThoiGianKhoiHanh.HeaderText = "Thời Gian Khởi Hành";
            this.ThoiGianKhoiHanh.Name = "ThoiGianKhoiHanh";
            this.ThoiGianKhoiHanh.ReadOnly = true;
            this.ThoiGianKhoiHanh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ThoiGianBay
            // 
            this.ThoiGianBay.DataPropertyName = "ThoiGianBay";
            this.ThoiGianBay.HeaderText = "Thời Gian Bay";
            this.ThoiGianBay.Name = "ThoiGianBay";
            this.ThoiGianBay.ReadOnly = true;
            this.ThoiGianBay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ThoiGianBay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SoGheTrong
            // 
            this.SoGheTrong.DataPropertyName = "SoGheTrong";
            this.SoGheTrong.HeaderText = "Số Ghế Trống";
            this.SoGheTrong.Name = "SoGheTrong";
            this.SoGheTrong.ReadOnly = true;
            this.SoGheTrong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SoGheTrong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GiaVe
            // 
            this.GiaVe.DataPropertyName = "GiaVe";
            this.GiaVe.HeaderText = "Giá Vé";
            this.GiaVe.Name = "GiaVe";
            this.GiaVe.ReadOnly = true;
            this.GiaVe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GiaVe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmTraCuuChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 567);
            this.Controls.Add(this.panelEx1);
            this.Name = "frmTraCuuChuyenBay";
            this.Text = "Tra Cứu Chuyến Bay";
            this.panelEx1.ResumeLayout(false);
            this.groupTimKiem.ResumeLayout(false);
            this.groupTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaVeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaVeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDSChuyenBay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label lblDenNgay;
        internal System.Windows.Forms.DateTimePicker dtpDenNgay;
        internal System.Windows.Forms.DateTimePicker dtpTuNgay;
        internal System.Windows.Forms.Label lblTuNgay;
        internal System.Windows.Forms.ComboBox cbSanBayDen;
        internal System.Windows.Forms.ComboBox cbSanBayDi;
        internal System.Windows.Forms.Label lblNgayKhoiHanh;
        internal System.Windows.Forms.Label lblSanBayDen;
        internal System.Windows.Forms.Label lblSanBayDi;
        private DevComponents.DotNetBar.ButtonX btnTim;
        private DevComponents.DotNetBar.ButtonX btThoat;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private System.Windows.Forms.DataGridView dgwDSChuyenBay;
        private DevComponents.DotNetBar.Controls.GroupPanel groupTimKiem;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.TextBox txtTenSanBayDen;
        private System.Windows.Forms.TextBox txtTenSanBayDi;
        internal System.Windows.Forms.Label lblMaChuyenBay;
        private System.Windows.Forms.TextBox txtMaChuyenBay;
        internal System.Windows.Forms.Label lblGiaVe;
        private DevComponents.Editors.IntegerInput txtGiaVeMin;
        private DevComponents.Editors.IntegerInput txtGiaVeMax;
        internal System.Windows.Forms.Label lblGiaVeMax;
        internal System.Windows.Forms.Label lblGiaVeMin;
        internal System.Windows.Forms.Label lblTinhTrangGhe;
        private DevComponents.DotNetBar.Controls.CheckBoxX rbtnConGhe;
        private DevComponents.DotNetBar.Controls.CheckBoxX rbtnHetGhe;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbMaChuyenBay;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbSanBayDi;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbSanBayDen;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbNgayKhoiHanh;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbGiaVe;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuyenBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanBayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanBayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianKhoiHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoGheTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaVe;
    }
}