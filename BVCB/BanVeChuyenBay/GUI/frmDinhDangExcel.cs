using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeChuyenBay.GUI
{
    public partial class frmDinhDangFileNhap : Form
    {
        private static frmDinhDangFileNhap _Instance = null;
        public static frmDinhDangFileNhap Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new frmDinhDangFileNhap();
                    return frmDinhDangFileNhap._Instance; 
            }
        }

        public bool CheckOk { get; set; }
        public bool CheckRemind { get; set; }

        public frmDinhDangFileNhap()
        {
            InitializeComponent();
            txtQDChung.Text = "\t1.File dữ liệu phải được lưu dưới định dạng .xls hoặc .xlsx.";
            txtQDChung.Text += "\n\t2. File dữ liệu phải có ít nhất 3 dòng(1 dòng tiêu đề, 1 dòng tên cột, còn lại là dữ liệu cần thêm vào.)";
            CheckOk = false;
            chbRemind.Checked = true;
            CheckRemind = true;
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            if (this.Visible)
                this.Visible = false;
            CheckOk = false;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (this.Visible)
                this.Visible = false;
            CheckOk = true;
        }

        private void chbRemind_CheckedChanged(object sender, EventArgs e)
        {
            CheckRemind = chbRemind.Checked;
        }

        private void frmDinhDangExcel_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
                tabMain.SelectedTab = tabQDChung;
        }

        
    }
}
